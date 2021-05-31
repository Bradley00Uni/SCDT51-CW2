using ITS_Support.Data;
using ITS_Support.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITS_Support.Controllers
{
    [Authorize(Roles = "Admin, Manager, Support")]
    public class CampusController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CampusController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            CampusRoomViewModel returnModels = new CampusRoomViewModel
            {
                Campuses = await _context.Campuses.ToListAsync(),
                Rooms = await _context.Rooms.ToListAsync()
            };

            return View(returnModels);
        }

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
    }
}
