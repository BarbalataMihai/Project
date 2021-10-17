using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PublicTransport.Models;
using PublicTransport.Services;

namespace PublicTransport.Controllers
{
    [Authorize]
    public class TicketsController : Controller
    {
        private readonly TicketService _ticketService;

        public TicketsController(TicketService ticketService)
        {
            _ticketService = ticketService;
        }

        // GET: Tickets
        public IActionResult Index()
        {
            var tickets = _ticketService.GetTickets();
            return View(tickets);
        }

        // GET: Tickets/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ticket = _ticketService.GetTickets().FirstOrDefault(m => m.Ticid == id);
            if (ticket == null)
            {
                return NotFound();
            }

            return View(ticket);
        }
  
        // GET: Tickets/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tickets/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Ticid,Tic_name,Travels,Price")] Ticket ticket)
        {
            if (ModelState.IsValid)
            {
                _ticketService.AddTicket(ticket);
                _ticketService.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(ticket);
        }
        [Authorize]
        // GET: Tickets/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ticket =  _ticketService.GetTickets().FirstOrDefault(m => m.Ticid == id);
            if (ticket == null)
            {
                return NotFound();
            }
            return View(ticket);
        }

        // POST: Tickets/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Ticid,Tic_name,Travels,Price")] Ticket ticket)
        {
            if (id != ticket.Ticid)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _ticketService.UpdateTicket(ticket);
                     _ticketService.Save();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TicketExists(ticket.Ticid))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(ticket);
        }
        [Authorize]
        // GET: Tickets/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ticket =  _ticketService.GetTickets()
                .FirstOrDefault(m => m.Ticid == id);
            if (ticket == null)
            {
                return NotFound();
            }

            return View(ticket);
        }

        // POST: Tickets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var ticket =  _ticketService.GetTicketsByCondition(b => b.Ticid == id).FirstOrDefault();
            _ticketService.DeleteTicket(ticket);
             _ticketService.Save();
            return RedirectToAction(nameof(Index));
        }

        private bool TicketExists(int id)
        {
            return _ticketService.GetTickets().Any(e => e.Ticid == id);
        }
    }
}
