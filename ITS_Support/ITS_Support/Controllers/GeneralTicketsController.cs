using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ITS_Support.Data;
using ITS_Support.Models;

namespace ITS_Support.Views.GeneralTickets
{
    public class GeneralTicketsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GeneralTicketsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: GeneralTickets
        public async Task<IActionResult> Index()
        {
            return View(await _context.GeneralTickets.ToListAsync());
        }

        // GET: GeneralTickets/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var generalTicketModel = await _context.GeneralTickets
                .FirstOrDefaultAsync(m => m.Id == id);
            if (generalTicketModel == null)
            {
                return NotFound();
            }

            return View(generalTicketModel);
        }

        // GET: GeneralTickets/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: GeneralTickets/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Issue,ExtraDetails,CreatedBy,CreatedAt")] GeneralTicketModel generalTicketModel)
        {
            if (ModelState.IsValid)
            {
                generalTicketModel.CreatedAt = DateTime.Now;
                _context.Add(generalTicketModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(generalTicketModel);
        }

        // GET: GeneralTickets/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var generalTicketModel = await _context.GeneralTickets.FindAsync(id);
            if (generalTicketModel == null)
            {
                return NotFound();
            }
            return View(generalTicketModel);
        }

        // POST: GeneralTickets/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Issue,ExtraDetails,CreatedBy,CreatedAt")] GeneralTicketModel generalTicketModel)
        {
            if (id != generalTicketModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    generalTicketModel.CreatedAt = DateTime.Now;
                    _context.Update(generalTicketModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GeneralTicketModelExists(generalTicketModel.Id))
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
            return View(generalTicketModel);
        }

        // GET: GeneralTickets/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var generalTicketModel = await _context.GeneralTickets
                .FirstOrDefaultAsync(m => m.Id == id);
            if (generalTicketModel == null)
            {
                return NotFound();
            }

            return View(generalTicketModel);
        }

        // POST: GeneralTickets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var generalTicketModel = await _context.GeneralTickets.FindAsync(id);
            _context.GeneralTickets.Remove(generalTicketModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GeneralTicketModelExists(int id)
        {
            return _context.GeneralTickets.Any(e => e.Id == id);
        }
    }
}
