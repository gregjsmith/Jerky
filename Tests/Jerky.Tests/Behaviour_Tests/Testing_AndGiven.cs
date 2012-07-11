using Jerky.Tests.TestObjects;
using NUnit.Framework;

// ReSharper disable InconsistentNaming
namespace Jerky.Tests.Behaviour_Tests
{
    public class Testing_AndGiven
    {
        private bool _bool;
        private Air _air;
        private Baloon _baloon;

        [Test]
        public void Passing_Arbitrary_objects()
        {
            new Behaviour()
                .Given(1 == 1)
                .AndGiven(_bool = 1 == 2)
                .AndGiven(_air = new Air(), _baloon = new Baloon(_air))
                .Then(_bool == false);
        }
    }
}
// ReSharper restore InconsistentNaming