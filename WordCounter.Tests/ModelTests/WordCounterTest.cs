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
      List<string> inputList = new List<string> { "cat" };

      RepeatCounter checker = new RepeatCounter(input, inputList);

      Assert.AreEqual(input, checker.GetInput());
      CollectionAssert.AreEqual(inputList, checker.GetInputList());
    }
    // [TestMethod]
    // public void getInputList_returnInputList_ListSt()
    // {
    //   List<string> inputList = new List<string> { "cat" };
    //   RepeatCounter newInputList = new RepeatCounter(inputList);
    //
    //
    //   CollectionAssert.AreEqual(new List<string> { "cat" }, newInputList.GetInputList());
    // }
  }
}
