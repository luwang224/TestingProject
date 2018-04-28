using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;
using TestingProject.Models;
using System.Text;


namespace TestingProject.Controllers
{
    [Route("api/ShipDataGridWebApi/{action}", Name = "ShipDataGridWebApi")]
    public class DataGridWebApiController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage Ships(DataSourceLoadOptions loadOptions)
        {
            return Request.CreateResponse(DataSourceLoader.Load(SampleData.Ships, loadOptions));
        }

        [HttpPost]
        public HttpResponseMessage InsertShip(FormDataCollection form)
        {
            var values = form.Get("values");

            var newShip = new Ship();
            JsonConvert.PopulateObject(values, newShip);
            SampleData.Ships.Add(newShip);

            return Request.CreateResponse(HttpStatusCode.Created);
        }

        [HttpPut]
        public HttpResponseMessage UpdateShip(FormDataCollection form)
        {
            var key = Convert.ToInt32(form.Get("key"));
            var values = form.Get("values");
            var ship = SampleData.Ships.First(s => s.ShipID == key);

            JsonConvert.PopulateObject(values, ship);
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [HttpDelete]
        public void DeleteShip(FormDataCollection form)
        {
            var key = Convert.ToInt32(form.Get("key"));
            var ship = SampleData.Ships.First(s => s.ShipID == key);

            SampleData.Ships.Remove(ship);
        }


        [HttpGet]
        public HttpResponseMessage ShipDetails(int ShipID, DataSourceLoadOptions loadOptions)
        {
            return Request.CreateResponse(DataSourceLoader.Load(
                from i in SampleDataDetails.ShipDetailsList
                where i.ShipID == ShipID
                select new
                {
                    Product = i.Product,
                    Price = i.UnitPrice,
                    Quantity = i.Quantity,
                    Sum = Math.Round(i.UnitPrice * i.Quantity, 2)
                },
                loadOptions
            ));
        }

        [HttpPost]
        public HttpResponseMessage ShipNotes([FromBody] Ship value)
        {
            var json =  JsonConvert.SerializeObject(new ShipDetails { ShipID = value.ShipID, Product = "Gas", Quantity = 93, UnitPrice = 3.21 });
            var response = Request.CreateResponse(HttpStatusCode.OK, json);
            return response;

        }
    }
  
}