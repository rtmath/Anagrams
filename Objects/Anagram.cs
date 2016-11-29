using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Anagram.Object
{
  public class AnagramClass
  {
    private string _inputWord;

    public AnagramClass(string newInputWord)
    {
      _inputWord = newInputWord;
    }

    public List<string> InputCleanup(string words)
    {
      string[] myDelim = { ", " };
      string[] wordsArray = words.Split(myDelim, StringSplitOptions.None);
      List<string> wordsList = new List<string>(wordsArray);
      return wordsList;
    }

    public char[] CharSort(char[] oldArray)
    {
      for (int i = 1; i < oldArray.Length; i++)
      {
        int j = i;
        while (j > 0 && oldArray[j-1] > oldArray[j])
        {
          char tempVar = oldArray[j-1];
          oldArray[j-1] = oldArray[j];
          oldArray[j] = tempVar;
          j--;
        }
      }
      return oldArray;
    }

    public bool CheckAnagram(string testWord)
    {
      bool matching = true;
      string inputWord = _inputWord.ToLower();
      foreach (char letter in testWord)
      {
        string letterString = letter.ToString();
        if (inputWord.Contains(letterString) || letterString == "\'")
        {
          Regex regPattern = new Regex(letterString);
          inputWord = regPattern.Replace(inputWord, "-", 1);
        }
        else
        {
          matching = false;
        }
      }
      return matching;
    }

    public List<string> GetMatches(string inputWords)
    {
      List<string> cleanWords = InputCleanup(inputWords);
      List<string> outputWordList = new List<string> { };

      foreach (string word in cleanWords)
      {
        string wordLower = word.ToLower();
        if(CheckAnagram(wordLower))
        {
          outputWordList.Add(word);
        }
      }
      return outputWordList;
    }
  }
}
