using System;
using System.Collections.Generic;

namespace LeetSpeak.Models
{
  public class LeetSpeakLang
  {
    private string _userString;
    private static List<string> _newLeetSpeak = new List<string> {};
    private static List<string> _outputLeetSpeak = new List<string> {};

    public LeetSpeakLang(string userString)
    {
      _userString = userString;
      _newLeetSpeak.Add(_userString);
    }

    public List<string> ConvertToLeet()
    {
      char[] wordArray = _newLeetSpeak[0].ToCharArray();
      for(int i = 0; i < wordArray.Length; i++)
      {
        if (wordArray[i] == 'o')
        {
          wordArray[i] = '0';
        }
        else if (wordArray[i] == 'e')
        {
          wordArray[i] = '3';
        }
      }
      string result = string.Join("", wordArray);
       _outputLeetSpeak.Add(result);
       return _outputLeetSpeak;
    }
    public static void ClearAll()
    {
      _newLeetSpeak.Clear();
      _outputLeetSpeak.Clear();
    }
  }
}
