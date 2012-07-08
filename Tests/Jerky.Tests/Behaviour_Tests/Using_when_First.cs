using Jerky.Tests.TestObjects;
using NUnit.Framework;

// ReSharper disable InconsistentNaming
namespace Jerky.Tests.Behaviour_Tests
{
    public class Testing_When_Step_First 
    {
        [Test]
        public void Simple_usage_of_when_step_first()
        {
            new Behaviour()
                .When(Creating_a_new_TestType)
                .Then(The_SomeInt_Property_will_be, 1);
        }

        [Test]
        public void When_Step_first_with_argument()
        {
            new Behaviour()
                .When(Creating_a, new TestType())
                .Then(The_SomeInt_property_should_be, 1);
        }



        private void Creating_a(TestType obj)
        {
            _testType = obj;
        }

        private void The_SomeInt_property_should_be(int obj)
        {
            Assert.AreEqual(1, _testType.SomeInt);
        }

        private void Creating_a_new_TestType()
        {
            _testType = new TestType();
        }

        private void The_SomeInt_Property_will_be(int obj)
        {
            Assert.AreEqual(_testType.SomeInt, obj);
        }

        private ITestType _testType;
    }
}
// ReSharper restore InconsistentNaming