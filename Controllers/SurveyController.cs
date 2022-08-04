using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DojoSurveywValidation.Models;

namespace DojoSurveywValidation.Controllers;

public class SurveyController : Controller
{
    [HttpGet("")]
    public IActionResult Index()
    {
        return View("Index");
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
            return Index();
        }
    }

    [HttpGet("result")]
    public IActionResult Result(Survey result)
    {
        return View(result);
    }

}
