using System;

namespace ReturnStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int cubedNumber = cube(5);
            Console.WriteLine(cubedNumber);
            
            Console.ReadLine();
        }

        static int cube(int num) // <--specify parameter to return num cubed
        {
            int result = num * num * num;
            return result;
        }
    }
}