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
      string content = "Hello there cat";
      RepeatCounter checker = new RepeatCounter(input, content);

      Assert.AreEqual(input, checker.GetInput());
      Assert.AreEqual(content, checker.GetContent());
    }
    [TestMethod]
    public void contentSplit_returnSplit_True()
    {
      string input = "cat";
      string content = "Hello there cat";
      RepeatCounter checker = new RepeatCounter(input, content);

      CollectionAssert.AreEqual(new string[]{ "Hello", "there", "cat", }, RepeatCounter.SplitContent(content));
    }
    [TestMethod]
    public void Basic_MatchCheck_True()
    {
      string input = "cat";
      string content = "Hello there cat cat cat";
      RepeatCounter checker = new RepeatCounter(input, content);

      Assert.AreEqual(3, checker.MatchCheck(input));
    }
    [TestMethod]
    public void Capitalization_MatchCheck_Ignore()
    {
      string input = "cat";
      string content = "Hello there cat CAT CaT cAt";
      RepeatCounter checker = new RepeatCounter(input, content);

      Assert.AreEqual(4, checker.MatchCheck(input));
    }
    [TestMethod]
    public void Puntuation_MatchCheck_Ignore()
    {
      string input = "cat";
      string content = "Hello there, Cat. I love my cat! Where are you, cat? She says she has a 'cat.'";
      RepeatCounter checker = new RepeatCounter(input, content);

      Assert.AreEqual(4, checker.MatchCheck(input));
    }
  }
}
