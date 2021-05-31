using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ITS_Support.Data;
using ITS_Support.Models;
using Microsoft.AspNetCore.Authorization;

namespace ITS_Support.Views.TechnicalTickets
{
    [Authorize(Roles = "Admin, Manager, Support")]
    public class TechnicalTicketsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TechnicalTicketsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: TechnicalTickets
        public async Task<IActionResult> Index()
        {
            TechnicalTicketViewModel technicalTicketViewModel = new TechnicalTicketViewModel()
            {
                TechnicalTickets = await _context.TechnicalTickets.Include(t => t.Asset).Include(t => t.Updates).ToListAsync(),
                Rooms = await _context.Rooms.ToListAsync()
            };
            return View(technicalTicketViewModel);
        }

        public async Task<IActionResult> Table()
        {
            TechnicalTicketViewModel technicalTicketViewModel = new TechnicalTicketViewModel()
            {
                TechnicalTickets = await _context.TechnicalTickets.Include(t => t.Asset).Include(t => t.Updates).ToListAsync(),
                Rooms = await _context.Rooms.ToListAsync()
            };
            return View(technicalTicketViewModel);
        }

        // GET: TechnicalTickets/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var technicalTicketModel = await _context.TechnicalTickets
                .Include(t => t.Asset).Include(t => t.Updates)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (technicalTicketModel == null)
            {
                return NotFound();
            }

            return View(technicalTicketModel);
        }

        // GET: TechnicalTickets/Create
        public IActionResult Create()
        {
            ViewData["AssetId"] = new SelectList(_context.Assets, "Id", "Name");
            return View();
        }

        // POST: TechnicalTicketModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RaisedBy,RaisedRole,AssetId,Id,Issue,ExtraDetails,CreatedBy,CreatedAt")] TechnicalTicketModel technicalTicketModel)
        {
            if (ModelState.IsValid)
            {
                technicalTicketModel.CreatedAt = DateTime.Now;
                _context.Add(technicalTicketModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AssetId"] = new SelectList(_context.Assets, "Id", "Name", technicalTicketModel.AssetId);
            return View(technicalTicketModel);
        }

        // GET: TechnicalTickets/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var technicalTicketModel = await _context.TechnicalTickets
                .Include(t => t.Asset)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (technicalTicketModel == null)
            {
                return NotFound();
            }

            return View(technicalTicketModel);
        }

        // POST: TechnicalTickets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var technicalTicketModel = await _context.TechnicalTickets.FindAsync(id);
            _context.TechnicalTickets.Remove(technicalTicketModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TechnicalTicketModelExists(int id)
        {
            return _context.TechnicalTickets.Any(e => e.Id == id);
        }

        [HttpPost, ActionName("Update")]
        public async Task<IActionResult> Comment(string status, string update, int? id)
        {
            var technicalTicketModel = await _context.TechnicalTickets.FirstOrDefaultAsync(m => m.Id == id);

            if (technicalTicketModel == null)
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

            technicalTicketModel.Updates.Add(u);
            _context.Update(technicalTicketModel);

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Details), new { id = id });
        }
    }
}
