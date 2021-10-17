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
    public class RoutesController : Controller
    {
        private readonly RouteService _routeService;

        public RoutesController(RouteService routeService)
        {
            _routeService = routeService;
        }

        // GET: Routes
        public IActionResult Index()
        {
            var routes = _routeService.GetRoutes();
            return View(routes);
        }

        // GET: Routes/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var route = _routeService.GetRoutes().FirstOrDefault(m => m.RouteId == id);
            if (route == null)
            {
                return NotFound();
            }

            return View(route);
        }
        [Authorize(Roles = "Admin")]
        // GET: Routes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Routes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("RouteId,Name,Station")] Route route)
        {
            if (ModelState.IsValid)
            {
                _routeService.AddRoute(route);
                _routeService.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(route);
        }
        [Authorize(Roles = "Admin")]
        // GET: Routes/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var route = _routeService.GetRoutes().FirstOrDefault(m => m.RouteId == id);
            if (route == null)
            {
                return NotFound();
            }
            return View(route);
        }

        // POST: Routes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("RouteId,Name,Station")] Route route)
        {
            if (id != route.RouteId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _routeService.UpdateRoute(route);
                    _routeService.Save();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RouteExists(route.RouteId))
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
            return View(route);
        }

        // GET: Routes/Delete/5
        [Authorize(Roles = "Admin")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var route = _routeService.GetRoutes().FirstOrDefault(m => m.RouteId == id);
            if (route == null)
            {
                return NotFound();
            }

            return View(route);
        }

        // POST: Routes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var route = _routeService.GetRoutesByCondition(b => b.RouteId == id).FirstOrDefault();
            _routeService.DeleteRoute(route);
            _routeService.Save();
            return RedirectToAction(nameof(Index));
        }

        private bool RouteExists(int id)
        {
            return _routeService.GetRoutes().Any(e => e.RouteId == id);
        }
    }
}
