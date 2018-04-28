using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestingProject.Models
{
    public class Ship
    {
        public int ShipID { get; set; }
        public DateTime ShipDate { get; set; }
        public string ShipName { get; set; }
        public string ShipCountry { get; set; }
        public string ShipCity { get; set; }
    }
}