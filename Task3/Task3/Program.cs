using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            //setup
            Single bottleNumber;
            Single weeksBottleNumber;
            Single day;
            Double recyclingCost;

            //input
            bottleNumber = 0;
            day = 0;

            weeksBottleNumber = BottleLoop(ref bottleNumber, ref day);

            recyclingCost = weeksBottleNumber * 0.1;

            Console.WriteLine("Total recycling cost is $" + recyclingCost);

            Console.ReadLine();

            //process

            //output


        }

        private static float BottleLoop(ref float bottleNumber, ref float day)
        {
            float todaysBottleNumber;
            while (day >= 7)
            {
                do
                {
                    Console.WriteLine("How many bottle's were recycled today?");
                } while (!Single.TryParse(Console.ReadLine(), out todaysBottleNumber));

                bottleNumber = bottleNumber + todaysBottleNumber;
                day = day + 1;
            }

            return bottleNumber;
        }
    }
}

