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
                while (loop.MoveNext())
                {
                    Console.WriteLine(loop.Current);
                }
            }
        }

        public static object TESTModule(object value)
        {
            switch (value.GetType().Name)
            {
                case "Int32":
                    var dataint = (Convert.ToInt32(value));
                    return (dataint >= 1 && dataint <= 4) ? (dataint * 2) :
                                (dataint > 4) ? (dataint * 3) : throw new Exception("Value cannot be less than 1");
                case "Single":
                    var datafloat = (Convert.ToSingle(value));
                    return (datafloat == 1.0f || datafloat == 2.0f) ? 3.0f : value;
                case "String":
                    return value.ToString().ToUpper();
                default:
                    return value;
            }

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Below string values are printed without foreach and for loop");
            QuestionClass.loopwithoutforeachandfor();
            Console.WriteLine("\nBelow code will print TestModule output as per input, point 8, and its demo for input as 2");
            Console.WriteLine(QuestionClass.TESTModule(2));
        }
    }
}
