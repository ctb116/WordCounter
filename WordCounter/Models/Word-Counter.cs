using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    private string _input;
    private string _secondInput;

    public RepeatCounter (string input, string secondInput)
    {
      _input = input;
      _secondInput = secondInput;
    }
    public string GetInput()
    {
      return _input;
    }
    public string GetSecondInput()
    {
      return _secondInput;
    }

    public static string[] SplitSecondInput(string secondInput)
    {
      string[] secondInputList = secondInput.Split(' ');
      return secondInputList;
    }

  }
}
