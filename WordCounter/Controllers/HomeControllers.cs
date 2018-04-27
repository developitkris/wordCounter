using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using WordCounterProgram.Models;

namespace WordCounterProgram.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpGet("/form")]
    public ActionResult Form()
    {
      return View();
    }

    [HttpPost("/")]
    public ActionResult Display()
    {
      RepeatCounter.ClearAll();
      RepeatCounter newCount = new RepeatCounter();
      string inputWord = (Request.Form["inputWord"]);
      string inputSentence = (Request.Form["inputSentence"]);

      int result = RepeatCounter.WordCount(input, inputSentence);

      return View("Index", newCount);
    }



  }
}
