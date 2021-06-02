namespace LogisticApp.Entities
{
    public class Truck : ITransport
    {
        public string Deliver()
        {
            return "Deliver by road in a box";
        }
    }
}
