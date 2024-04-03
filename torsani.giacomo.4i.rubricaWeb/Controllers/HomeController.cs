using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using torsani.giacomo._4i.rubricaWeb.Models;

namespace torsani.giacomo._4i.rubricaWeb.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Gelati()
    {
        List<Gelato> list = new List<Gelato>();
        list.Add(new Gelato { Id = 1, Nome = "Puffo", Descrizione = "Gelato azzurro", Immagine = "puffo.jpg" });
        list.Add(new Gelato { Id = 2, Nome = "Nutella", Descrizione = "Gelato al cioccolato con nutella", Immagine = "nutella.jpg" });
        list.Add(new Gelato { Id = 3, Nome = "Bacio", Descrizione = "Gelato al cioccolato con nocciole", Immagine = "bacio.jpg" });
        list.Add(new Gelato { Id = 4, Nome = "Fiordilatte", Descrizione = "Gelato al latte", Immagine = "fioridlatte.jpg" });
        return View(list);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
