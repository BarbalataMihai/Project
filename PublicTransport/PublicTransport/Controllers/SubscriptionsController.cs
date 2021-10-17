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
{[Authorize]
    public class SubscriptionsController : Controller
    {
        private readonly SubscriptionService _subscriptionService;

        public SubscriptionsController(SubscriptionService subscriptionService)
        {
            _subscriptionService = subscriptionService;
        }

        // GET: Subscriptions
        public IActionResult Index()
        {
            var subscriptions = _subscriptionService.GetSubscriptions();
            return View(subscriptions);
        }

        // GET: Subscriptions/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var subscription = _subscriptionService.GetSubscriptions()
                            .FirstOrDefault(m => m.Subid == id);
            if (subscription == null)
            {
                return NotFound();
            }

            return View(subscription);
        }

        // GET: Subscriptions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Subscriptions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Subid,Sub_name,Duration,Price")] Subscription subscription)
        {
            if (ModelState.IsValid)
            {
                _subscriptionService.AddSubscription(subscription);
                _subscriptionService.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(subscription);
        }

        // GET: Subscriptions/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subscription = _subscriptionService.GetSubscriptions().FirstOrDefault(m => m.Subid == id);
            if (subscription == null)
            {
                return NotFound();
            }
            return View(subscription);
        }

        // POST: Subscriptions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Subid,Sub_name,Duration,Price")] Subscription subscription)
        {
            if (id != subscription.Subid)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _subscriptionService.UpdateSubscription(subscription);
                    _subscriptionService.Save();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SubscriptionExists(subscription.Subid))
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
            return View(subscription);
        }

        // GET: Subscriptions/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subscription = _subscriptionService.GetSubscriptions()
             .FirstOrDefault(m => m.Subid == id);
            if (subscription == null)
            {
                return NotFound();
            }

            return View(subscription);
        }

        // POST: Subscriptions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var subscription = _subscriptionService.GetSubscriptionsByCondition(b => b.Subid == id).FirstOrDefault();
            _subscriptionService.DeleteSubscription(subscription);
            _subscriptionService.Save();
            return RedirectToAction(nameof(Index));
        }

        private bool SubscriptionExists(int id)
        {
            return _subscriptionService.GetSubscriptions().Any(e => e.Subid == id);
        }
    }
}
