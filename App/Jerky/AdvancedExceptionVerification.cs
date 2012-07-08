using System;
using NUnit.Framework;

namespace Jerky
{
    public class AdvancedExceptionVerification : ExceptionVerification
    {
        public AdvancedExceptionVerification(Exception exception, Type type) : base(exception, type)
        {}

        public void WithMessage(string message)
        {
            Assert.That(Exception.Message.Contains(message));
        }
    }
}