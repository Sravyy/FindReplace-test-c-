using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using FindReplace;

namespace FindReplace.Tests
{

  [TestClass]
  public class FindReplaceTests
  {
    [TestMethod]
    public void IsWinner_ReturnsPlayer1_string()
    {
      //Arrange
      RockPS newWinner = new RockPS("S","P");
      var output = "Player1 Wins";


      //Act
      string result = newWinner.IsWinner();

      //Assert
      Assert.AreEqual(output, result);

    }
    [TestMethod]
    public void IsWinner_ReturnsPlayer2_string()
    {
      //Arrange
      RockPS newWinner = new RockPS("P","S");
      var output = "Player2 Wins";


      //Act
      string result = newWinner.IsWinner();

      //Assert
      Assert.AreEqual(output, result);

    }
    [TestMethod]
    public void Draw_NoOneWins_string()
    {
      //Arrange
      RockPS newWinner = new RockPS("P","P");
      var output = "Draw";


      //Act
      string result = newWinner.IsWinner();

      //Assert
      Assert.AreEqual(output, result);

    }

    }
  }
