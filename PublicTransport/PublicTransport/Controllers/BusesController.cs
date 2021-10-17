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
    public class BusesController : Controller
    {
        private readonly BusService _busService;

        public BusesController(BusService busService)
        {
            _busService = busService;
        }

        // GET: Buses
        public IActionResult Index()
        {
            var buses = _busService.GetBuses();
            return View(buses);
        }

        // GET: Buses/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bus =  _busService.GetBuses()
                .FirstOrDefault(m => m.BusID == id);
            if (bus == null)
            {
                return NotFound();
            }

            return View(bus);
        }
         [Authorize (Roles ="Admin")]
        // GET: Buses/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Buses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("BusID,Name")] Bus bus)
        {
            if (ModelState.IsValid)
            {
                _busService.AddBus(bus);
                 _busService.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(bus);
        }
        [Authorize(Roles = "Admin")]
        // GET: Buses/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bus =  _busService.GetBuses().FirstOrDefault(m => m.BusID == id);
            if (bus == null)
            {
                return NotFound();
            }
            return View(bus);
        }

        // POST: Buses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("BusID,Name")] Bus bus)
        {
            if (id != bus.BusID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _busService.UpdateBus(bus);
                     _busService.Save();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BusExists(bus.BusID))
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
            return View(bus);
        }
        [Authorize(Roles = "Admin")]
        // GET: Buses/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bus =  _busService.GetBuses()
                .FirstOrDefault(m => m.BusID == id);
            if (bus == null)
            {
                return NotFound();
            }

            return View(bus);
        }

        // POST: Buses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var bus =  _busService.GetBusesByCondition(b => b.BusID == id).FirstOrDefault();
            _busService.DeleteBus(bus);
             _busService.Save();
            return RedirectToAction(nameof(Index));
        }

        private bool BusExists(int id)
        {
            return _busService.GetBuses().Any(e => e.BusID == id);
        }
    }
}
