using ITS_Support.Data;
using ITS_Support.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITS_Support.Views.AssetManager
{
    public class AssetController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AssetController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: AssetManager
        public async Task<IActionResult> Table()
        {
            RoomAssetViewModel roomAssetViewModel = new RoomAssetViewModel()
            {
                Assets = await _context.Assets.ToListAsync(),
                Rooms = await _context.Rooms.ToListAsync(),
                Campuses = await _context.Campuses.ToListAsync(),
                //Tickets
                Types = await _context.Types.ToListAsync()
            };
            return View(roomAssetViewModel);
        }

        public async Task<IActionResult> Index()
        {
            RoomAssetViewModel roomAssetViewModel = new RoomAssetViewModel()
            {
                Assets = await _context.Assets.ToListAsync(),
                Rooms = await _context.Rooms.ToListAsync(),
                Campuses = await _context.Campuses.ToListAsync(),
                //Tickets
                Types = await _context.Types.ToListAsync()
            };
            return View(roomAssetViewModel);
        }

        // GET: AssetManager/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var assetModel = await _context.Assets
                .FirstOrDefaultAsync(m => m.Id == id);
            if (assetModel == null)
            {
                return NotFound();
            }

            return View(assetModel);
        }
    }
}
