
using System.Collections.Generic;
using Xunit;
namespace NumbersToWordsNS.Objects
{
  public class NumbersToWordsTest
  {
    [Fact]
    public void Test1_ToSeeIfInput10_ReturnsTen()
    {
      //Arrange
      int input1 = 10;
      NumbersToWords myNumber = new NumbersToWords(input1);

      //Act
      string result = myNumber.DictionaryMethod();

      //Assert
      Assert.Equal("ten", result);
    }
  }
}
