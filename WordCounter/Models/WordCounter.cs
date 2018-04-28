using System;
using System.Collections.Generic;
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
      inputWord = inputWord.ToLower();
      string[] inputSentenceArr = inputSentence.ToLower().Split();
      foreach(string word in inputSentenceArr)
      {
        if (word == inputWord)
        {
          _wordCount += 1;
        }
      }
      return _wordCount;
    }

    public static string ErrorMessages(string incomplete, string invalid)
    {
      _incomplete = inputIncomplete;
      _invalid = inputInvalid;
      string input = input.Split();
      foreach(string notWord in input)
      {
        if (notWord == input)
        {
          Console.WriteLine("You have not completely filled out both required fields.  Please do so before proceeding.".);
        } else {
          Console.WriteLine("You have not entered a valid input, please make sure you only enter alpha characters.");
        }
      }
    }
    public static string GetIncompleteMsg()
    {
      return _incomplete;
    }

    public static string GetInvalidMsg()
    {
      return _invalid;
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
