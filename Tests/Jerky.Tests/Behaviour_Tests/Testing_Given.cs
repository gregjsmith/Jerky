using Jerky.Tests.TestObjects;
using NUnit.Framework;

namespace Jerky.Tests.Behaviour_Tests
{
// ReSharper disable InconsistentNaming
    public class Testing_Given
    {
        private Baloon _baloon;

        [Test]
        public void Passing_an_object_as_argument()
        {
            new Behaviour()
                .Given(_baloon = new Baloon())
                .When(() => _baloon.Pop())
                .Then(_baloon.State == Baloon.InflationState.Popped);
        }
    }
}
// ReSharper restore InconsistentNaming