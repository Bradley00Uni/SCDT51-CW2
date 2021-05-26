﻿using ITS_Support.Data;
using ITS_Support.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITS_Support.Controllers
{
    public class RoomController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RoomController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            CampusRoomViewModel returnModels = new CampusRoomViewModel();
            returnModels.Campuses = await _context.Campuses.ToListAsync();
            returnModels.Rooms = await _context.Rooms.ToListAsync();
            
            return View(returnModels);
        }
    }
}