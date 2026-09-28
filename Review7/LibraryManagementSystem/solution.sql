/*Problem – Library Management System
Design a Library Management database containing books, authors, members, book copies, borrowing and fines.

Requirements
Implement:


Normalized design for books and authors.

PK/FK and appropriate constraints.

Joins to display currently borrowed books.

CTE to identify the most borrowed books.

Subquery to identify members with fines above the average fine.

Temporary table containing overdue books.

View for overdue-book information.

UDF to calculate overdue fine.

Stored procedure for returning a book.

Trigger to automatically generate a fine when a book is returned late.

Cursor to process overdue members.

Indexes on ISBN, member ID and due date.

Transaction with locking while issuing a book.

Create a library schema and grant librarian permissions.

*/

--CREATING SCHEMA
CREATE SCHEMA LIBRARY;

--Crate books table
CREATE TABLE library.books(
 book_id SERIAL PRIMARY KEY,
 isbn VARCHAR(20) NOT NULL UNIQUE,
 title VARCHAR(200),
 publish_year INT
);
INSERT INTO library.books(isbn,title,publish_year)
VALUES ('111','Atomic Habits',1997),
	   ('112','Mental Piece',2008),
	   ('113','Clean Earth', 2018),
	   ('114','Harry Potter', 1949);
SELECT * from library.books;


--Create authors table
CREATE TABLE library.authors(
 author_id SERIAL PRIMARY KEY,
 author_name VARCHAR(100) NOT NULL
);
INSERT INTO library.authors(author_name) 
VALUES ('Anuradha'),('Preet'),('Robert'),('Rahul');
SELECT * from library.authors;


--Create book authors table
CREATE TABLE library.book_authors(
 book_id INT NOT NULL,
 author_id INT NOT NULL,
 PRIMARY KEY (book_id,author_id),
 FOREIGN KEY (book_id) REFERENCES library.books(book_id),
 FOREIGN KEY (author_id) REFERENCES library.authors(author_id)
);
INSERT INTO library.book_authors(book_id,author_id)
VALUEs (1,1),(2,2),(3,3),(4,4);
SELECT * from library.book_authors;


--Create members table
CREATE TABLE library.members(
 member_id SERIAL PRIMARY KEY,
 member_name VARCHAR(50) NOT NULL,
 email VARCHAR(100) UNIQUE NOT NULL,
 phone VARCHAR(20),
 join_date DATE DEFAULT CURRENT_DATE
);
INSERT INTO library.members(member_name,email,phone)
VALUES ('Rahul','rahul@gmail.com',9865432767),
		('Priya','priya@gmail.com',6789054321),
		('Aman','aman@gmail.com',9087654321),
		('Neha','neha@gmai.com',7890654321);
SELECT * from library.members;


--Create book copies table
CREATE TABLE library.book_copies(
	copy_id SERIAL PRIMARY KEY,
	book_id INT,
	copy_number VARCHAR(20) UNIQUE,
	status VARCHAR(15) DEFAULT 'AVAILABLE',
	FOREIGN KEY (book_id) REFERENCES library.books(book_id),
	CHECK (status IN ('AVAILABLE','BORROWED'))
);
INSERT INTO library.book_copies(book_id,copy_number)
VALUES (1,'AB01'),
	   (1,'AB02'),
	   (2,'07CD'),
	   (3,'CC01'),
	   (4,'CD02');
SELECT * from library.book_copies;


--Create borrowings table
CREATE TABLE library.borrowings(
	borrow_id SERIAL PRIMARY KEY,
	copy_id INT,
	member_id INT,
	borrow_date DATE DEFAULT CURRENT_DATE,
	due_date DATE NOT NULL,
	return_date DATE,
	FOREIGN KEY(copy_id) REFERENCES library.book_copies(copy_id),
	FOREIGN KEY(member_id) REFERENCES library.members(member_id)
);
INSERT INTO library.borrowings(copy_id,member_id,borrow_date,due_date,return_date)
VALUES (1,1,'2026-09-01','2026-09-15',NULL),
	    (2,2,'2026-09-05','2026-09-20',NULL),
		(3,3,'2026-09-01','2026-09-10','2026-09-12');
SELECT * from library.borrowings;


--Create fines table
CREATE TABLE library.fines(
	fine_id SERIAL PRIMARY KEY,
	borrow_id INT UNIQUE,
	amount NUMERIC(10,2),
	fine_date DATE DEFAULT CURRENT_DATE,
	FOREIGN KEY(borrow_id) REFERENCES library.borrowings(borrow_id)
);
INSERT INTO library.fines(borrow_id,amount)
VALUES (3,20),(1,50),(2,30);
SELECT * from library.fines;


--Update Borrowed copy status
UPDATE library.book_copies
SET status = 'BORROWED'
WHERE copy_id IN (1,2);

SELECT * FROM library.book_copies;

--Joins to display currently borrowed books.
SELECT 
	m.member_name, 
	b.title, 
	c.copy_number,
	br.borrow_date, 
	br.due_date 
FROM library.borrowings br
JOIN library.members m 
 	ON br.member_id = m.member_id
JOIN library.book_copies c 
 	ON br.copy_id = c.copy_id
JOIN library.books b 
 	ON c.book_id = b.book_id
WHERE br.return_date IS NULL;


---CTE to identify the most borrowed books.
WITH book_count_borrow AS 
(
  SELECT 
  		 c.book_id,
         COUNT(*) AS total_borrowed
   FROM library.borrowings br
   JOIN library.book_copies c
       ON br.copy_id = c.copy_id
	GROUP BY c.book_id
)
SELECT 
	   b.title,
	   bcb.total_borrowed
	   FROM library.books b
	   JOIN book_count_borrow bcb 
	      ON bcb.book_id = b.book_id
	   ORDER BY
		bcb.total_borrowed DESC;


---Subquery to identify members with fines above the average fine
SELECT DISTINCT 
  m.member_id, m.member_name 
FROM library.members m
JOIN library.borrowings br 
	ON m.member_id = br.member_id
JOIN library.fines f 
	ON br.borrow_id = f.borrow_id
 WHERE f.amount >
 (
 	 SELECT AVG(amount)
  	 from library.fines
);


---Temporary table containing overdue books.
CREATE TEMP TABLE overdue_books AS
SELECT
	br.borrow_id,
	m.member_name,
	b.title,
	br.due_date
FROM library.borrowings br
JOIN library.members m
	ON br.member_id = m.member_id
JOIN library.book_copies bc
	ON br.copy_id = bc.copy_id
JOIN library.books b 
	ON bc.book_id = b.book_id
WHERE br.due_date < CURRENT_DATE
AND br.return_date IS NULL;

SELECT * FROM overdue_books;

---View for overdue-book information.
CREATE VIEW library.overdue_books_view AS
SELECT
    br.borrow_id,
    m.member_name,
    b.title,
    br.due_date
FROM library.borrowings br
JOIN library.members m
    ON br.member_id = m.member_id
JOIN library.book_copies bc
    ON br.copy_id = bc.copy_id
JOIN library.books b
    ON bc.book_id = b.book_id
WHERE br.due_date < CURRENT_DATE
AND br.return_date IS NULL;

SELECT * FROM library.overdue_books_view;



---UDF to calculate overdue fine.
CREATE OR REPLACE FUNCTION library.calculate_fine(
    due_date DATE,
    return_date DATE
)
RETURNS NUMERIC
LANGUAGE plpgsql
AS $$
DECLARE
    days_late INT;
BEGIN

    IF return_date <= due_date THEN
        RETURN 0;
    END IF;

    days_late := return_date - due_date;

    RETURN days_late * 10;
END;
$$;

SELECT calculate_fine(
    '2026-09-10',
    '2026-09-13'
);

---Stored procedure for returning a book.
CREATE OR REPLACE PROCEDURE library.return_book(
    p_borrow_id INT,
    p_return_date DATE
)
LANGUAGE plpgsql
AS $$
BEGIN

    UPDATE library.borrowings
    SET return_date = p_return_date
    WHERE borrow_id = p_borrow_id;

    UPDATE library.book_copies
    SET status = 'AVAILABLE'
    WHERE copy_id = (
        SELECT copy_id
        FROM library.borrowings
        WHERE borrow_id = p_borrow_id
    );

END;
$$;

CALL library.return_book(1, '2026-09-25');


---Trigger to automatically generate a fine when a book is returned late.
CREATE OR REPLACE FUNCTION library.create_fine()
RETURNS TRIGGER
LANGUAGE plpgsql
AS $$
DECLARE
    fine_amount NUMERIC;
BEGIN

    IF NEW.return_date IS NOT NULL
       AND NEW.return_date > NEW.due_date THEN

        fine_amount :=
            library.calculate_fine(
                NEW.due_date,
                NEW.return_date
            );

        INSERT INTO library.fines
        (borrow_id, amount)
        VALUES
        (NEW.borrow_id, fine_amount);

    END IF;

    RETURN NEW;

END;
$$;


CREATE TRIGGER return_book_fine
AFTER UPDATE OF return_date
ON library.borrowings
FOR EACH ROW
EXECUTE FUNCTION library.create_fine();





---Cursor to process overdue members.
CREATE OR REPLACE PROCEDURE library.process_overdue_members()
LANGUAGE plpgsql
AS $$
DECLARE
    member_record RECORD;

    overdue_cursor CURSOR FOR
        SELECT DISTINCT
            m.member_id,
            m.member_name
        FROM library.members m
        JOIN library.borrowings br
            ON m.member_id = br.member_id
        WHERE br.due_date < CURRENT_DATE
        AND br.return_date IS NULL;

BEGIN

    OPEN overdue_cursor;

    LOOP

        FETCH overdue_cursor
        INTO member_record;

        EXIT WHEN NOT FOUND;

        RAISE NOTICE
            'Overdue Member: %',
            member_record.member_name;

    END LOOP;

    CLOSE overdue_cursor;

END;
$$;

CALL library.process_overdue_members();


---Indexes on ISBN, member ID and due date.
CREATE INDEX idx_books_isbn
ON library.books(isbn);

CREATE INDEX idx_borrowings_member
ON library.borrowings(member_id);

CREATE INDEX idx_borrowings_due_date
ON library.borrowings(due_date);



---Transaction with locking while issuing a book.
BEGIN;

--Lock the selected book copy
SELECT *
FROM library.book_copies
WHERE copy_id = 1
FOR UPDATE;

-- Issue book
INSERT INTO library.borrowings
(copy_id, member_id, borrow_date, due_date)
VALUES
(1, 4, CURRENT_DATE, CURRENT_DATE + 14);

-- Change copy status
UPDATE library.book_copies
SET status = 'BORROWED'
WHERE copy_id = 1;

COMMIT;


---Create a library schema and grant librarian permissions.
CREATE ROLE librarian
LOGIN
PASSWORD 'librarian123';

-- Give schema permission
GRANT USAGE
ON SCHEMA library
TO librarian;

-- Give table permissions
GRANT SELECT, INSERT, UPDATE, DELETE
ON ALL TABLES IN SCHEMA library
TO librarian;

-- Give permission to execute functions/procedures
GRANT EXECUTE
ON ALL FUNCTIONS IN SCHEMA library
TO librarian;

GRANT EXECUTE
ON ALL PROCEDURES IN SCHEMA library
TO librarian;