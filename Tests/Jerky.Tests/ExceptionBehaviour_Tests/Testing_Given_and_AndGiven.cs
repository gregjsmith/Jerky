using Jerky.Tests.TestObjects;
using NUnit.Framework;

// ReSharper disable InconsistentNaming
namespace Jerky.Tests.ExceptionBehaviour_Tests
{
    public class Testing_Given_and_AndGiven
    {
        [Test]
        public void Passing_Arbitrary_objects()
        {
            new ExceptionBehaviour()
                .Given(_air = new Air())
                .AndGiven(_baloon = new Baloon(_air))
                .When(() => _baloon.Inflate())
                .AnExceptionOfType(typeof(AlreadyInflatedException))
                .IsThrownWithMessage("The baloon is already inflated");
        }

        private Air _air;
        private Baloon _baloon;
    }
}
// ReSharper restore InconsistentNaming