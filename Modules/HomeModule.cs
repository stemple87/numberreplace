using Nancy;
using NumbersToWordsNS.Objects;
using System.Collections.Generic;
using System;

namespace NumbersToWordsNS
{
  public class HomeModule : NancyModule
  {
    // public HomeModule()
    // {
    //   Get["/"] = _ =>
    //   {
    //     string results = "";
    //     return View["index.cshtml", results];
    //   };
    //
    //   Post["/"] = _ =>
    //   {
    //     ScrabbleScore newScrabbleScore = new ScrabbleScore(Request.Form["word"]);
    //     string results = newScrabbleScore.GetResults();
    //     return View["index.cshtml", results];
    //   };
    // }
  }
}
