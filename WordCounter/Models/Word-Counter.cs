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

    public int MatchCheck(string input)
    {
      string[] secondInputList = RepeatCounter.SplitSecondInput(_secondInput);
      int matchCount = 0;
      foreach(string word in secondInputList)
      {
        if (word.Equals(input))
        {
        matchCount += matchCount + 1;
        }
      }
      return matchCount;
    }

    public static string[] SplitSecondInput(string secondInput)
    {
      string[] secondInputList = secondInput.Split(' ');
      return secondInputList;
    }

  }
}
