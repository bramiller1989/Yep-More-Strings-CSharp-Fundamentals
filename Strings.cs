using System;
using System.Collections.Generic;

namespace YepMoreStrings
{
    public class Strings
    {
        public void Exercise1()
        {
            Console.WriteLine("Enter a few numbers (eg 1-2-3-4): ");
            var input = Console.ReadLine();

            var numbers = new List<int>();
            foreach (var number in input.Split('-'))
                numbers.Add(Convert.ToInt32(number));

            numbers.Sort();

            var isConsecutive = true;
            for (var i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] == numbers[i - 1] + 1) continue;
                isConsecutive = false;
                break;
            }

            var message = isConsecutive ? "Consecutive" : "Not Consecutive";
            Console.WriteLine(message);
        }

        public void Exercise2()
        {
            throw new System.NotImplementedException();
        }

        public void Exercise3()
        {
            throw new System.NotImplementedException();
        }

        public void Exercise4()
        {
            throw new System.NotImplementedException();
        }

        public void Exercise5()
        {
            throw new System.NotImplementedException();
        }
    }
}