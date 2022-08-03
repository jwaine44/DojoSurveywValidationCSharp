using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DojoSurveywValidation.Models;

namespace DojoSurveywValidation.Controllers;

public class HomeController : Controller
{
    [HttpGet("")]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost("")]
    public IActionResult SurveySubmission(Survey result)
    {
        if(ModelState.IsValid)
        {
            return RedirectToAction("result", result);
        }
        else
        {
            return View("Index");
        }
    }

    [HttpGet("result")]
    public IActionResult Result(Survey result)
    {
        return View(result);
    }

}
