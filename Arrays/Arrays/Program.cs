using System;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] luckyNumbers = {4, 8, 15, 16, 23, 42}; //<-- elements inside of array 
            string[] friends = new string[5]; //friends array can hold 5 values
            friends[0] = "Jim"; //individually populate element in array
            friends[1] = "Kelly";
            
            luckyNumbers[1] = 900;
            
            Console.WriteLine(luckyNumbers[1]);
            
            Console.ReadLine();
        }
    }
}