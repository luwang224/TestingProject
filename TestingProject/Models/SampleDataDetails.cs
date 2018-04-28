using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestingProject.Models
{
    static class SampleDataDetails
    {
        public static List<ShipDetails> ShipDetailsList = new List<ShipDetails>()
        {
            new ShipDetails {
                ShipID =10248,
                Product="off road oil",
                Quantity=800,
                UnitPrice=3.20
            },
            new ShipDetails {
                ShipID=10248,
                Product="93 unleaded gas",
                Quantity=900,
                UnitPrice=3.50
            },
            new ShipDetails {
                ShipID=10248,
                Product="97 unleaded gas",
                Quantity=400,
                UnitPrice=3.20
            },new ShipDetails {
                ShipID =10249,
                Product="off road oil",
                Quantity=300,
                UnitPrice=3.10
            },
            new ShipDetails {
                ShipID=10249,
                Product="93 unleaded gas",
                Quantity=900,
                UnitPrice=3.50
            },
            new ShipDetails {
                ShipID=10249,
                Product="97 unleaded gas",
                Quantity=400,
                UnitPrice=2.20
            }
        };
    }
}