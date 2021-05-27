using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ITS_Support.Data;
using ITS_Support.Models;

namespace ITS_Support.Views.AssetManager
{
    public class AssetManagerController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AssetManagerController(ApplicationDbContext context)
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

        // GET: AssetManager/Create
        public IActionResult Create()
        {
            AssetViewModel assetViewModel = new AssetViewModel()
            {
                Asset = new AssetModel(),
                RoomList = _context.Rooms.Select(r => new SelectListItem
                {
                    Text = r.Campus + " - " + r.Name,
                    Value = r.Id.ToString()
                }),
                TypeList = _context.Types.Select(t => new SelectListItem
                {
                    Text = t.Category,
                    Value = t.Category.ToString()
                })
            };

            return View(assetViewModel);
        }

        // POST: AssetManager/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Asset, Room")] AssetViewModel assetModel)
        {
            if (ModelState.IsValid)
            {
                assetModel.Asset.CreatedAt = DateTime.Now;
                assetModel.Asset.LastEdited = DateTime.Now;
                assetModel.Asset.Creator = User.Identity.Name;

                _context.Add(assetModel.Asset);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(assetModel);
        }

        // GET: AssetManager/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var assetModel = await _context.Assets.FindAsync(id);
            if (assetModel == null)
            {
                return NotFound();
            }


            AssetViewModel assetViewModel = new AssetViewModel()
            {
                Asset = await _context.Assets.FindAsync(id),
                TypeList = _context.Types.Select(t => new SelectListItem
                {
                    Text = t.Category,
                    Value = t.Category.ToString()
                })
            };

            return View(assetViewModel);
        }

        // POST: AssetManager/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Asset")] AssetViewModel assetModel)
        {
            if (id != assetModel.Asset.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    assetModel.Asset.LastEdited = DateTime.Now;
                    _context.Update(assetModel.Asset);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AssetModelExists(assetModel.Asset.Id))
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
            return View(assetModel);
        }

        // GET: AssetManager/Delete/5
        public async Task<IActionResult> Delete(int? id)
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

        // POST: AssetManager/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var assetModel = await _context.Assets.FindAsync(id);
            _context.Assets.Remove(assetModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AssetModelExists(int id)
        {
            return _context.Assets.Any(e => e.Id == id);
        }
    }
}
