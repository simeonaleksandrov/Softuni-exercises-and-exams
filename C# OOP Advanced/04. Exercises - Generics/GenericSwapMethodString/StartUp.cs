﻿namespace GenericSwapMethodString
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static void Main(string[] args)
        {
            var boxes = new List<Box<string>>();

            int numberOfLines = int.Parse(Console.ReadLine());

            for (int counter = 0; counter < numberOfLines; counter++)
            {
                string value = Console.ReadLine();
                boxes.Add(new Box<string>(value));
            }

            int[] indixes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Swap(boxes, indixes[0], indixes[1]);

            foreach (var box in boxes)
            {
                Console.WriteLine(box);
            }
        }

        static void Swap<T>(IList<Box<T>> list, int index1, int index2)
        {
            Box<T> tempBox = list[index1];
            list[index1] = list[index2];
            list[index2] = tempBox;
        }
    }
}