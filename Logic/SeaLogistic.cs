using LogisticApp.Entities;

namespace LogisticApp.Logic
{
    public class SeaLogistic : Logistic
    {
        public override ITransport CreateTransport()
        {
            return new Ship();
        }
    }
}
