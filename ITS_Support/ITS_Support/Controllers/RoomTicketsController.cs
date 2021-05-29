using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ITS_Support.Data;
using ITS_Support.Models;

namespace ITS_Support.Views.RoomTickets
{
    public class RoomTicketsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RoomTicketsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: RoomTickets
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.RoomTickets.Include(r => r.Room);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: RoomTickets/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roomTicketModel = await _context.RoomTickets
                .Include(r => r.Room)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (roomTicketModel == null)
            {
                return NotFound();
            }

            return View(roomTicketModel);
        }

        // GET: RoomTickets/Create
        public IActionResult Create()
        {
            var Rooms = _context.Rooms.Select(r => new
            {
                RoomsID = r.Id,
                Description = string.Format("{0} - {1}", r.Campus, r.Name)
            }).ToList();

            ViewData["RoomId"] = new SelectList(Rooms, "RoomsID", "Description");
            return View();
        }

        // POST: RoomTickets/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RoomId,Id,Issue,ExtraDetails,CreatedBy,CreatedAt")] RoomTicketModel roomTicketModel)
        {
            if (ModelState.IsValid)
            {
                roomTicketModel.CreatedAt = DateTime.Now;
                _context.Add(roomTicketModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["RoomId"] = new SelectList(_context.Rooms, "Id", "Name", roomTicketModel.RoomId);
            return View(roomTicketModel);
        }

        // GET: RoomTickets/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roomTicketModel = await _context.RoomTickets.FindAsync(id);
            if (roomTicketModel == null)
            {
                return NotFound();
            }
            ViewData["RoomId"] = new SelectList(_context.Rooms, "Id", "Name", roomTicketModel.RoomId);
            return View(roomTicketModel);
        }

        // POST: RoomTickets/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RoomId,Id,Issue,ExtraDetails,CreatedBy,CreatedAt")] RoomTicketModel roomTicketModel)
        {
            if (id != roomTicketModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(roomTicketModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RoomTicketModelExists(roomTicketModel.Id))
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
            ViewData["RoomId"] = new SelectList(_context.Rooms, "Id", "Name", roomTicketModel.RoomId);
            return View(roomTicketModel);
        }

        // GET: RoomTickets/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roomTicketModel = await _context.RoomTickets
                .Include(r => r.Room)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (roomTicketModel == null)
            {
                return NotFound();
            }

            return View(roomTicketModel);
        }

        // POST: RoomTickets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var roomTicketModel = await _context.RoomTickets.FindAsync(id);
            _context.RoomTickets.Remove(roomTicketModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RoomTicketModelExists(int id)
        {
            return _context.RoomTickets.Any(e => e.Id == id);
        }
    }
}
