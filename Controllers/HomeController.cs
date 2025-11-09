using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using musicdex.Data;
using musicdex.Models;

namespace musicdex.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly AppDbContext _context;

    public HomeController(ILogger<HomeController> logger, AppDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var generos = await _context.Generos
            .Include(g => g.Musicas)
            .OrderBy(g => g.Nome)
            .ToListAsync();

        return View(generos);
    }

    public async Task<IActionResult> Details(int id)
    {
        var musica = await _context.Musicas
            .Include(m => m.Genero)
            .FirstOrDefaultAsync(m => m.Id == id);

        if (musica == null) return NotFound();

        return View(musica);
    }

    public IActionResult Privacy() => View();

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
