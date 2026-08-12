using System;

namespace LinkedListQues
{
    public class Ticket
    {
        public int TicketId;
        public string CustomerName;
        public string MovieName;
        public string SeatNumber;
        public DateTime BookingTime;

        public Ticket(
            int ticketId,
            string customerName,
            string movieName,
            string seatNumber,
            DateTime bookingTime)
        {
            TicketId = ticketId;
            CustomerName = customerName;
            MovieName = movieName;
            SeatNumber = seatNumber;
            BookingTime = bookingTime;
        }

        public void Display()
        {
            Console.WriteLine($"Ticket ID: {TicketId}, " +$"Customer: {CustomerName}, " +$"Movie: {MovieName}, " + $"Seat: {SeatNumber}, " + $"Booking Time: {BookingTime}");
        }
    }


    public class TicketNode
    {
        public Ticket Data;
        public TicketNode Next;

        public TicketNode(Ticket data)
        {
            Data = data;
            Next = null;
        }
    }


    public class TicketCircularLinkedList
    {
        private TicketNode head;
        private TicketNode tail;


        public void AddTicket(Ticket ticket)
        {
            TicketNode newNode = new TicketNode(ticket);
            if (head == null)
            {
                head = newNode;
                tail = newNode;
                tail.Next = head;
                Console.WriteLine($"Ticket {ticket.TicketId} added successfully.");
                return;
            }
            tail.Next = newNode;
            tail = newNode;
            tail.Next = head;
            Console.WriteLine($"Ticket {ticket.TicketId} added successfully.");
        }


        public void RemoveTicket(int ticketId)
        {
            if (head == null)
            {
                Console.WriteLine("No tickets booked.");
                return;
            }
            TicketNode current = head;
            TicketNode previous = tail;

            do
            {
                if (current.Data.TicketId == ticketId)
                {
                    if (head == tail)
                    {
                        head = null;
                        tail = null;
                        Console.WriteLine("Ticket removed successfully.");
                        return;
                    }

                    if (current == head)
                    {
                        head = head.Next;
                        tail.Next = head;
                        Console.WriteLine("Ticket removed successfully.");
                        return;
                    }

                    previous.Next = current.Next;

                    if (current == tail)
                    {
                        tail = previous;
                        tail.Next = head;
                    }
                    Console.WriteLine("Ticket removed successfully.");
                    return;
                }

                previous = current;
                current = current.Next;

            } while (current != head);

            Console.WriteLine("Ticket not found.");
        }

        public void DisplayTickets()
        {
            if (head == null)
            {
                Console.WriteLine("No tickets booked.");
                return;
            }
            Console.WriteLine("\n----- Current Tickets -----");
            TicketNode current = head;
            do
            {
                current.Data.Display();
                current = current.Next;
            } while (current != head);
        }

        public void SearchByCustomerName(
            string customerName)
        {
            if (head == null)
            {
                Console.WriteLine("No tickets booked.");
                return;
            }

            TicketNode current = head;
            bool found = false;

            do
            {
                if (current.Data.CustomerName.Equals(
                    customerName,
                    StringComparison.OrdinalIgnoreCase))
                {
                    current.Data.Display();
                    found = true;
                }
                current = current.Next;
            } while (current != head);

            if (!found)
            {
                Console.WriteLine("No ticket found for this customer.");
            }
        }

        public void SearchByMovieName(string movieName)
        {
            if (head == null)
            {
                Console.WriteLine("No tickets booked.");
                return;
            }

            TicketNode current = head;
            bool found = false;
            do
            {
                if (current.Data.MovieName.Equals(movieName,StringComparison.OrdinalIgnoreCase))
                {
                    current.Data.Display();
                    found = true;
                }
                current = current.Next;
            } while (current != head);
            if (!found)
            {
                Console.WriteLine("No ticket found for this movie.");
            }
        }

        public int CountTickets()
        {
            if (head == null)
            {
                return 0;
            }
            int count = 0;
            TicketNode current = head;

            do
            {
                count++;

                current = current.Next;

            } while (current != head);

            return count;
        }

        public void DisplayTicketCount()
        {
            Console.WriteLine($"Total booked tickets: {CountTickets()}");
        }
    }
}