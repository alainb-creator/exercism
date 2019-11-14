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
        throw new NotImplementedException();
    }

    public int Latest()
    {
        throw new NotImplementedException();
    }

    public int PersonalBest()
    {
        throw new NotImplementedException();
    }

    public List<int> PersonalTopThree()
    {
        // throw new NotImplementedException();
        return highScoresList.OrderByDescending(i => i).Take(3).ToList(); // OrderByDescending tri dans l'ordre décroissant. 
        //Take Retourne un nombre spécifié d'éléments contigus à partir du début d'une séquence. 
    }
}