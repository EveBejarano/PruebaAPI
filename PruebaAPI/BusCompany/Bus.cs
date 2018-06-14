using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FunTourDataLayer.Models
{
    public class Bus 
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bus()
        {
        }

        [Key]
        public int IdAPI_Bus { get; set; }

        public string Origin { get; set; }
        public string Destination { get; set; }
        public DateTime DateTimeDeparture { get; set; }
        public DateTime DateTimeArrival { get; set; }
        public string Company { get; set; }
        public string Class { get; set; }
        public int Capacity { get; set; }
        public double Price { get; set; }
        public int NotReservedSeats { get; set; }


        public virtual BusCompany BusCompany { get; set; }

    }
}