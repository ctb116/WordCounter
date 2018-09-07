using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    private string _input;

    public RepeatCounter (string input)
    {
      _input = input;
    }
    public string GetInput()
    {
      return _input;
    }
  }
}
