using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP03.Models;

namespace TP03.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        palabrasAhorcado palabras = new palabrasAhorcado();
        ViewBag.palabra = palabras.devolverPalabra();
        string palabraconGuiones = "";
        for (int i=0;i<ViewBag.palabra.Length;i++)
        {
            palabraconGuiones += "_";
        }
        ViewBag.palabraconGuiones = palabraconGuiones;
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
