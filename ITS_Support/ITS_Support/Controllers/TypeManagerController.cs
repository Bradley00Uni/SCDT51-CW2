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

namespace ITS_Support.Views.TypeManager
{
    [Authorize(Roles = "Admin, Manager")]
    public class TypeManagerController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TypeManagerController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: TypeManager
        public async Task<IActionResult> Index()
        {
            return View(await _context.TypeModel.ToListAsync());
        }

        // GET: TypeManager/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var typeModel = await _context.TypeModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (typeModel == null)
            {
                return NotFound();
            }

            return View(typeModel);
        }

        // GET: TypeManager/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TypeManager/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Category")] TypeModel typeModel)
        {
            if (ModelState.IsValid)
            {


                _context.Add(typeModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(typeModel);
        }

        // GET: TypeManager/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var typeModel = await _context.TypeModel.FindAsync(id);
            if (typeModel == null)
            {
                return NotFound();
            }
            return View(typeModel);
        }

        // POST: TypeManager/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Category")] TypeModel typeModel)
        {
            if (id != typeModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(typeModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TypeModelExists(typeModel.Id))
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
            return View(typeModel);
        }

        // GET: TypeManager/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var typeModel = await _context.TypeModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (typeModel == null)
            {
                return NotFound();
            }

            return View(typeModel);
        }

        // POST: TypeManager/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var typeModel = await _context.TypeModel.FindAsync(id);
            _context.TypeModel.Remove(typeModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TypeModelExists(int id)
        {
            return _context.TypeModel.Any(e => e.Id == id);
        }
    }
}
