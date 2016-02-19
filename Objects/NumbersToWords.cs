using System.Collections.Generic;
using System;
using System.Text.RegularExpressions;

namespace NumbersToWordsNS.Objects
{
  public class NumbersToWords
  {
    private int _input;

    public NumbersToWords(int myInput)
    {
      _input = myInput;
    }

    public string DictionaryMethod()
    {
      string outputString = "";
      Dictionary<int, string> dictionaryTo20 = new Dictionary<int, string>()
      {
        {1, "one"},
        {2, "two"},
        {3, "three"},
        {4, "four"},
        {5, "Five"},
        {6, "six"},
        {7, "seven"},
        {8, "eight"},
        {9, "nine"},
        {10, "ten"},
        {11, "eleven"},
        {12, "twelve"},
        {13, "thirteen"},
        {14, "fourteen"},
        {15, "fifteen"},
        {16, "sixteen"},
        {17, "seventeen"},
        {18, "eighteen"},
        {19, "nineteen"},
        {20, "twenty"}
      };
      // Console.WriteLine(dictionaryTo10.ContainsKey(_input));
      if(dictionaryTo20.ContainsKey(_input))
      {
        foreach(KeyValuePair<int, string> entry in dictionaryTo20)
        {
          if (_input == entry.Key)
          {
            outputString = entry.Value;

          }
        }
        return outputString;
      }

      else
      {
        return "nothin. That's not beetween one and twenty!";
      }
    }
    // public string GetResults()
    // {
    //
    // }
  }
}
