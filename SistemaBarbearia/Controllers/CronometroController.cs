using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SistemaBarbearia.Models;

namespace SistemaBarbearia.Controllers;

public class CronometroController : Controller
{
    public IActionResult Index()
    {
        var json = HttpContext.Session.GetString("Cronometros");

        var cronometros = json is null
            ? new List<Cronometro>()
            : JsonSerializer.Deserialize<List<Cronometro>>(json)!;

        return View(cronometros);
    }

    [HttpPost]
    public IActionResult Adicionar(string nome)
    {
        if (string.IsNullOrWhiteSpace(nome))
        {
            return RedirectToAction(nameof(Index));
        }

        var json = HttpContext.Session.GetString("Cronometros");

        var cronometros = json is null
            ? new List<Cronometro>()
            : JsonSerializer.Deserialize<List<Cronometro>>(json)!;

        cronometros.Add(new Cronometro(nome));

        HttpContext.Session.SetString(
            "Cronometros",
            JsonSerializer.Serialize(cronometros));

        return RedirectToAction(nameof(Index));
    }


    [HttpPost]
    public IActionResult Pausar(int indice)
    {
        var json = HttpContext.Session.GetString("Cronometros");

        var cronometros = json is null
            ? new List<Cronometro>()
            : JsonSerializer.Deserialize<List<Cronometro>>(json)!;

        if (indice < 0 || indice >= cronometros.Count)
        {
            return RedirectToAction(nameof(Index));
        }

        cronometros[indice].PausarOuContinuar();

        HttpContext.Session.SetString(
            "Cronometros",
            JsonSerializer.Serialize(cronometros));

        return RedirectToAction(nameof(Index));
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View("Error!");
    }
}
