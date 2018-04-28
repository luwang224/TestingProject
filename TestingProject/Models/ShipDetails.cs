using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestingProject.Models
{
    public class ShipDetails
    {
        public int ShipID { get; set; }
        public string Product { get; set; }
        public double UnitPrice { get; set; }
        public int Quantity { get; set; }
    }
}