using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.core.Services
{
    public interface IFlightService
    {
        IList<DateTime> GetFlightDates(string destination); //signature méthode (Quest 4)
        void GetFlights(string filterType, string filterValue);
        void ShowFlightDetails(int flightNumber);


    }
}
