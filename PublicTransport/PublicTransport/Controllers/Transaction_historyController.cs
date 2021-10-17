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
    [Authorize(Roles = "Admin")]
    public class Transaction_historyController : Controller
    {
        private readonly TransactionService _transactionService;

        public Transaction_historyController(TransactionService transactionServices)
        {
            _transactionService = transactionServices;
        }

        // GET: Transaction_history
        public IActionResult Index()
        {
            var transactions = _transactionService.GetTransactions();
            return View(transactions);
        }

        // GET: Transaction_history/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transactions = _transactionService.GetTransactions().FirstOrDefault(m => m.Transid == id);
            if (transactions == null)
            {
                return NotFound();
            }

            return View(transactions);
        }

        // GET: Transaction_history/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Transaction_history/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Transid,data")] Transaction_history transaction_history)
        {
            if (ModelState.IsValid)
            {
                _transactionService.AddTransaction(transaction_history);
                _transactionService.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(transaction_history);
        }

        // GET: Transaction_history/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transaction = _transactionService.GetTransactions().FirstOrDefault(m => m.Transid == id);
            if (transaction == null)
            {
                return NotFound();
            }
            return View(transaction);
        }

        // POST: Transaction_history/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Transid,data")] Transaction_history transaction_history)
        {
            if (id != transaction_history.Transid)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _transactionService.UpdateTransaction(transaction_history);
                    _transactionService.Save();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TransactionExists(transaction_history.Transid))
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
            return View(transaction_history);
        }

        // GET: Transaction_history/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transaction = _transactionService.GetTransactions().FirstOrDefault(m => m.Transid == id);
            if (transaction == null)
            {
                return NotFound();
            }

            return View(transaction);
        }

        // POST: Transaction_history/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var transaction = _transactionService.GetTransactionsByCondition(b => b.Transid == id).FirstOrDefault();
            _transactionService.DeleteTransaction(transaction);
            _transactionService.Save();
            return RedirectToAction(nameof(Index));
        }

        private bool TransactionExists(int id)
        {
            return _transactionService.GetTransactions().Any(e => e.Transid == id);
        }
    }
}
