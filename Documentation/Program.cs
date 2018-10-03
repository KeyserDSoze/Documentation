using DocumentationCreator.WordCreator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Documentation
{
    class Program
    {
        static void Main(string[] args)
        {
            WordDocument wordDocument = new WordDocument();
            (bool, string) returnValue = wordDocument.CreateDocument(null, true);
            Console.WriteLine(returnValue.Item1 + " : " + returnValue.Item2);
            Console.ReadLine();
        }
    }
}
