using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;
using System.Collections.Generic;
using System;

namespace WordCounter.Tests
{
  [TestClass]
  public class RepeartCounterTest
  {
    [TestMethod]
    public void getUserInput_returnsUserInput_True()
    {
      string input = "cat";
      string secondInput = "Hello there cat";
      RepeatCounter checker = new RepeatCounter(input, secondInput);

      Assert.AreEqual(input, checker.GetInput());
      Assert.AreEqual(secondInput, checker.GetSecondInput());
    }
    [TestMethod]
    public void secondInputSplit_returnSplit_True()
    {
      string input = "cat";
      string secondInput = "Hello there cat";
      RepeatCounter checker = new RepeatCounter(input, secondInput);

      CollectionAssert.AreEqual(new string[]{ "Hello", "there", "cat", }, RepeatCounter.SplitSecondInput(secondInput));
    }
    [TestMethod]
    public void Basic_MatchCheck_True()
    {
      string input = "cat";
      string secondInput = "Hello there cat";
      RepeatCounter checker = new RepeatCounter(input, secondInput);

      Assert.AreEqual(1, checker.MatchCheck(input));
    }
    [TestMethod]
    public void Exceptions_MatchCheck_True()
    {
      string input = "cat";
      string secondInput = "Hello there cat. Cat, how are you today?";
      RepeatCounter checker = new RepeatCounter(input, secondInput);

      Assert.AreEqual(2, checker.MatchCheck(input));
    }
  }
}
