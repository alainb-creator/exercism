using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    public List<int> highScoresList;    
    public HighScores(List<int> list)
    {
        // throw new NotImplementedException();
        highScoresList = list;
    }

    public List<int> Scores()
    {
        return highScoresList;
       
    }

    public int Latest()
    {
        return highScoresList.Last();
    }

    public int PersonalBest()
    {
        return highScoresList.Max();
    }

    public List<int> PersonalTopThree()
    {
        return highScoresList.OrderByDescending(i => i).Take(3).ToList();
    }
}