using System;
using System.Collections.Generic;

namespace Collection
{
    class Program
    {

        static void Main(string[] args)
        {
            var list = new List<string> { "Martin" };
            var firtThingInList = list[0];

            var spouses = new Dictionary<MiniFigure, MiniFigure>();

            var todd = new MiniFigure();
            var toddSpouse = new MiniFigure();
            spouses.Add(todd, toddSpouse); // Yay, we performed a minifigure wedding!!

            var spouseKeys = spouses.Keys;

            var success = spouses.TryGetValue(todd, out MiniFigure toddRealSpouse);
            var canParse = Int32.TryParse("42", out var realInt);

            var tuple = new Tuple<string, int, MiniFigure>("Martin", 42, todd);

            var name = tuple.Item1;
            var number = tuple.Item2;

            var martinExists = list.Exists(x => x == "Martin") && list.Capacity > 0 || list.Count > 0;

            if (martinExists)
            {
                DoSomething();
            }
        }

        static void DoSomething()
        {
            // Do logical
        }
    }

    public class MiniFigure
    {
        // pretend there's properties and methods here
    }
}
