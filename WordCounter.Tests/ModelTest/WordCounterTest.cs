using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Test
{
  [TestClass]
  public class WordCounterTest : IDisposable
  {
    public void Dispose()
    {
      RepeatCounter.ClearAll();
    }

    [TestMethod]
    public void InputComplete_IsWordAndSentenceComplete_True()
    {
      string TestWord = "feast";
      string TestSentence = " ";
      string Result = "You have not completely filled out both required fields.  Please do so before proceeding.";
      string Counter = RepeatCounter.WordCount(TestWord, TestSentence);
      //if false, return result instead of true
      Assert.AreEqual(Result, Counter);
    }

    [TestMethod]
    public void InputValid_AreInputsAlpha_True()
    {
      string TestWord = "f00d";
      string TestSentence = "we have food for all";
      string Result = "You have not entered a valid input, please make sure you only enter alpha characters.";
      string Counter = RepeatCounter.WordCount(TestWord, TestSentence);
      //if false, return result instead of true
      Assert.AreEqual(Result, Counter);
    }

    [TestMethod]
    public void InputLetterMatch_CountedLetterInSentence_Int()
    {
      string TestWord = "z";
      string TestSentence = "people who study zoology";
      int Result = 1;
      int Counter = RepeatCounter.WordCount(TestWord, TestSentence);
      Assert.AreEqual(Result, Counter);
    }

    [TestMethod]
    public void InputPartialWord_CountPartialStringInSentence_Int()
    {
      string TestWord = "abacus";
      string TestSentence = "looked for contraband on shipments";
      string Result = 1;
      int Counter = RepeatCounter.WordCount(TestWord, TestSentence);
      Assert.AreEqual(Result, Counter);
    }

    [TestMethod]
    public void InputFullWord_CountFullStringInSentence_Int()
    {
      string TestWord = "soccer";
      string TestSentence = "I like to be midfield offense when I do play soccer";
      string Result = 1;
      int Counter = RepeatCounter.WordCount(TestWord, TestSentence);
      Assert.AreEqual(Result, Counter);
    }

    [TestMethod]
    public void InputFullWord_CountOccurenceOfFullStringInSentence_Int()
    {
      string TestWord = "water";
      string TestSentence = "any water sport will do, especially Waterpolo.";
      string Result = 2;
      int Counter = RepeatCounter.WordCount(TestWord, TestSentence);
      Assert.AreEqual(Result, Counter);
    }

  }
}
