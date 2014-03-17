using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

class GsmTest
{
    static void ListTest()
    {
        Gsm test1 = new Gsm("N95", "Nokia", 500, "Martin",
            new Battery("Nokia", new TimeSpan(48,0,0), new TimeSpan(36,0,0), BatteryType.LiIon),
            new Display(5, 1500000));
        Gsm test2 = new Gsm("Galaxy 4S", "Samsung", 1400, "Miro",
                            new Battery("Samsung", new TimeSpan(52,0,0), new TimeSpan(48,0,0), BatteryType.LiIon),
                            new Display(10, 15000000));
        Gsm[] Gsms = new Gsm[] { test1, test2 };
        foreach (var item in Gsms)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine(Gsm.IPhone4S);
    }
    static void CallHistoryTest()
    {
        Gsm testCall = new Gsm("C7", "Nokia");

        Call firstCall = new Call("0888888888", 120);
        Call secondCall = new Call("0877777777", 55);
        Call thirdCall = new Call("0899999999", 255);

        testCall.AddCall(firstCall);
        testCall.AddCall(secondCall);
        testCall.AddCall(thirdCall);

        testCall.ShowCallHistory();

        Console.WriteLine("The price is: {0:c}", testCall.PriceOfCalls());

        testCall.DeleteCall(3);

        Console.WriteLine("The price is: {0:c}", testCall.PriceOfCalls());

        testCall.ClearHistory();

        testCall.ShowCallHistory();
    }
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.GetEncoding("Cyrillic");
        GsmTest.ListTest();

        GsmTest.CallHistoryTest();
    }
}
