using System;

class NullValues
{
    static void Main()
    {
        int? value = null;
        float? fValue = null;
        value = 4;
        fValue = null + 3;
        Console.WriteLine("{0}\n{1}", value, fValue);
    }
}

