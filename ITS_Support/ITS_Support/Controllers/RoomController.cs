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

namespace ITS_Support.Views.Room
{
    [Authorize(Roles = "Admin, Manager, Support")]
    public class RoomController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RoomController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Room
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
    }
}
