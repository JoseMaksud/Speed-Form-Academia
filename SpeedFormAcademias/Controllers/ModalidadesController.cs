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
    public class ModalidadesController : Controller
    {
        private readonly AppDbContext _context;

        public ModalidadesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Modalidades
        public async Task<IActionResult> Index()
        {
            return View(await _context.Modalidades.ToListAsync());
        }

        // GET: Modalidades/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var modalidade = await _context.Modalidades
                .FirstOrDefaultAsync(m => m.Id == id);
            if (modalidade == null)
            {
                return NotFound();
            }

            return View(modalidade);
        }

        // GET: Modalidades/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Modalidades/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Modalidade modalidade, IFormFile Imagem, IFormFile Imagem2)
        {
            if (ModelState.IsValid)
            {
                // Diretório para salvar as imagens
                var imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/modalidades");

                // Cria o diretório, se não existir
                if (!Directory.Exists(imagePath))
                {
                    Directory.CreateDirectory(imagePath);
                }

                // Processa a primeira imagem
                if (Imagem != null && Imagem.Length > 0)
                {
                    var fileName1 = $"{Guid.NewGuid()}_{Imagem.FileName}";
                    var filePath1 = Path.Combine(imagePath, fileName1);

                    using (var stream = new FileStream(filePath1, FileMode.Create))
                    {
                        await Imagem.CopyToAsync(stream);
                    }

                    modalidade.Imagem = $"img/modalidades/{fileName1}";
                }

                // Processa a segunda imagem
                if (Imagem2 != null && Imagem2.Length > 0)
                {
                    var fileName2 = $"{Guid.NewGuid()}_{Imagem2.FileName}";
                    var filePath2 = Path.Combine(imagePath, fileName2);

                    using (var stream = new FileStream(filePath2, FileMode.Create))
                    {
                        await Imagem2.CopyToAsync(stream);
                    }

                    modalidade.Imagem2 = $"img/modalidades/{fileName2}";
                }

                // Salva a modalidade no banco de dados
                _context.Add(modalidade);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(modalidade);
        }


        // GET: Modalidades/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var modalidade = await _context.Modalidades.FindAsync(id);
            if (modalidade == null)
            {
                return NotFound();
            }
            return View(modalidade);
        }

        // POST: Modalidades/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,DescricaoPT1,DescricaoPT2,DescricaoPT3")] Modalidade modalidade, IFormFile NovaFoto1, IFormFile NovaFoto2)
        {
            if (id != modalidade.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/modalidades");

                    if (!Directory.Exists(imagePath))
                    {
                        Directory.CreateDirectory(imagePath);
                    }

                    if (NovaFoto1 != null && NovaFoto1.Length > 0)
                    {
                        var fileName1 = $"{Guid.NewGuid()}_{NovaFoto1.FileName}";
                        var filePath1 = Path.Combine(imagePath, fileName1);

                        using (var stream = new FileStream(filePath1, FileMode.Create))
                        {
                            await NovaFoto1.CopyToAsync(stream);
                        }

                        modalidade.Imagem = $"img/modalidades/{fileName1}";
                    }

                    if (NovaFoto2 != null && NovaFoto2.Length > 0)
                    {
                        var fileName2 = $"{Guid.NewGuid()}_{NovaFoto2.FileName}";
                        var filePath2 = Path.Combine(imagePath, fileName2);

                        using (var stream = new FileStream(filePath2, FileMode.Create))
                        {
                            await NovaFoto2.CopyToAsync(stream);
                        }

                        modalidade.Imagem2 = $"img/modalidades/{fileName2}";
                    }

                    _context.Update(modalidade);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ModalidadeExists(modalidade.Id))
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
            return View(modalidade);
        }


        // GET: Modalidades/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var modalidade = await _context.Modalidades
                .FirstOrDefaultAsync(m => m.Id == id);
            if (modalidade == null)
            {
                return NotFound();
            }

            return View(modalidade);
        }

        // POST: Modalidades/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var modalidade = await _context.Modalidades.FindAsync(id);
            if (modalidade != null)
            {
                _context.Modalidades.Remove(modalidade);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ModalidadeExists(int id)
        {
            return _context.Modalidades.Any(e => e.Id == id);
        }
    }
}
