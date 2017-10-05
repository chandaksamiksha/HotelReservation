using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.IO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HotelReservationEngine.Controllers
{
    [Route("/")]
    public class SearchController : Controller
    {
        [HttpGet("/api/values")]
        [HttpGet("home")]
        public IActionResult GetHomePage()
        {
            return File(new FileStream("wwwroot/HtmlPages/index.html",FileMode.Open),"text/html");
        }

        [HttpGet("/guestDetails")]
        [HttpGet("home")]
        public IActionResult GetGuestDetailsPage()
        {
            return File(new FileStream("wwwroot/HtmlPages/guestDetailsPage.html", FileMode.Open), "text/html");
        }
    }
}
