using Nancy;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Anagram.Object;

namespace AnagramProgram
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ =>
      {
        return View["index.cshtml"];
      };

      Get["/result"] = _ =>
      {
        string userWord = Request.Query["user-word"];
        string wordsToCheck = Request.Query["words-to-check"];

        AnagramClass mainAnagram = new AnagramClass(userWord);
        List <string> results = mainAnagram.GetMatches(wordsToCheck);

        return View["index.cshtml", results];
      };
    }
  }
}
