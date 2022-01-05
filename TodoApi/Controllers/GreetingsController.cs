using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TodoApi.Models;
namespace TodoApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GreetingsController : Controller
    {
        // GET: /<controller>/
        private readonly jacobgomezContext _context;

        public GreetingsController(jacobgomezContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]

        public string Greeting()
        {
            int totalElevators = _context.Elevators.Count();
            int totalCities = _context.Addresses.Count();
            int totalBuildings = _context.Buildings.Count();
            int totalBatteries = _context.Batteries.Count();
            int totalCustomers = _context.Customers.Count();
            int totalQuotes = _context.Quotes.Count();
            int totalLeads = _context.Leads.Count();
            int inactiveElevators = _context.Elevators.Where(elevator => elevator.Status != "Active").Count();

            string greeting = "Greetings. There are currently " + totalElevators + " elevators deployed in the " + totalBuildings + " buildings of your " + totalCustomers + " customers." +
                " Currently, " + totalElevators + " elevators are not in Running Status and are being serviced. " +
                totalBatteries + " batteries are deployed across " + totalCities + " cities. " +
                " On another note, you currently have " + totalQuotes + " quotes awaiting processing. " +
                " You also have " + totalLeads + " leads in your contact requests. ";

                return greeting;
        }



    }
}
