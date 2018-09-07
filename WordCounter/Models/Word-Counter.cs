using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    private string _input;
    private List<string> _inputList;

    public RepeatCounter (string input, List<string> inputList)
    {
      _input = input;
      _inputList = inputList;
    }
    public string GetInput()
    {
      return _input;
    }
    public List<string> GetInputList()
    {
      return _inputList;
    }
  }
}
