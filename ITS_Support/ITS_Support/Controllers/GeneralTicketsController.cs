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
        public async Task<IActionResult> Table()
        {
            return View(await _context.GeneralTickets.Include(t => t.Updates).ToListAsync());
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.GeneralTickets.Include(t => t.Updates).ToListAsync());
        }

        // GET: GeneralTickets/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var generalTicketModel = await _context.GeneralTickets.Include(t => t.Updates)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (generalTicketModel == null)
            {
                return NotFound();
            }

            GeneralTicketViewModel generalTicketViewModel = new GeneralTicketViewModel()
            {
                GeneralTicket = generalTicketModel,
                Update = new UpdateModel()
            };

            return View(generalTicketViewModel);
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

        [HttpPost, ActionName("Update")]
        public async Task<IActionResult> Comment(string status, string update, int? id)
        {
            var generalTicketModel = await _context.GeneralTickets.FirstOrDefaultAsync(m => m.Id == id);

            if (generalTicketModel == null)
            {
                return NotFound();
            }

            UpdateModel u = new UpdateModel
            {
                Update = update,
                CreatedAt = DateTime.Now,
                Status = status,
                CreatedBy = User.Identity.Name
            };

            generalTicketModel.Updates.Add(u);
            _context.Update(generalTicketModel);

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Details), new { id = id });
        }
    }
}
