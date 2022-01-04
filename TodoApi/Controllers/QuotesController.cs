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
    public class QuotesController : Controller
    {
        private readonly jacobgomezContext _context;
        public QuotesController(jacobgomezContext context)
        {
            _context = context;
        }

        [Produces("application/json")]
        [HttpGet]
        public async Task<IActionResult> FindAll()
        {
            try
            {
                var quotes = _context.Quotes.ToList();
                return Ok(quotes);
            }
            catch
            {
                return BadRequest();
            }
        }

        [Produces("application/json")]
        [HttpGet("recent")]
        public async Task<IActionResult> GetList()
        {

            var quotes = _context.Quotes.ToList();
            var customers = _context.Customers.ToList();
            List<Quote> recent_quotes = new List<Quote>();

            DateTime currentDate = DateTime.Now.AddDays(-30);
            Boolean found;
            foreach (var q in quotes)
            {
                found = false;
                foreach (var custy in customers)
                {
                    if (q.Email != custy.ContactEmail)
                    {

                    }
                    else
                    {
                        found = true;
                        break;
                    }
                }
                if (found == false)
                {
                    if (q.CreatedAt >= currentDate)
                    {
                        recent_quotes.Add(q);
                    }
                }
            }

            return Ok(recent_quotes);
        }
    }
}