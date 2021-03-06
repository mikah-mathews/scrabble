using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble.Models;

namespace Scrabble.Tests
{
  [TestClass]
  public class WordTests
  {

    [TestMethod]
    public void Word_WordToCharacters_CharacterArray()
    {
      //Arrange
      Word myWord = new Word ("bananas");
      char[] target = {'b', 'a', 'n', 'a', 'n', 'a', 's'};     
      //Act
      char[] result = myWord.WordToCharacters();
      //Assert
      CollectionAssert.AreEqual(result, target);
    }

    [TestMethod]
    public void Word_CharArraytoIntArray_IntArray()
    {
      //Arrange
      Word myWord = new Word ("bananas");
      int[] target = {3, 1, 1, 1, 1, 1, 1};
      //Act
      char[] letterArray = myWord.WordToCharacters();
      int[] result = myWord.CharsToPoints(letterArray);
      //Assert
      CollectionAssert.AreEqual(result, target);
    }

    [TestMethod]
    public void Word_StuffNotInDict_IntArray()
    {
      //Arrange
      Word myWord = new Word ("42");
      int[] target = {0,0};
      //Act
      char[] letterArray = myWord.WordToCharacters();
      int[] result = myWord.CharsToPoints(letterArray);
      //Assert
      CollectionAssert.AreEqual(result, target);
    }

    [TestMethod]
    public void Word_GetTotalPoints_Int()
    {
      //Arrange
      Word myWord = new Word ("bananas");
      int target = 9;
      //Act
      char[] letterArray = myWord.WordToCharacters();
      int[] pointArray = myWord.CharsToPoints(letterArray);
      int result = myWord.GetTotalPoints(pointArray);
      //Assert
      Assert.AreEqual(result, target);
    }


    // [TestMethod]
    // public void Word_GetDoubleLetters_Int()
    // {
    //   //Arrange
    //   Word myWord = new Word ("bananas");
    //   List<int> target = new List<int> {2, 5};
    //   //Act
    //   char[] letterArray = myWord.WordToCharacters();
    //   int[] pointArray = myWord.CharsToPoints(letterArray);
    //   List<int> result = myWord.GetDoubleLetters(pointArray); 
    //   //Assert
    //   CollectionAssert.AreEqual(result, target);
    // }
    // [TestMethod]
    // public void Word_GetDoubled_Int()
    // {
    //  //Arrange
    //   Word myWord = new Word ("bananas");
    //   int target = 18;
    //   //Act
    //   char[] letterArray = myWord.WordToCharacters();
    //   int[] pointArray = myWord.CharsToPoints(letterArray);
    //   bool doubled = myWord.GetDoubled();
    //   int result = myWord.GetTotalPoints(pointArray);
    //   //Assert
    //   Assert.AreEqual(result, target);
      
    // }


  }

}


