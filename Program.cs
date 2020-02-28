using System;

namespace KM_case
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {


                Console.Write("Enter kilometres: ");
                double km = double.Parse(Console.ReadLine());
                Console.Write("Enter day or night: ");
                string time = Console.ReadLine();
                double a = 0.09;
                double td = 0.79;
                double tn = 0.90;
                double v = 0.06;
                if (km <= 19 && time == "day")
                {
                    Console.WriteLine("S taksi: " + (0.70 + (km * td)) + " lv");
                }
                else
                {
                    if (km <= 19 && time == "night")
                    {
                        Console.WriteLine("S taksi: " + (0.70 + (km * tn)) + " lv");
                    }
                }
                if (km > 19 && km < 100 && time == "day")
                {
                    Console.WriteLine("S avtobus shte e nai-evtino: " + (km * a) + " lv");
                    Console.WriteLine("S taksi shte e: " + (0.70 + (km * td)) + " lv");
                }
                else
                {
                    if (km > 19 && km < 100 && time == "night")
                    {
                        Console.WriteLine("S avtobus shte e nai-evtino: " + (km * a) + " lv");
                        Console.WriteLine("S taksi shte e: " + (0.70 + (km * tn)) + " lv");
                    }

                }
                if (km >= 100 && time == "day")
                {
                    Console.WriteLine("S vlak shte e nai-evtino: " + (km * v) + " lv");
                    Console.WriteLine("S avtobus shte e: " + (km * a) + " lv");
                    Console.WriteLine("S taksi shte e: " + (0.70 + (km * td)) + " lv");
                }
                else
                {
                    if (km >= 100 && time == "night")
                    {
                        Console.WriteLine("S vlak shte e nai-evtino: " + (km * v) + " lv");
                        Console.WriteLine("S avtobus shte e: " + (km * a) + " lv");
                        Console.WriteLine("S taksi shte e: " + (0.70 + (km * tn)) + " lv");
                    }
                }
            }
            catch
            {
                Console.WriteLine("Error, incorect data");
            }
        }
    }
}
