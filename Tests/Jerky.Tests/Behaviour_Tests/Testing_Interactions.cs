using Jerky.Tests.TestObjects;
using Moq;
using NUnit.Framework;

// ReSharper disable InconsistentNaming
namespace Jerky.Tests.Behaviour_Tests
{
    public class Testing_Interactions
    {
        [Test]
        public void GWT_syntax_can_be_used_to_verify_interaction_between_classes()
        {
            new Behaviour()
                .Given(A,new Mock<IAnotherTestType>())
                .IsSuppliedTo(A_new_TestType)
                .When(Method_one_is_called)
                .Then(MethodThree_on_dependency_Interface_should_be_called_once);
        }

        private void A(Mock<IAnotherTestType> obj)
        {
            _anotherMock = obj;
        }

        private void A_new_TestType()
        {
            _testType = new TestType(_anotherMock.Object);
        }

        private void Method_one_is_called()
        {
            _testType.MethodOne();
        }

        private void MethodThree_on_dependency_Interface_should_be_called_once()
        {
            _anotherMock.Verify(m => m.MethodThree(),Times.Once());
        }

        private ITestType _testType;
        private Mock<IAnotherTestType> _anotherMock;


    }
}
// ReSharper restore InconsistentNaming