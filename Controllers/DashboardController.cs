using Microsoft.AspNetCore.Mvc;
using Liberty.Core.Model;
using System.Collections.Generic;

namespace Liberty.Core.Controllers
{
    public class DashboardController : ControllerBase
    {
        [HttpGet("CADDashboard")]
        public Dashboard CadDashboard()
        {
            return GetProductDashboard("Cad");
        }
        [HttpGet("SimulationDashboard")]
        public Dashboard SimulationDashboard()
        {
            return GetProductDashboard("Simulation");
        }
        [HttpGet("TestingDashboard")]
        public Dashboard TestingDashboard()
        {
            return GetProductDashboard("Testing");
        }

        [HttpGet("ManufacturingStatusDashboard")]
        public Dashboard ManufacturingStatusDashboard()
        {
            return GetProductDashboard("Manufacturing");
        }

        private Dashboard GetProductDashboard(string type)
        {
            List<Product> products = new List<Product>()
        {
            new Product()
            {
                Id = 1,
                Name= "Bike 1",
                Model = "Storts",
                Status = "New Created",
                Color = new Color(){ },
                Engine = new Engine(){ },
                Lighting = new Lighting(){ },
                Seat = new Seat(){},
                Wheels = new Wheels(){ },
            },
            new Product()
            {
                 Id = 2,
                Name= "Bike 2",
                Model = "Storts",
                Status = "In Process",
                Color = new Color(){ },
                Engine = new Engine(){ },
                Lighting = new Lighting(){ },
                Seat = new Seat(){},
                Wheels = new Wheels(){ },
            },
            new Product()
            {
                 Id = 3,
                Name= "Bike 3",
                Model = "Storts",
                Status = "In Process",
                Color = new Color(){ },
                Engine = new Engine(){ },
                Lighting = new Lighting(){ },
                Seat = new Seat(){},
                Wheels = new Wheels(){ },
            }
        };
            Dashboard dashboard = new Dashboard();
            dashboard.Name = type;
            dashboard.DashboardData = products;

            return dashboard;
        }
    }
}
