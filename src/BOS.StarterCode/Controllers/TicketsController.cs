using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BOS.StarterCode.Models.BOSModels;
using Microsoft.AspNetCore.Mvc;

namespace BOS.StarterCode.Controllers
{
    public class TicketsController : Controller
    {
        public IActionResult Index()
        {
            List<Ticket> tickets = new List<Ticket>();
            for (int i = 0; i < 2; i++)
            {
                Ticket ticket = new Ticket();
                ticket.Id = Guid.NewGuid();
                ticket.Number = i;
                ticket.Title = "Ticket " + i;

                tickets.Add(ticket);
            }
            return View(tickets);
        }
    }
}
