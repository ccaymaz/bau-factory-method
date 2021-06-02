using LogisticApp.Logic;
using System;

namespace LogisticAoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====================================================");
            Console.WriteLine("==                  ABC Logistic                  ==");
            Console.WriteLine("====================================================");
            Console.WriteLine(Environment.NewLine);


            Console.WriteLine("Road logistic factory");
            var roadLogistic = new RoadLogistic();
            roadLogistic.PlanDelivery();


            Console.WriteLine(Environment.NewLine);


            Console.WriteLine("Sea logistic factory");
            var seaLogistic = new SeaLogistic();
            seaLogistic.PlanDelivery();


            Console.ReadKey();
        }
    }
}
