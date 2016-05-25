using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JenkinsPOC_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("First Check-in");
        }
    }

    public class Worker
    {
        public bool IsPalindrome(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return false;

            string reversed = "";
            input = input.Trim();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversed += input[i];
            }

            return input.Equals(reversed);
        }
    }
}
