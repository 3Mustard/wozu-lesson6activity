using System;
using nameSpace1 = myNamespace;
using nameSpace2 = aUniqueName;

namespace lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            nameSpace1.AnotherProgram.PrintText();
            nameSpace2.AUniqueClass.PrintText();
        }
    }
}
