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

namespace ITS_Support.Views.CampusManager
{
    [Authorize(Roles = "Admin, Manager")]
    public class CampusManagerController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CampusManagerController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CampusManager
        public async Task<IActionResult> Index()
        {
            CampusRoomViewModel returnModels = new CampusRoomViewModel
            {
                Campuses = await _context.Campuses.ToListAsync(),
                Rooms = await _context.Rooms.ToListAsync()
            };

            return View(returnModels);
        }

        // GET: CampusManager/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var campusModel = await _context.Campuses
                .FirstOrDefaultAsync(m => m.Id == id);
            if (campusModel == null)
            {
                return NotFound();
            }

            return View(campusModel);
        }

        // GET: CampusManager/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CampusManager/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Creator,CreatedAt,LastEdited")] CampusModel campusModel)
        {
            if (ModelState.IsValid)
            {
                campusModel.Creator = User.Identity.Name;
                campusModel.CreatedAt = DateTime.Now;
                campusModel.LastEdited = DateTime.Now;
                _context.Add(campusModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(campusModel);
        }

        // GET: CampusManager/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var campusModel = await _context.Campuses.FindAsync(id);
            if (campusModel == null)
            {
                return NotFound();
            }
            return View(campusModel);
        }

        // POST: CampusManager/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Creator,CreatedAt,LastEdited, ImageURL")] CampusModel campusModel)
        {
            if (id != campusModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    campusModel.CreatedAt = campusModel.CreatedAt;
                    campusModel.Creator = User.Identity.Name;
                    campusModel.LastEdited = DateTime.Now;
                    _context.Update(campusModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CampusModelExists(campusModel.Id))
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
            return View(campusModel);
        }

        // GET: CampusManager/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var campusModel = await _context.Campuses
                .FirstOrDefaultAsync(m => m.Id == id);
            if (campusModel == null)
            {
                return NotFound();
            }

            return View(campusModel);
        }

        // POST: CampusManager/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var campusModel = await _context.Campuses.FindAsync(id);
            _context.Campuses.Remove(campusModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CampusModelExists(int id)
        {
            return _context.Campuses.Any(e => e.Id == id);
        }
    }
}
