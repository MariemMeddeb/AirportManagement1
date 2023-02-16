using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Domain
{
    public enum PlaneType
    {
        Boeing=1,
        Airbus=2
    }
    public class Plane
    {
        public int Capacity { get; set; }
        public DateTime ManufactureDate { get; set; }
        public int PlaneId { get; set; }
        public PlaneType MyPlaneType { get; set; }
        public IList<Flight> Flights { get; set;}

        /// <summary>
        /// Constructeur paramétré
        /// </summary>
        /// <param name="planeType"></param>
        /// <param name="capacity"></param>
        /// <param name="date"></param>
        public Plane(PlaneType planeType, int capacity, DateTime date)
        {
            MyPlaneType = planeType;
            Capacity = capacity;
            ManufactureDate = date;
        }
        public Plane()
        {

        }
        public override string ToString()
        {
            return "Capacity: " + Capacity + " ;ManufactureDate:" + ManufactureDate + ";PlaneId:" + MyPlaneType;        
        }
    }
}
