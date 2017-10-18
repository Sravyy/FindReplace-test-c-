using System;
using System.Collections.Generic;

namespace FindReplace
{
  public class FindReplace
  {
    private string _p1;
    private string _p2;

    public RockPS(string p1, string p2)
    {
      _p1 = p1;
      _p2 = p2;
    }

    public string GetP1()
    {
      return _p1;
    }
    public string GetP2()
    {
      return _p2;
    }

    public string IsWinner()
    {
      string[] result = {"Player1 Wins", "Player2 Wins", "Draw"};
      string[] input = {"R", "P", "S"};

      if((_p1 == input[0] && _p2 == input[2]) || (_p2 == input[0] && _p1 == input[1]) || (_p2 == input[1] && _p1 == input[2]))
      {
        return result[0];
      }
      else if((_p1 == input[0] && _p2 == input[1]) || (_p1 == input[1] && _p2 == input[2]) || (_p2 == input[0] && _p1 == input[2]))
      {
        return result[1];
      }
      else
      {
        return result[2];
      }
    }
  }
}
