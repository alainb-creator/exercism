using System;
using System.Collections.Generic;

public class SpaceAge
{

   private static Dictionary<string, double> spaceage;
    int Seconds;
    static SpaceAge()
    {
        spaceage = new Dictionary<string, double>();

        spaceage["Earth"] = 1;
        spaceage["Mercury"] = 0.2408467;
        spaceage["Venus"] = 0.61519726;
        spaceage["Mars"] = 1.8808158;
        spaceage["Jupiter"] = 11.862615;
        spaceage["Saturn"] = 29.447498;
        spaceage["Uranus"] = 84.016846;
        spaceage["Neptune"] = 164.79132;

    }

    private double _secondForOneYear = 31557600;

    public SpaceAge(int seconds)
    {
        Seconds = seconds;
    }
   

    public double OnEarth()
    {
        //throw new NotImplementedException("You need to implement this function.");

        return Seconds / _secondForOneYear;
    }

    public double OnMercury()
    {
        // throw new NotImplementedException("You need to implement this function.");
        return On("Mercury");
    }

    public double OnVenus()
    {
        //throw new NotImplementedException("You need to implement this function.");
        return On("Venus");
    }

    public double OnMars()
    {
        // throw new NotImplementedException("You need to implement this function.");
        return On("Mars");
    }

    public double OnJupiter()
    {
        return On("Jupiter");
    }

    public double OnSaturn()
    {
        return On("Saturn");
    }

    public double OnUranus()
    {
        return On("Uranus");
    }

    public double OnNeptune()
    {
        return On("Neptune");
    }
    private double On(string planet)
    {
        return Math.Round(Seconds / (spaceage[planet] * _secondForOneYear), 2);
    }
}