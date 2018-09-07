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
    public void InputChecker_returnsInput_True()
    {
      RepeatCounter testFirstInput = new RepeatCounter();
      Assert.AreEqual("Cat", testFirstInput.InputCheck("cat"));
    }
  }
}
