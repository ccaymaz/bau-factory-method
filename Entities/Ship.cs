﻿namespace LogisticApp.Entities
{
    public class Ship : ITransport
    {
        public string Deliver()
        {
            return "Deliver by sea in a container";
        }
    }
}
