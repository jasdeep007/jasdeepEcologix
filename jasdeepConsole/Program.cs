using System;
using System.Collections.Generic;

namespace jasdeepConsole
{
    public static class QuestionClass
    {
        static List<string> NamesList = new List<string>()
        {
            "Jimmy",
            "Jeffrey",
            "John",
        };
        public static void loopwithoutforeachandfor()
        {
            using (var loop = NamesList.GetEnumerator())
            {
                while(loop.MoveNext())
                {
                    Console.WriteLine(loop.Current);
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Below string values are printed without foreach and for loop");
            QuestionClass.loopwithoutforeachandfor();
        }
    }
}
