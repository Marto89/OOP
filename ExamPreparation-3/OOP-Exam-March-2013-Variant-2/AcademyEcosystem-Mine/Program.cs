using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyEcosystem
{
    class Program
    {
        static Engine GetEngineInstance()
        {
            return new ExtensionEngine();
        }

        static void Main(string[] args)
        {
            Engine engine = GetEngineInstance();
            
            string command = Console.ReadLine();
            while (command != "end")
            {
                engine.ExecuteCommand(command);
                command = Console.ReadLine();
            }
            Console.WriteLine(new string('-',80));
            Console.WriteLine(engine.ToString());
        }
    }
}
