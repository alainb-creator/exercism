using System;

public static class Leap
{
    public static bool IsLeapYear(int year)
    {
        //throw new NotImplementedException("You need to implement this function.");

       // return ((year & 4) == 0) && ((year % 100 != 0) || (year % 400 == 0)) ne foncionne pas;
        return (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
    }
} 