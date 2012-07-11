using Jerky.Tests.TestObjects;
using NUnit.Framework;

namespace Jerky.Tests.Behaviour_Tests
{
// ReSharper disable InconsistentNaming
    public class Testing_Given
    {
        private Baloon _baloon;
        private Air _air;

        [Test]
        public void Passing_an_object_as_argument()
        {
            new Behaviour()
                .Given(_baloon = new Baloon())
                .When(() => _baloon.Pop())
                .Then(_baloon.State == Baloon.InflationState.Popped);
        }

        [Test]
        public void Passing_more_than_one_object()
        {
            new Behaviour()
                .Given(_air = new Air(), _baloon = new Baloon(_air))
                .Then(_baloon.State == Baloon.InflationState.Inflated);
        }



    }
}
// ReSharper restore InconsistentNaming