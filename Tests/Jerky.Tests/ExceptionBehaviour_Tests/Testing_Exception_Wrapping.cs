using System;
using Jerky.Tests.TestObjects;
using NUnit.Framework;

// ReSharper disable InconsistentNaming
namespace Jerky.Tests.ExceptionBehaviour_Tests
{
    public class Testing_Exception_Wrapping
    {
        [Test]
        public void Can_capture_wrapped_exception_with_message()
        {
            new ExceptionBehaviour()
                .When(Some_arbitrary_action_fails)
                .TheThrownException()
                .IsWrappedInExceptionOfType(typeof (InvalidOperationException))
                .WithMessage("An exception was Wrapped");
        }

        [Test]
        public void Can_capture_type_of_both_inner_and_outer_Exceptions()
        {
            new ExceptionBehaviour()
                .When(Something_happens)
                .AnExceptionOfType(typeof(ArgumentNullException))
                .IsWrappedInExceptionOfType(typeof(InvalidOperationException));
        }


        private void Some_arbitrary_action_fails()
        {
            new ExceptionThrower();
        }

       

        private void Something_happens()
        {
            new ExceptionThrower();
        }
    }
}
// ReSharper restore InconsistentNaming