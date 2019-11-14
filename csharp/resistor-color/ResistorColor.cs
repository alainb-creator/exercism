using System;
using System.Collections.Generic;
using System.Linq;

public static class ResistorColor
{
    private static Dictionary<string, int> resistColorDic;

    static ResistorColor()
    {
        resistColorDic = new Dictionary<string, int>();

        resistColorDic["black"] = 0;
        resistColorDic["brown"] = 1;
        resistColorDic["red"] = 2;
        resistColorDic["orange"] = 3;
        resistColorDic["yellow"] = 4;
        resistColorDic["green"] = 5;
        resistColorDic["blue"] = 6;
        resistColorDic["violet"] = 7;
        resistColorDic["grey"] = 8;
        resistColorDic["white"] = 9;
    }
    public static int ColorCode(string color)
    {
        // throw new NotImplementedException("You need to implement this function.");
        return resistColorDic[color];


    }

    public static string[] Colors()
    {
        // throw new NotImplementedException("You need to implement this function.");
        return resistColorDic.Keys.ToArray();
    }
}