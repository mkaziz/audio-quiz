using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using audio_quiz.Models;
using audio_quiz.Models.DbModels;

namespace audio_quiz.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Quiz quiz = Quiz.FromFile("Models/questionconfig/kazakh.json");
        return View(quiz);
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
