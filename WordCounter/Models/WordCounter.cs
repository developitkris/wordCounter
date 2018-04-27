using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;

namespace WordCounterProgram.Models
{
  public class RepeatCounter
  {
    private static int _wordCount;
    private static string _inputWord;
    private static string _inputSentence;
    private static string _incomplete;
    private static string _invalid;

    public static int WordCount(string inputWord, string inputSentence, string inputIncomplete, string inputInvalid)
    {
      _inputWord = inputWord;
      _inputSentence = inputSentence;
      _incomplete = inputIncomplete;
      _invalid = inputInvalid;
      inputWord = inputWord.ToLower();
      string[] inputSentenceArr = inputSentence.ToLower().Split();
      foreach(string word in inputSentenceArr)
      {
        if (word == inputWord)
        {
          _wordCount += 1;
        }
        else if (word.Contains(inputWord.Split))
        {
          _wordCount += 1;
        }
      }
      return _wordCount;
    }

    public static int GetWordCount()
    {
      return _wordCount;
    }

    public static string GetInputWord()
    {
      return _inputWord;
    }

    public static string GetInputSentence()
    {
      return _inputSentence;
    }

    public static void ClearAll()
    {
      _wordCount = 0;
    }
  }
}
