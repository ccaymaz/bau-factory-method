using LogisticApp.Entities;
using System;

namespace LogisticApp.Logic
{
    public abstract class Logistic
    {
        public abstract ITransport CreateTransport();

        public void PlanDelivery()
        {
            var transport = CreateTransport();

            Console.WriteLine(transport.Deliver());
        }
    }
}