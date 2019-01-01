using System;
using System.Collections.Generic;

namespace debugging
{
    class Program
    {
        public static void Main(string[] args)
        {
            var numbers = new List<int>{ 1, 2, 3, 4, 5, 6};
            var smallest = GetSmallests(numbers, 3);

            foreach ( var number in smallests)
                System.Console.WriteLine(number);
                
        }
        public static List<int> GetSmallests(List<int> list, int count )
        {
            var min = GetSmallest(list);
            while (smallest.Count < count)
            {
            smallests.Add(min);
            list.Remove(min);
            }
        }

        return smallest; 

        public static int GetSmallest(List<int> list)
        {
            var min = list[0];
            for ( var i = 1; i < list.Count; i++)
            {
                if ( list[i] > min)
                    min = list[i];
            }
            return min;
        }
        
    }
}
