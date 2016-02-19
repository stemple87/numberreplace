using Nancy;
using NumbersToWordsNS.Objects;
using System.Collections.Generic;
using System;

namespace NumbersToWordsNS
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ =>
      {
        string results = "";
        return View["index.cshtml", results];
      };

      Post["/"] = _ =>
      {
        NumbersToWords newNumbersToWords = new NumbersToWords(Request.Form["number"]);
        string results = newNumbersToWords.DictionaryMethod();
        return View["index.cshtml", results];
      };
    }
  }
}
