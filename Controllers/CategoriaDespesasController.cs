using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using papagio.Dados;
using papagio.Models;

namespace papagio.Controllers
{
    public class CategoriaDespesasController : Controller
    {
        private readonly Context _context;

        public CategoriaDespesasController(Context context)
        {
            _context = context;
        }

        // GET: CategoriaDespesas
        public async Task<IActionResult> Index()
        {
            return View(await _context.CategoriaDespesas.ToListAsync());
        }

        // GET: CategoriaDespesas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categoriaDespesa = await _context.CategoriaDespesas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (categoriaDespesa == null)
            {
                return NotFound();
            }

            return View(categoriaDespesa);
        }

        // GET: CategoriaDespesas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CategoriaDespesas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Descricao")] CategoriaDespesa categoriaDespesa)
        {
            if (ModelState.IsValid)
            {
                _context.Add(categoriaDespesa);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(categoriaDespesa);
        }

        // GET: CategoriaDespesas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categoriaDespesa = await _context.CategoriaDespesas.FindAsync(id);
            if (categoriaDespesa == null)
            {
                return NotFound();
            }
            return View(categoriaDespesa);
        }

        // POST: CategoriaDespesas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Descricao")] CategoriaDespesa categoriaDespesa)
        {
            if (id != categoriaDespesa.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(categoriaDespesa);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoriaDespesaExists(categoriaDespesa.Id))
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
            return View(categoriaDespesa);
        }

        // GET: CategoriaDespesas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categoriaDespesa = await _context.CategoriaDespesas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (categoriaDespesa == null)
            {
                return NotFound();
            }

            return View(categoriaDespesa);
        }

        // POST: CategoriaDespesas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var categoriaDespesa = await _context.CategoriaDespesas.FindAsync(id);
            _context.CategoriaDespesas.Remove(categoriaDespesa);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CategoriaDespesaExists(int id)
        {
            return _context.CategoriaDespesas.Any(e => e.Id == id);
        }
    }
}
