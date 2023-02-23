using AM.Core.Domain;

namespace AM.core.Services
{
    public class FlightService : IFlightService //Question4 TP2
    {
        public IList<Flight> Flights { get; set; }

        public IList<DateTime> GetFlightDates(string destination)
        {
            //          List<DateTime> dates = new List<DateTime>();    
            //          foreach (var flight in Flights) 
            //          {
            //              if(flight.Destination == destination) 
            //              {
            //                  dates.Add(flight.FlightDate);
            //              }
            //          }
            //          return dates;

            //LINQ integré  (TP2 Quest 6)
            //           return (from flight in  Flights
            //                  where flight.Destination == destination
            //                  select flight.FlightDate).ToList(); //.toList aamalna cast khater flightdate trajja3 IEnnumerable<DateTime>

            return Flights.Where(f => f.Destination == destination).Select(f => f.FlightDate).ToList();    //2eme methode Methode d'extension de LINQ
        }


        public void GetFlights(string filterType, string filterValue) //Question5 Tp2
        {
            switch (filterType)
            {
                case "Destination":

                    foreach (var flight in Flights)
                    {
                        if (flight.Destination == filterValue)
                        {
                            Console.WriteLine(flight);
                        }
                    }
                    break;

                case "FlightDate":

                    foreach (var flight in Flights)
                    {
                        if (flight.FlightDate.ToString() == filterValue)
                        {
                            Console.WriteLine(flight);
                        }
                    }
                    break;
                case "FlightId":

                    foreach (var flight in Flights)
                    {
                        if (flight.FlightId.ToString() == filterValue)
                        {
                            Console.WriteLine(flight);
                        }
                    }
                    break;
                case "EstimatedDuration":

                    foreach (var flight in Flights)
                    {
                        if (flight.EstimatedDuration.ToString() == filterValue)
                        {
                            Console.WriteLine(flight);
                        }
                    }
                    break;
                case "EffectiveArrival":

                    foreach (var flight in Flights)
                    {
                        if (flight.EffectiveArrival.ToString() == filterValue)
                        {
                            Console.WriteLine(flight);
                        }
                    }
                    break;
                default:
                    Console.WriteLine("ERROR");
                    break;
            }

        }
        //quest 7 tp2
        public void ShowFlightDetails(int planeNumber)
        {
            var flights = Flights.Where(flight => flight.MyPlane.PlaneId == planeNumber);

            foreach (var flight in flights)
            {
                Console.WriteLine($"Flight Number: {flight.FlightId}, Date: {flight.FlightDate}, Destination: {flight.Destination}");
            }
        }
        //Question 8 tp 2
        public int GetWeeklyFlightNumber(DateTime startDate)
        {
            var endDate = startDate.AddDays(7);
            var flights = Flights.Where(flight => flight.FlightDate >= startDate && flight.FlightDate < endDate);

            return flights.Count();
        }
        //Question 9 tp2
        public double GetDurationAverage(string destination)
        {
            var flights = Flights.Where(flight => flight.Destination == destination);

            if (flights.Any())
            {
                return flights.Average(flight => flight.EstimatedDuration);
            }
            else
            {
                return 0;
            }
        }
        //quest 10 tp2
        public IList<Flight> SortFlights()
        {
            return Flights.OrderByDescending(flight => flight.EstimatedDuration).ToList();
        }
        // Quest 11 tp2
        public IList<Passenger> GetThreeOlderTravellers(Flight flight)
        {
            return Flights.SelectMany(f => f.Passengers).OrderByDescending(p => p.Age).Take(3).ToList(); 
        }
        //Quest 12 tp2
        public void ShowGroupedFlights()
        {
            var flights = Flights.GroupBy(f => f.Destination);
            foreach ( var flight in flights)
            {
                Console.WriteLine(flight);
            }
        }





    }
}