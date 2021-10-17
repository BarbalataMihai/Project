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
{ [Authorize]
    public class CardsController : Controller
    {
        private readonly CardService _cardService;

        public CardsController(CardService cardService)
        {
            _cardService = cardService;
        }

        // GET: Cards
        public IActionResult Index()
        {
            var cards = _cardService.GetCards();
            return View(cards);
        }

        // GET: Cards/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var card = _cardService.GetCards()
                  .FirstOrDefault(m => m.CardId == id);
            if (card == null)
            {
                return NotFound();
            }

            return View(card);
        }

        // GET: Cards/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cards/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("CardId,Expiration,Name,CVC,Number")] Card card)
        {
            if (ModelState.IsValid)
            {
                _cardService.AddCard(card);
                _cardService.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(card);
        }

        // GET: Cards/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var card = _cardService.GetCards().FirstOrDefault(m => m.CardId == id);
            if (card == null)
            {
                return NotFound();
            }
            return View(card);
        }

        // POST: Cards/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("CardId,Expiration,Name,CVC,Number")] Card card)
        {
            if (id != card.CardId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _cardService.UpdateCard(card);
                    _cardService.Save();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CardExists(card.CardId))
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
            return View(card);
        }

        // GET: Cards/Delete/5
        public IActionResult Delete(int? id)    
        {
            if (id == null)
            {
                return NotFound();
            }

            var card = _cardService.GetCards()
                .FirstOrDefault(m => m.CardId == id);
            if (card == null)
            {
                return NotFound();
            }

            return View(card);
        }

        // POST: Cards/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var card = _cardService.GetCardsByCondition(b => b.CardId == id).FirstOrDefault();
            _cardService.DeleteCard(card);
            _cardService.Save();
            return RedirectToAction(nameof(Index));
        }

        private bool CardExists(int id)
        {
            return _cardService.GetCards().Any(e => e.CardId == id);
        }
    }
}
