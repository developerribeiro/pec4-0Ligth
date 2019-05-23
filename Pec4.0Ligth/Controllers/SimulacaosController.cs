using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Pec4_0Ligth.Models;

namespace Pec4_0Ligth.Controllers
{
    public class SimulacaosController : Controller
    {
        private readonly Pec4_0LigthContext _context;

        public SimulacaosController(Pec4_0LigthContext context)
        {
            _context = context;
        }

        // GET: Simulacaos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Simulacao.ToListAsync());
        }

        // GET: Simulacaos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var simulacao = await _context.Simulacao
                .FirstOrDefaultAsync(m => m.Id == id);
            if (simulacao == null)
            {
                return NotFound();
            }

            return View(simulacao);
        }

        // GET: Simulacaos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Simulacaos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Data,Status")] Simulacao simulacao)
        {
            if (ModelState.IsValid)
            {
                _context.Add(simulacao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(simulacao);
        }

        // GET: Simulacaos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var simulacao = await _context.Simulacao.FindAsync(id);
            if (simulacao == null)
            {
                return NotFound();
            }
            return View(simulacao);
        }

        // POST: Simulacaos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Data,Status")] Simulacao simulacao)
        {
            if (id != simulacao.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(simulacao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SimulacaoExists(simulacao.Id))
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
            return View(simulacao);
        }

        // GET: Simulacaos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var simulacao = await _context.Simulacao
                .FirstOrDefaultAsync(m => m.Id == id);
            if (simulacao == null)
            {
                return NotFound();
            }

            return View(simulacao);
        }

        // POST: Simulacaos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var simulacao = await _context.Simulacao.FindAsync(id);
            _context.Simulacao.Remove(simulacao);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SimulacaoExists(int id)
        {
            return _context.Simulacao.Any(e => e.Id == id);
        }
    }
}
