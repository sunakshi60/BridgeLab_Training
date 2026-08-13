using System;

namespace LinkedListQues
{
    class Program
    {
        static void Main(string[] args)
        {
            //EmployeeLinkedList employees = new EmployeeLinkedList();
            //Employee employee1 = new Employee(101, "Sunakshi", "CSE", 16000);
            //Employee employee2 = new Employee(102, "Priya", "CSE", 22000);
            //Employee employee3 = new Employee(103, "Akansha", "CSE", 13000);
            //Employee employee4 = new Employee(104, "Preeti", "CSE", 8000);
            //Employee employee5 = new Employee(105, "Krish", "CSE", 9000);
            //Console.WriteLine("\n1. ADD AT BEGINNING");
            //employees.AddAtBeginning(employee1);
            //employees.DisplayAll();
            //Console.WriteLine("\n2. ADD AT END");
            //employees.AddAtEnd(employee2);
            //employees.AddAtEnd(employee3);
            //employees.DisplayAll();
            //Console.WriteLine("\n3. ADD AT POSITION");
            //employees.AddAtPosition(employee4, 2);
            //employees.DisplayAll();
            //Console.WriteLine("\n4. ADD KRISH AT END");
            //employees.AddAtEnd(employee5);
            //employees.DisplayAll();
            //Console.WriteLine("\n5. SEARCH EMPLOYEE BY ID");
            //Employee resultById = employees.SearchById(103);
            //if (resultById != null)
            //{
            //    Console.WriteLine("Employee found:");
            //    resultById.Display();
            //}
            //else
            //{
            //    Console.WriteLine("Employee not found.");
            //}
            //Console.WriteLine("\n6. SEARCH EMPLOYEE BY NAME");
            //Employee resultByName = employees.SearchByName("Preeti");
            //if (resultByName != null)
            //{
            //    Console.WriteLine("Employee found:");
            //    resultByName.Display();
            //}
            //else
            //{
            //    Console.WriteLine("Employee not found.");
            //}
            //Console.WriteLine("\n7. DELETE EMPLOYEE BY ID");
            //employees.DeleteById(102);
            //employees.DisplayAll();


            Playlist playlist = new Playlist();
            Song song1 = new Song("Shape of You","Ed Sheeran", 4.24);
            Song song2 =new Song("Perfect","Ed Sheeran",4.39 );
            Song song3 =new Song("Believer","Imagine Dragons",3.24);
            Song song4 =new Song("Closer","The Chainsmokers",4.05);
            Song song5 =new Song("Faded","Alan Walker",3.32);
            Console.WriteLine("\n1. ADD SONG AT BEGINNING");
            playlist.AddAtBeginning(song1);
            playlist.DisplayPlaylist();
            Console.WriteLine("\n2. ADD SONG AT END");
            playlist.AddAtEnd(song2);
            playlist.AddAtEnd(song3);
            playlist.DisplayPlaylist();
            Console.WriteLine("\n3. ADD SONG AT POSITION 2");
            playlist.AddAtPosition(song4, 2);
            playlist.DisplayPlaylist();
            Console.WriteLine("\n4. ADD FADED AT END");
            playlist.AddAtEnd(song5);
            playlist.DisplayPlaylist();
            Console.WriteLine("\n5. PLAY NEXT SONG");
            playlist.PlayNextSong();
            playlist.PlayNextSong();
            playlist.PlayNextSong();
            Console.WriteLine("\n6. DELETE SONG: Perfect");
            playlist.DeleteSong("Perfect");
            playlist.DisplayPlaylist();

            //StudentLinkedList students = new StudentLinkedList();
            //Student student1 = new Student(101, "Rahul", 20, 'A');
            //Student student2 = new Student(102, "Priya", 21, 'B');
            //Student student3 = new Student(103, "Aman", 20, 'A');
            //Student student4 = new Student(104, "Neha", 22, 'C');
            //Student student5 = new Student(105, "Riya", 21, 'B');
            //Console.WriteLine("\n1. ADD AT BEGINNING");
            //students.AddAtBeginning(student1);
            //students.DisplayAll();
            //Console.WriteLine("\n2. ADD AT END");
            //students.AddAtEnd(student2);
            //students.AddAtEnd(student3);
            //students.DisplayAll();
            //Console.WriteLine("\n3. ADD AT POSITION");
            //students.AddAtPosition(student4, 2);
            //students.DisplayAll();
            //Console.WriteLine("\n4. SEARCH STUDENT");
            //Student result = students.SearchByRollNumber(103);
            //if (result != null)
            //{
            //    Console.WriteLine("Student found:");
            //    result.Display();
            //}
            //else
            //{
            //    Console.WriteLine("Student not found.");
            //}
            //Console.WriteLine("\n5. UPDATE GRADE");
            //students.UpdateGrade(102, 'A');
            //students.DisplayAll();
            //Console.WriteLine("\n6. DELETE STUDENT");
            //students.DeleteByRollNumber(103);
            //students.DisplayAll();
            //Console.WriteLine("\n7. ADD ANOTHER STUDENT");
            //students.AddAtEnd(student5);
            //students.DisplayAll();



            //MovieLinkedList movies = new MovieLinkedList();
            //Movie movie1 = new Movie("Inception","Christopher Nolan",2010, 8.8);
            //Movie movie2 = new Movie(Interstellar","Christopher Nolan",2014,8.7);
            //Movie movie3 = new Movie("Titanic","James Cameron",1997,7.9);
            //Movie movie4 = new Movie("Avatar","James Cameron",2009,7.8);
            //Movie movie5 = new Movie("The Matrix","Lana Wachowski",1999,8.7);
            //Console.WriteLine("\n1. ADD AT BEGINNING");
            //movies.AddAtBeginning(movie1);
            //movies.DisplayForward();
            //Console.WriteLine("\n2. ADD AT END");
            //movies.AddAtEnd(movie2);
            //movies.AddAtEnd(movie3);
            //movies.DisplayForward();
            //Console.WriteLine("\n3. ADD AT POSITION");
            //movies.AddAtPosition(movie4, 2);
            //movies.DisplayForward();
            //Console.WriteLine("\n4. DISPLAY REVERSE");
            //movies.DisplayReverse();
            //Console.WriteLine("\n5. SEARCH BY DIRECTOR");
            //movies.SearchByDirector("Christopher Nolan");
            //Console.WriteLine("\n6. SEARCH BY RATING");
            //movies.SearchByRating(8.7);
            //Console.WriteLine("\n7. UPDATE RATING");
            //movies.UpdateRating("Titanic", 8.0);
            //movies.DisplayForward();
            //Console.WriteLine("\n8. REMOVE MOVIE");
            //movies.RemoveByTitle("Avatar");
            //movies.DisplayForward();
            //Console.WriteLine("\n9. ADD ANOTHER MOVIE");
            //movies.AddAtEnd(movie5);
            //movies.DisplayForward();
            //Console.WriteLine("\n10. FINAL REVERSE DISPLAY");
            //movies.DisplayReverse();




            //TaskCircularList tasks = new TaskCircularList();
            //TaskItem task1 = new TaskItem(101,"Complete Assignment",1,new DateTime(2026, 8, 15));
            //TaskItem task2 = new TaskItem(102,"Prepare Presentation",2, new DateTime(2026, 8, 17));
            //TaskItem task3 = new TaskItem(103,"Attend Meeting",1,new DateTime(2026, 8, 14));
            //TaskItem task4 = new TaskItem(104, "Submit Report",3,new DateTime(2026, 8, 20));
            //TaskItem task5 = new TaskItem(105,"Review Code",2,new DateTime(2026, 8, 18));
            //Console.WriteLine("\n1. ADD AT BEGINNING");
            //tasks.AddAtBeginning(task1);
            //tasks.DisplayAll();
            //Console.WriteLine("\n2. ADD AT END");
            //tasks.AddAtEnd(task2);
            //tasks.AddAtEnd(task3);
            //tasks.DisplayAll();
            //Console.WriteLine("\n3. ADD AT POSITION");
            //tasks.AddAtPosition(task4, 2);
            //tasks.DisplayAll();
            //Console.WriteLine("\n4. VIEW CURRENT TASK");
            //tasks.ViewCurrentTask();
            //Console.WriteLine("\n5. MOVE TO NEXT TASK");
            //tasks.MoveToNextTask();
            //tasks.MoveToNextTask();
            //Console.WriteLine("\n6. SEARCH BY PRIORITY");
            //tasks.SearchByPriority(1);
            //Console.WriteLine("\n7. REMOVE TASK");
            //tasks.RemoveByTaskId(103);
            //tasks.DisplayAll();
            //Console.WriteLine("\n8. ADD ANOTHER TASK");
            //tasks.AddAtEnd(task5);
            //tasks.DisplayAll();
            //Console.WriteLine("\n9. CIRCULAR TASK MOVEMENT");
            //tasks.ViewCurrentTask();
            //tasks.MoveToNextTask();
            //tasks.MoveToNextTask();
            //tasks.MoveToNextTask();
            //tasks.MoveToNextTask();




            //InventoryLinkedList inventory = new InventoryLinkedList();
            //Item item1 = new Item(101,"Laptop",5,55000);
            //Item item2 = new Item(102,"Mouse",20,800);
            //Item item3 = new Item(103,"Keyboard",15,1500);
            //Item item4 = new Item(104,"Monitor",10,12000);
            //Item item5 = new Item(105,"Headphones",25,2500);
            //Console.WriteLine("\n1. ADD AT BEGINNING");
            //inventory.AddAtBeginning(item1);
            //inventory.DisplayAll();
            //Console.WriteLine("\n2. ADD AT END");
            //inventory.AddAtEnd(item2);
            //inventory.AddAtEnd(item3);
            //inventory.DisplayAll();
            //Console.WriteLine("\n3. ADD AT POSITION");
            //inventory.AddAtPosition(item4, 2);
            //inventory.DisplayAll();
            //Console.WriteLine("\n4. SEARCH BY ITEM ID");
            //Item foundItem = inventory.SearchByItemId(103);
            //if (foundItem != null)
            //{
            //    Console.WriteLine("Item found:");
            //    foundItem.Display();
            //}
            //else
            //{
            //    Console.WriteLine("Item not found.");
            //}
            //Console.WriteLine("\n5. SEARCH BY ITEM NAME");
            //inventory.SearchByItemName("Mouse");
            //Console.WriteLine("\n6. UPDATE QUANTITY");
            //inventory.UpdateQuantity(102, 30);
            //inventory.DisplayAll();
            //Console.WriteLine("\n7. TOTAL INVENTORY VALUE");
            //inventory.DisplayTotalValue();
            //Console.WriteLine("\n8. REMOVE ITEM");
            //inventory.RemoveByItemId(103);
            //inventory.DisplayAll();
            //Console.WriteLine("\n9. ADD ANOTHER ITEM");
            //inventory.AddAtEnd(item5);
            //inventory.DisplayAll();
            //Console.WriteLine("\n10. SORT BY NAME - ASCENDING");
            //inventory.SortByName(true);
            //inventory.DisplayAll();
            //Console.WriteLine("\n11. SORT BY NAME - DESCENDING");
            //inventory.SortByName(false);
            //inventory.DisplayAll();
            //Console.WriteLine("\n12. SORT BY PRICE - ASCENDING");
            //inventory.SortByPrice(true);
            //inventory.DisplayAll();
            //Console.WriteLine("\n13. SORT BY PRICE - DESCENDING");
            //inventory.SortByPrice(false);
            //inventory.DisplayAll();
            //Console.WriteLine("\n14. FINAL INVENTORY VALUE");
            //inventory.DisplayTotalValue();





            //LibraryDoublyLinkedList library =new LibraryDoublyLinkedList();
            //Book book1 = new Book(101,"The Alchemist","Paulo Coelho","Fiction",true);
            //Book book2 = new Book(102,"Harry Potter","J.K. Rowling","Fantasy",true);
            //Book book3 = new Book(103,"The Hobbit","J.R.R. Tolkien","Fantasy",false);
            //Book book4 = new Book(104,"Atomic Habits", "James Clear","Self Help",true);
            //Book book5 = new Book(105,"Ikigai","Hector Garcia","Self Help",true);
            //Console.WriteLine("\n1. ADD AT BEGINNING");
            //library.AddAtBeginning(book1);
            //library.DisplayForward();
            //Console.WriteLine("\n2. ADD AT END");
            //library.AddAtEnd(book2);
            //library.AddAtEnd(book3);
            //library.DisplayForward();
            //Console.WriteLine("\n3. ADD AT POSITION");
            //library.AddAtPosition(book4, 2);
            //library.DisplayForward();
            //Console.WriteLine("\n4. DISPLAY FORWARD");
            //library.DisplayForward();
            //Console.WriteLine("\n5. DISPLAY REVERSE");
            //library.DisplayReverse();
            //Console.WriteLine("\n6. SEARCH BY TITLE");
            //library.SearchByTitle("Harry Potter");
            //Console.WriteLine("\n7. SEARCH BY AUTHOR");
            //library.SearchByAuthor("J.K. Rowling");
            //Console.WriteLine("\n8. UPDATE AVAILABILITY");
            //library.UpdateAvailability(103, true);
            //library.DisplayForward();
            //Console.WriteLine("\n9. REMOVE BOOK");
            //library.RemoveByBookId(104);
            //library.DisplayForward();
            //Console.WriteLine("\n10. ADD ANOTHER BOOK");
            //library.AddAtEnd(book5);
            //library.DisplayForward();
            //Console.WriteLine("\n11. COUNT BOOKS");
            //library.DisplayBookCount();
            //Console.WriteLine("\n12. FINAL REVERSE DISPLAY");
            //library.DisplayReverse();




            //RoundRobinScheduler scheduler = new RoundRobinScheduler();
            //Process process1 =new Process(101, 8, 1);
            //Process process2 =new Process(102, 4, 2);
            //Process process3 =new Process(103, 6, 1);
            //Process process4 =new Process(104, 5, 3);
            //Console.WriteLine("\n1. ADD PROCESSES");
            //scheduler.AddProcess(process1);
            //scheduler.AddProcess(process2);
            //scheduler.AddProcess(process3);
            //scheduler.AddProcess(process4);
            //Console.WriteLine("\n2. INITIAL PROCESS QUEUE");
            //scheduler.DisplayProcesses();
            //Console.WriteLine("\n3. ROUND ROBIN SIMULATION");
            //int timeQuantum = 2;
            //Console.WriteLine($"Time Quantum = {timeQuantum}");
            //scheduler.SimulateRoundRobin(timeQuantum);




            //SocialMediaLinkedList socialMedia =new SocialMediaLinkedList();
            //User user1 = new User(101,"Rahul",21);
            //User user2 = new User(102,"Priya",20);
            //User user3 = new User(103,"Aman",22);
            //User user4 = new User(104,"Neha", 21);
            //User user5 = new User(105,"Riya", 20);
            //Console.WriteLine("\n1. ADD USERS");
            //socialMedia.AddUser(user1);
            //socialMedia.AddUser(user2);
            //socialMedia.AddUser(user3);
            //socialMedia.AddUser(user4);
            //socialMedia.AddUser(user5);
            //Console.WriteLine("\n2. DISPLAY ALL USERS");
            //socialMedia.DisplayAllUsers();
            //Console.WriteLine("\n3. ADD FRIEND CONNECTIONS");
            //socialMedia.AddFriendConnection(101,102);
            //socialMedia.AddFriendConnection(101,103);
            //socialMedia.AddFriendConnection(101,104);
            //socialMedia.AddFriendConnection(102,103);
            //socialMedia.AddFriendConnection(102,105);
            //socialMedia.AddFriendConnection(103, 105);
            //Console.WriteLine("\n4. DISPLAY FRIENDS");
            //socialMedia.DisplayFriends(101);
            //socialMedia.DisplayFriends(102);
            //socialMedia.DisplayFriends(103);
            //Console.WriteLine("\n5. SEARCH BY USER ID");
            //User foundUser =socialMedia.SearchByUserId(103);
            //if (foundUser != null)
            //{
            //    Console.WriteLine("User found:");
            //    foundUser.Display();
            //}
            //else
            //{
            //    Console.WriteLine("User not found.");
            //}
            //Console.WriteLine("\n6. SEARCH BY NAME");
            //User userByName =socialMedia.SearchByName("Neha");
            //if (userByName != null)
            //{
            //    Console.WriteLine("User found:");
            //    userByName.Display();
            //}
            //else
            //{
            //    Console.WriteLine("User not found.");
            //}
            //Console.WriteLine("\n7. FIND MUTUAL FRIENDS");
            //socialMedia.FindMutualFriends(101,102);
            //Console.WriteLine("\n8. COUNT FRIENDS");
            //int count = socialMedia.CountFriends(101);
            //Console.WriteLine($"Rahul has {count} friends.");
            //Console.WriteLine( "\n9. FRIEND COUNT FOR EACH USER");
            //socialMedia.DisplayFriendCounts();
            //Console.WriteLine("\n10. REMOVE FRIEND CONNECTION");
            //socialMedia.RemoveFriendConnection(101,104);
            //Console.WriteLine("\n11. FRIENDS AFTER REMOVAL" );
            //socialMedia.DisplayFriends(101);
            //socialMedia.DisplayFriends(104);
            //Console.WriteLine("\n12. FINAL FRIEND COUNTS");
            //socialMedia.DisplayFriendCounts();



            //TextEditorHistory editor =new TextEditorHistory(10);
            //Console.WriteLine("\n1. ADD INITIAL STATE");
            //editor.AddState("");
            //editor.DisplayCurrentState();
            //Console.WriteLine("\n2. TYPE FIRST WORD");
            //editor.AddState("Hello");
            //editor.DisplayCurrentState();
            //Console.WriteLine( "\n3. TYPE SECOND WORD");
            //editor.AddState("Hello World");
            //editor.DisplayCurrentState();
            //Console.WriteLine("\n4. ADD MORE TEXT");
            //editor.AddState("Hello World! Welcome");
            //editor.DisplayCurrentState();
            //Console.WriteLine("\n5. UNDO");
            //editor.Undo();
            //Console.WriteLine("\n6. UNDO AGAIN");
            //editor.Undo();
            //Console.WriteLine("\n7. REDO");
            //editor.Redo();
            //Console.WriteLine("\n8. CURRENT STATE");
            //editor.DisplayCurrentState();
            //Console.WriteLine("\n9. COMPLETE HISTORY");
            //editor.DisplayHistory();
            //Console.WriteLine("\n10. HISTORY SIZE");
            //editor.DisplayHistorySize();
            //Console.WriteLine("\n11. NEW ACTION AFTER UNDO");
            //editor.Undo();
            //editor.AddState("Hello Everyone");
            //editor.DisplayHistory();
            //Console.WriteLine("\n12. TEST HISTORY LIMIT");
            //editor.AddState("State 1");
            //editor.AddState("State 2");
            //editor.AddState("State 3");
            //editor.AddState("State 4");
            //editor.AddState("State 5");
            //editor.AddState("State 6");
            //editor.AddState("State 7");
            //editor.AddState("State 8");
            //editor.AddState("State 9");
            //editor.AddState("State 10");
            //editor.AddState("State 11");
            //editor.DisplayHistory();
            //editor.DisplayHistorySize();
            //Console.WriteLine( "\n13. FINAL UNDO");
            //editor.Undo();
            //editor.DisplayCurrentState();
            //Console.WriteLine("\n14. FINAL REDO");
            //editor.Redo();
            //editor.DisplayCurrentState();


            //TicketCircularLinkedList bookingSystem = new TicketCircularLinkedList();
            //Ticket ticket1 = new Ticket(101,"Rahul","Avengers","A10",DateTime.Now);
            //Ticket ticket2 = new Ticket(102,"Priya","Avengers","A11",DateTime.Now);
            //Ticket ticket3 = new Ticket(103,"Aman","Batman","B05",DateTime.Now);
            //Ticket ticket4 = new Ticket(104,"Neha","Avengers","A12",DateTime.Now);
            //Ticket ticket5 = new Ticket(105,"Riya","Batman","B06",DateTime.Now);
            //Console.WriteLine("\n1. ADD TICKETS");
            //bookingSystem.AddTicket(ticket1);
            //bookingSystem.AddTicket(ticket2);
            //bookingSystem.AddTicket(ticket3);
            //bookingSystem.AddTicket(ticket4);
            //bookingSystem.AddTicket(ticket5);
            //Console.WriteLine("\n2. DISPLAY CURRENT TICKETS");
            //bookingSystem.DisplayTickets();
            //Console.WriteLine("\n3. SEARCH BY CUSTOMER NAME");
            //bookingSystem.SearchByCustomerName("Priya");
            //Console.WriteLine("\n4. SEARCH BY MOVIE NAME");
            //bookingSystem.SearchByMovieName("Avengers");
            //Console.WriteLine("\n5. TOTAL BOOKED TICKETS");
            //bookingSystem.DisplayTicketCount();
            //Console.WriteLine("\n6. REMOVE TICKET");
            //bookingSystem.RemoveTicket(103);
            //Console.WriteLine("\n7. TICKETS AFTER REMOVAL");
            //bookingSystem.DisplayTickets();
            //Console.WriteLine("\n8. UPDATED TICKET COUNT");
            //bookingSystem.DisplayTicketCount();
            //Console.WriteLine("\n9. REMOVE FIRST TICKET");
            //bookingSystem.RemoveTicket(101);
            //bookingSystem.DisplayTickets();
            //Console.WriteLine("\n10. FINAL TICKET COUNT");
            //bookingSystem.DisplayTicketCount();


            Console.ReadLine();
        }
    }
}