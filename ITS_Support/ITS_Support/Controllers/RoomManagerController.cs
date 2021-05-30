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

namespace ITS_Support.Views.RoomManager
{
    [Authorize(Roles = "Admin, Manager")]
    public class RoomManagerController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RoomManagerController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: RoomManager
        public async Task<IActionResult> Index()
        {
            RoomAssetViewModel roomAssetViewModel = new RoomAssetViewModel()
            {
                Rooms = await _context.Rooms.ToListAsync(),
                Campuses = await _context.Campuses.ToListAsync(),
                Assets = await _context.Assets.ToListAsync()
            };
            return View(roomAssetViewModel);
        }

        public async Task<IActionResult> Table()
        {
            RoomAssetViewModel roomAssetViewModel = new RoomAssetViewModel()
            {
                Rooms = await _context.Rooms.ToListAsync(),
                Campuses = await _context.Campuses.ToListAsync(),
                Assets = await _context.Assets.ToListAsync()
            };
            return View(roomAssetViewModel);
        }

        // GET: RoomManager/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roomModel = await _context.Rooms
                .FirstOrDefaultAsync(m => m.Id == id);
            if (roomModel == null)
            {
                return NotFound();
            }

            return View(roomModel);
        }

        // GET: RoomManager/Create
        public IActionResult Create()
        {
            RoomViewModel roomViewModel = new RoomViewModel()
            {
                Room = new RoomModel(),
                CampusList = _context.Campuses.Select(i => new SelectListItem
                {
                    Text = i.Name,
                    Value = i.Name.ToString()
                })
            };
            return View(roomViewModel);
        }

        // POST: RoomManager/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Room, Campus")] RoomViewModel roomModel)
        {

            if (ModelState.IsValid)
            {
                roomModel.Room.CreatedAt = DateTime.Now;
                roomModel.Room.LastEdited = DateTime.Now;
                roomModel.Room.Creator = User.Identity.Name;
                _context.Add(roomModel.Room);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(roomModel);
        }

        // GET: RoomManager/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roomModel = await _context.Rooms.FindAsync(id);
            if (roomModel == null)
            {
                return NotFound();
            }
            return View(roomModel);
        }

        // POST: RoomManager/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Campus,Id,Name,Creator,CreatedAt,LastEdited")] RoomModel roomModel)
        {
            if (id != roomModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    roomModel.LastEdited = DateTime.Now;
                    roomModel.Creator = User.Identity.Name;
                    _context.Update(roomModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RoomModelExists(roomModel.Id))
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
            return View(roomModel);
        }

        // GET: RoomManager/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roomModel = await _context.Rooms
                .FirstOrDefaultAsync(m => m.Id == id);
            if (roomModel == null)
            {
                return NotFound();
            }

            return View(roomModel);
        }

        // POST: RoomManager/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var roomModel = await _context.Rooms.FindAsync(id);
            _context.Rooms.Remove(roomModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RoomModelExists(int id)
        {
            return _context.Rooms.Any(e => e.Id == id);
        }
    }
}
