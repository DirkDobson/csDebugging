﻿using System;
using System.Collections.Generic;

namespace debugging
{
    class Program
    {
        public static void Main(string[] args)
        {
            var numbers = new List<int>{ 1, 2, 3, 4, 5, 6};
            var smallest = GetSmallests(numbers, 3);

            foreach ( var number in smallest)
                Console.WriteLine(number);
                
        }
        public static List<int> GetSmallests(List<int> list, int count )
        {
            var buffer = new List<int>(list);
            var smallests = new List<int>();

            while (smallests.Count < count)
            {
            var min = GetSmallest(buffer);
            smallests.Add(min);
            buffer.Remove(min);
            }

            return smallests; 
        }


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
