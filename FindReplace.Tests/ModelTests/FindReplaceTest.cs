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
    public void FindAndReplace_ReplaceString_string()
    {
      //Arrange
      FindReplace newString = new FindReplace("I am walking my cat to the cathedral","cat", "dog");
      var output = "I am walking my dog to the doghedral";


      //Act
      string result = newString.FindAndReplace();

      //Assert
      Assert.AreEqual(output, result);

    }
  }
}
