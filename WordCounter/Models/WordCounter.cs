using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    private string _input;
    private string _content;

    public RepeatCounter (string input, string content)
    {
      _input = input;
      _content = content;
    }
    public string GetInput()
    {
      return _input;
    }
    public string GetContent()
    {
      return _content;
    }

    public int MatchCheck(string input)
    {
      string[] contentList = RepeatCounter.SplitContent(_content);



      int matchCount = 0;
      foreach(string word in contentList)
      {
        if ((word.ToLower()).Equals(input.ToLower()))
        {
        matchCount++;
        }
      }
      return matchCount;
    }

    public static string[] SplitContent(string content)
    {
      string[] contentList = content.Replace(".", " ").Replace("?", " ").Replace("'", " ").Replace("!", " ").Split(' ');
      return contentList;
    }
  }
  class Program
  {
    public static void Main()
    {
      Console.WriteLine("I will check how often a word is used.");
      Console.WriteLine("Enter text.");
      string content = Console.ReadLine();
      Console.WriteLine("Enter the word you want me to check for. Do not include puntuation.");
      string input = Console.ReadLine();

      RepeatCounter checker = new RepeatCounter(input, content);
      Console.WriteLine("Your word '" + input + "' was used " + checker.MatchCheck(input) + " time(s).");
    }
  }
}
