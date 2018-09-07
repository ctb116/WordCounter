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
    public void getInput_returnsInput_String()
    {
      string input = "cat";
      RepeatCounter newRepeatCounter = new RepeatCounter(input);

      string result = newRepeatCounter.GetInput();

      Assert.AreEqual(input, result);
    }
  }
}
