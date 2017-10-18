using System;
using System.Collections.Generic;



namespace FindReplace
{
  public class FindReplace
  {
    private string _str;
    private string _word;
    private string _replace;

    public FindReplace(string str, string word, string replace)
    {
      _str = str;
      _word = word;
      _replace = replace;
    }

    public string GetStr()
    {
      return _str;
    }
    public string GetWord()
    {
      return _word;
    }
    public string GetReplace()
    {
      return _replace;
    }

    public string FindAndReplace()
    {
      foreach(char word in _str)
      {
         _str = _str.Replace(_word, _replace);
      }
      return _str;
    }
  }
}
