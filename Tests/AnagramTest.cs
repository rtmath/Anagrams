using Xunit;
using Anagram.Object;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace TestingGrounds
{
  public class AnagramTest
  {
    [Fact]
    public void CheckAnagram_MatchWordWithDuplicates_false()
    {
      AnagramClass testAnagram = new AnagramClass("lotto");
      Assert.Equal(false, testAnagram.CheckAnagram("loooo"));
    }

    [Fact]
    public void CheckAnagram_MatchWordWithDuplicates_true()
    {
      AnagramClass testAnagram = new AnagramClass("letter");
      Assert.Equal(true, testAnagram.CheckAnagram("lett"));
    }

    [Fact]
    public void CheckAnagram_MatchesWordsWithApostrophes_true()
    {
      AnagramClass testAnagram = new AnagramClass("we're");
      Assert.Equal(true, testAnagram.CheckAnagram("were"));
    }

    [Fact]
    public void InputCleanup_SplitStringToWordList_true()
    {
      AnagramClass testAnagram = new AnagramClass("test");
      string testInput = "word, word2, word3";
      List<string> expectedOutput = new List<string> { "word", "word2", "word3" };
      Assert.Equal(expectedOutput, testAnagram.InputCleanup(testInput));
    }
  }
}
