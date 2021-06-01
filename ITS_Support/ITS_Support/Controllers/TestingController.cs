using ITS_Support.Data;
using ITS_Support.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace ITS_Support.Controllers
{
    public class TestingController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TestingController(ApplicationDbContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index()
        {
            TestingViewModel testingModel = new TestingViewModel()
            {
                GeneralTickets = await _context.GeneralTickets.ToListAsync(),
                TechnicalTickets = await _context.TechnicalTickets.ToListAsync(),
                RoomTickets = await _context.RoomTickets.ToListAsync(),
                Campuses = await _context.Campuses.ToListAsync(),
                Rooms = await _context.Rooms.ToListAsync(),
                Assets = await _context.Assets.ToListAsync()
            };

            return View(testingModel);
        }
        
    }
}
