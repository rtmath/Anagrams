using Xunit;
using Anagram.Object;
using System.Collections.Generic;

namespace TestingGrounds
{
  public class AnagramTest
  {
    [Fact]
    public void Test1_DoesSortingAlgorithmWork_ReturnBool()
    {
      AnagramClass testAnagram = new AnagramClass();
      string myString = "test";
      char[] myArray = myString.ToCharArray();
      char[] expectedResult = { 'e', 's', 'f', 't' };
      Assert.Equal(expectedResult, testAnagram.CharSort(myArray));
    }
  }
}
