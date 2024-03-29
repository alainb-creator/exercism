﻿using System;
using System.Collections.Generic;

public static class TwoFer
{
    // In order to get the tests running, first you need to make sure the Speak method 
    // can be called both without any arguments and also by passing one string argument.

    //Overloading -- surcharge
    //On definit deux fois une meme fonction dans une classe avec des arguments differents
    // les arguments de la fonction doivent etre differents f(int a), f(string a) ca marche
    // f(string str, int a) et f(int a, string str) ca marche car l'ordre est different
    public static string Speak(string Name = "you")
    {
        return $"One for {Name}, one for me.";
    }
}
