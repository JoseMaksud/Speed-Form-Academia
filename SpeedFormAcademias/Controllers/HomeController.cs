using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SpeedFormAcademias.Data;
using SpeedFormAcademias.Models;
using SpeedFormAcademias.ViewModels;

namespace SpeedFormAcademias.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly AppDbContext _context;

    public HomeController(ILogger<HomeController> logger, AppDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Modalidades()
    {
        var modalidades = _context.Modalidades.ToList();
        return View(modalidades);
    }
    public IActionResult Unidades()
    {
        var unidades = _context.Unidades
                               .Select(u => new Unidade
                               {
                                   Id = u.Id,
                                   Nome = u.Nome,
                                   Fotos = u.Fotos.Where(f => f.Destaque).ToList()
                               })
                               .ToList();

        return View(unidades);
    }

    public IActionResult SobreNos()
    {
        return View();
    }

    public IActionResult Contato()
    {
        return View();
    }
    public IActionResult DetailsModalidades(int id)
    {
        var modalidade = _context.Modalidades.FirstOrDefault(m => m.Id == id);
        if (modalidade == null)
        {
            return NotFound();
        }

        var viewModel = new DetailsModalidade
        {
            Modalidade = modalidade,
            Modalidades = _context.Modalidades.ToList()
        };

        return View(viewModel);
    }

    public IActionResult DetailsUnidades(int id)
{
    var unidade = _context.Unidades
                          .Include(u => u.Fotos)
                          .FirstOrDefault(u => u.Id == id);

    if (unidade == null)
    {
        return NotFound();
    }

    var viewModel = new DetailsUnidadeViewModel
    {
        Nome = unidade.Nome,
        Fotos = unidade.Fotos.ToList(),
        LocalizacaoFoto = unidade.LocalizacaoFoto
    };

    return View(viewModel);
}



    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
