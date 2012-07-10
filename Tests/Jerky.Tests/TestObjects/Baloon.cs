namespace Jerky.Tests.TestObjects
{
    public class Baloon
    {
        public enum InflationState
        {
            Popped
        }

        public void Pop()
        {
            State = InflationState.Popped;
        }

        public InflationState State { get; set; }
    }
}