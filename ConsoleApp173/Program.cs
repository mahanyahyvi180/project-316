using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApp173
{
    class Program
    {
        static void Main(string[] args)
        {
            string testString = "regular expressions are sometimes called regex or regexp";
            Console.WriteLine("The test string is\n \"{0}\"", testString);
            Console.Write("Math 'e' i  the test string:");

            Regex expression = new Regex("e");
            Console.WriteLine(expression.Match(testString));
            Console.Write("Match every 'e' in the test string:");

            foreach (var myMatch in expression.Matches(testString))
                Console.Write("{0}", myMatch);

            Console.Write("\nMatch \"regex\"in the test string:");

            foreach(var myMatch in  Regex.Matches(testString,"regex"))
                    Console.Write("{0}", myMatch);

            Console.Write("\nMatch \"regex\"or\"regexp\"using an optional 'p':");

            foreach (var myMatch in Regex.Matches(testString, "regexp?"))
                Console.Write("{0}", myMatch);

            expression = new Regex("(c|h)at");
            Console.WriteLine("\n\"hat cat\"matches{0},but\"cat hat\"matches{1}", expression.Match("hat cat"), expression.Match("cat hat"));

            Console.ReadLine();
        }
    }
}
