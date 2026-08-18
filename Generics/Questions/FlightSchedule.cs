using System;
using System.Collections.Generic;
using System.Linq;

namespace Questions
{
    public class Flight
    {
        public string FlightId;
        public string Airline;
        public string Source;
        public string Destination;
        public DateTime DepartmentTime;
        public DateTime ArrivalTime;

        public Flight(string flightId, string airline,string source,string destination, DateTime departmentTime, DateTime arrivalTime)
        {
            FlightId = flightId;
            Airline = airline;
            Source = source;
            Destination = destination;
            DepartmentTime = departmentTime;
            ArrivalTime = arrivalTime;
        }

        public override string ToString()
        {
            return $"{FlightId} | {Airline} | {Source} -> {Destination} | " + $"Departure: {DepartmentTime} | Arrival: {ArrivalTime}";
        }
    }

    public class FlightSchedule<T>
    {
        private List<T> flights;
        public FlightSchedule()
        {
            flights = new List<T>();
        }

        public void AddFlight(T flight)
        {
            flights.Add(flight);
        }

        public void DisplayFlights()
        {
            if (flights.Count == 0)
            {
                Console.WriteLine("No flights available.");
                return;
            }
            foreach(T flight in flights)
            {
                Console.WriteLine(flight);
            }
        }

        public T SearchFlight(string flightId)
        {
            foreach(T flight in flights)
            {
                Flight currentFlight = flight as Flight;
                if(currentFlight!=null && currentFlight.FlightId.Equals(flightId, StringComparison.OrdinalIgnoreCase))
                {
                    return flight;
                }
            }
            return default(T);
        }

        public bool RemoveFlight(string flightId)
        {
            T flight = SearchFlight(flightId);

            if (!EqualityComparer<T>.Default.Equals(flight, default(T)))
            {
                flights.Remove(flight);
                return true;
            }
            return false;
        }

        public List<T> FindByDestination(string destination)
        {
            List<T> result = new List<T>();

            foreach (T flight in flights)
            {
                Flight currentFlight = flight as Flight;

                if (currentFlight != null &&
                    currentFlight.Destination.Equals(
                   destination,
                   StringComparison.OrdinalIgnoreCase))
                {
                    result.Add(flight);
                }
            }
            return result;
        }
    }
}
        