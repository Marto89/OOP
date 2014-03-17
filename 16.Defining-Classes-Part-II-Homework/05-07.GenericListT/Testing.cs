using System;


namespace _05_07.GenericListT
{
    class Testing
    {
        static void Main()
        {
            GenericList<string> test = new GenericList<string>(4);
            test.AddElement("black");
            test.AddElement("white");
            test.AddElement("yellow");
            test.AddElement("green");
            test.AddElement("Martin");
            Console.WriteLine(test.AccessElement(3));
            test.InsertAtPosition("blue", 2);
            test.RemoveElementAt(0);
            Console.WriteLine(test.FindingElementByValue("white"));
            Console.WriteLine(test.Min());
            Console.WriteLine(test.ToString());

            GenericList<int> test2 = new GenericList<int>(4);
            test2.AddElement(4);
            test2.AddElement(3);
            test2.AddElement(5);
            test2.AddElement(7);
            test2.AddElement(10);  
            Console.WriteLine(test2.Max());
            Console.WriteLine(test2.ToString());
        }
    }
}
