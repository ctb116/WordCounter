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
      string secondInput = "Hello there cat cat cat";
      RepeatCounter checker = new RepeatCounter(input, secondInput);

      Assert.AreEqual(3, checker.MatchCheck(input));
    }
    [TestMethod]
    public void Capitalization_MatchCheck_Ignore()
    {
      string input = "cat";
      string secondInput = "Hello there cat CAT CaT cAt";
      RepeatCounter checker = new RepeatCounter(input, secondInput);

      Assert.AreEqual(4, checker.MatchCheck(input));
    }
    [TestMethod]
    public void Puntuation_MatchCheck_Ignore()
    {
      string input = "cat";
      string secondInput = "Hello there, Cat.";
      RepeatCounter checker = new RepeatCounter(input, secondInput);

      Assert.AreEqual(1, checker.MatchCheck(input));
    }
  }
}
