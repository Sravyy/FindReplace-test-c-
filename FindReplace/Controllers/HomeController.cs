
using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using FindReplace;

namespace FindReplace.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
    [HttpPost("/results")]
    public ActionResult Results()
    {
      FindReplace newString = new FindReplace(Request.Form["str"], Request.Form["word"],Request.Form["replace"]);
      return View (newString);
    }
  }
}
