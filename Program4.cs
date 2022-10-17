using System;

namespace DateModifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First Date:");
            int[]firstDate=Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            Console.WriteLine("Second Date:");
            int[] secondDate = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int totalday1 = 0;
            int totalday2 = 0;

            Date date = new Date(firstDate[0], firstDate[1], firstDate[2], totalday1);
            Date date2 = new Date(secondDate[0], secondDate[1], secondDate[2], totalday2);

            int total = date.Dating();
            int total2 =date2.Dating();

            if(total2 < total)
            {
                Console.WriteLine("Difference: " + (total - total2));
            }
            else
            {
                Console.WriteLine("Difference: " + (total2 - total));
            }
            
            
        }
    }
}