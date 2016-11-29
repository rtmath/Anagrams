using System;
using System.Collections.Generic;

namespace Anagram.Object
{
  public class AnagramClass
  {
    // public List<string> CheckAnagrams()
    // {
    //   List<string> outputList = new List<string> { };
    //
    //   Char[] inputWordLetters = _inputWord.ToCharArray();
    //
    //   Char[] sortedInputLetters = inputWordLetters.Sort;
    //
    //   for(int i = 0; i<_comparisonList.Length; i++)
    //   {
    //     string currentWord = _comparisonList[i];
    //     Char[] currentWordLetters = currentWord.ToCharArray();
    //   }
    // }

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
  }
}
