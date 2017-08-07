using FootBallScore.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FootBallScore.Test
{
  [TestClass]
  public class FootBallScoringTest
  {
    [TestMethod]
    public void Get8_8ScoreReturns1_True()
    {
      //Arrange
      FootBallScoring myFootball = new FootBallScoring(8);
      myFootball.SetFewestScoringPlays();

      //Act
      int result = myFootball.Get8();

      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Get7_7ScoreReturns1_True()
    {
      //Arrange
      FootBallScoring myFootball = new FootBallScoring(7);
      myFootball.SetFewestScoringPlays();

      //Act
      int result = myFootball.Get7();

      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Get6_6ScoreReturns1_True()
    {
      //Arrange
      FootBallScoring myFootball = new FootBallScoring(6);
      myFootball.SetFewestScoringPlays();

      //Act
      int result = myFootball.Get6();

      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Get3_3ScoreReturns1_True()
    {
      //Arrange
      FootBallScoring myFootball = new FootBallScoring(3);
      myFootball.SetFewestScoringPlays();

      //Act
      int result = myFootball.GetFG();

      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Get2_2ScoreReturns1_True()
    {
      //Arrange
      FootBallScoring myFootball = new FootBallScoring(2);
      myFootball.SetFewestScoringPlays();

      //Act
      int result = myFootball.GetSafety();

      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void AllGets_ScoreOf52ReturnValues_True()
    {
      //Arrange
      FootBallScoring myFootball = new FootBallScoring(52);
      myFootball.SetFewestScoringPlays();

      //Act
      int eight = myFootball.Get8();
      int seven = myFootball.Get7();
      int six = myFootball.Get6();
      int three = myFootball.GetFG();
      int two = myFootball.GetSafety();

      //Assert
      Assert.AreEqual(6, eight);
      Assert.AreEqual(0, seven);
      Assert.AreEqual(0, six);
      Assert.AreEqual(0, three);
      Assert.AreEqual(2, two);
    }

    [TestMethod]
    public void CheckGets_ScoreOf9ReturnsValues_True()
    {
      FootBallScoring myFootball = new FootBallScoring(9);
      myFootball.SetFewestScoringPlays();

      //Act
      int seven = myFootball.Get7();
      int two = myFootball.GetSafety();

      //Assert
      Assert.AreEqual(1, seven);
      Assert.AreEqual(1, two);
    }
  }
}
