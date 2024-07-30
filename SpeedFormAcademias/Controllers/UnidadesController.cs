using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SpeedFormAcademias.Data;
using SpeedFormAcademias.Models;

namespace SpeedFormAcademias.Controllers
{
    public class UnidadesController : Controller
    {
        private readonly AppDbContext _context;

        public UnidadesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Unidades
        public async Task<IActionResult> Index()
        {
            return View(await _context.Unidades.ToListAsync());
        }

        // GET: Unidades/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var unidade = await _context.Unidades
                .FirstOrDefaultAsync(m => m.Id == id);
            if (unidade == null)
            {
                return NotFound();
            }

            return View(unidade);
        }

        // GET: Unidades/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Unidades/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Localizacao")] Unidade unidade)
        {
            if (ModelState.IsValid)
            {
                _context.Add(unidade);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(unidade);
        }

        // GET: Unidades/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var unidade = await _context.Unidades.FindAsync(id);
            if (unidade == null)
            {
                return NotFound();
            }
            return View(unidade);
        }

        // POST: Unidades/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Localizacao")] Unidade unidade)
        {
            if (id != unidade.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(unidade);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UnidadeExists(unidade.Id))
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
            return View(unidade);
        }

        // GET: Unidades/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var unidade = await _context.Unidades
                .FirstOrDefaultAsync(m => m.Id == id);
            if (unidade == null)
            {
                return NotFound();
            }

            return View(unidade);
        }

        // POST: Unidades/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var unidade = await _context.Unidades.FindAsync(id);
            if (unidade != null)
            {
                _context.Unidades.Remove(unidade);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UnidadeExists(int id)
        {
            return _context.Unidades.Any(e => e.Id == id);
        }
    }
}
