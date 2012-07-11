using Jerky.Tests.Behaviour_Tests;

namespace Jerky.Tests.TestObjects
{
    public class Baloon
    {
        public Baloon(Air air)
        {
            if (air != null)
            {
                State = InflationState.Inflated;
            }
            
        }

        public Baloon()
        {
            
        }
        public enum InflationState
        {
            Popped,
            Inflated
        }

        public void Pop()
        {
            State = InflationState.Popped;
        }

        public InflationState State { get; set; }

        public void Inflate()
        {
            if (State == InflationState.Inflated)
            {
                throw new AlreadyInflatedException("The baloon is already inflated");
            }
        }
    }
}