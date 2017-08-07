using System;

namespace FootBallScore.Models
{
  public class FootBallScoring
  {
    private int _score;
    private int _8pointTD;
    private int _7pointTD;
    private int _6pointTD;
    private int _FG;
    private int _safety;

    public FootBallScoring(int score)
    {
      _score = score;
      _8pointTD = 0;
      _7pointTD = 0;
      _6pointTD = 0;
      _FG = 0;
      _safety = 0;
    }

    public void SetFewestScoringPlays()
    {
      int pointsRemaining = _score;

      if(_score % 8 != 1)
      {
        _8pointTD = _score / 8;
        pointsRemaining = pointsRemaining % 8;
      }

      if(pointsRemaining % 7 != 1)
      {
        _7pointTD = pointsRemaining / 7;
        pointsRemaining = pointsRemaining % 7;
      }

      if(pointsRemaining % 6 != 1)
      {
        _6pointTD = pointsRemaining / 6;
        pointsRemaining = pointsRemaining % 6;
      }

      if(pointsRemaining % 3 != 1)
      {
        _FG = pointsRemaining / 3;
        pointsRemaining = pointsRemaining % 3;
      }

      _safety = pointsRemaining / 2;
      pointsRemaining = pointsRemaining % 2;
    }

    public int Get8()
    {
      return _8pointTD;
    }

    public int Get7()
    {
      return _7pointTD;
    }

    public int Get6()
    {
      return _6pointTD;
    }

    public int GetFG()
    {
      return _FG;
    }

    public int GetSafety()
    {
      return _safety;
    }
  }
}
