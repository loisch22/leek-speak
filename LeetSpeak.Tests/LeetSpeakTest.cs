using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using LeetSpeak.Models;
using System;

namespace LeetSpeak.Tests
{
  [TestClass]
  public class LeetSpeakTest : IDisposable
  {
    [TestMethod]
    public void ConvertToLeet_ReturnWord_Cap()
    {
      LeetSpeakLang testLeetSpeak = new LeetSpeakLang("cap");
      List<string> expected = new List<string>{"cap"};
      List<string> actual = testLeetSpeak.ConvertToLeet();
      CollectionAssert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void ConvertToLeet_ConvertE_Cod3()
    {
      LeetSpeakLang testLeetSpeak = new LeetSpeakLang("cde");
      List<string> expected = new List<string>{"cd3"};
      List<string> actual = testLeetSpeak.ConvertToLeet();
      CollectionAssert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void ConvertToLeet_ConvertO_C0d3()
    {
      LeetSpeakLang testLeetSpeak = new LeetSpeakLang("code");
      List<string> expected = new List<string>{"c0d3"};
      List<string> actual = testLeetSpeak.ConvertToLeet();
      CollectionAssert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void ConvertToLeet_Convertl_1amp()
    {
      LeetSpeakLang testLeetSpeak = new LeetSpeakLang("lamp");
      List<string> expected = new List<string>{"1amp"};
      List<string> actual = testLeetSpeak.ConvertToLeet();
      CollectionAssert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void ConvertToLeet_ConvertT_1337()
    {
      LeetSpeakLang testLeetSpeak = new LeetSpeakLang("leet");
      List<string> expected = new List<string>{"1337"};
      List<string> actual = testLeetSpeak.ConvertToLeet();
      CollectionAssert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void ConvertToLeet_ConvertS_s0zzy()
    {
      LeetSpeakLang testLeetSpeak = new LeetSpeakLang("sossy");
      List<string> expected = new List<string>{"s0zzy"};
      expected.ForEach(Console.WriteLine);
      List<string> actual = testLeetSpeak.ConvertToLeet();
      actual.ForEach(Console.WriteLine);
      CollectionAssert.AreEqual(expected, actual);
    }

    public void Dispose()
    {
      LeetSpeakLang.ClearAll();
    }
  }
}
