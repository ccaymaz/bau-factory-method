using LogisticApp.Entities;

namespace LogisticApp.Logic
{
    public class RoadLogistic : Logistic
    {
        public override ITransport CreateTransport()
        {
            return new Truck();
        }
    }
}