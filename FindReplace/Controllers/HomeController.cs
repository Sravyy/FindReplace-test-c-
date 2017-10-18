
// using System.Collections.Generic;
// using System;
// using Microsoft.AspNetCore.Mvc;
// using RockPS;
//
// namespace RockPS.Controllers
// {
//   public class HomeController : Controller
//   {
//     [HttpGet("/")]
//     public ActionResult Index()
//     {
//       return View();
//     }
//     [HttpPost("/results")]
//     public ActionResult Results()
//     {
//       RockPS newWinner = new RockPS (Request.Form["input1"], Request.Form["input2"]);
//       return View (newWinner);
//     }
//   }
// }
