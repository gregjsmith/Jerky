using System;
using NUnit.Framework;

namespace Jerky
{
    public class ExceptionVerification
    {
        protected readonly Exception Exception;
        private Type _type;

        public ExceptionVerification(Exception exception, Type type)
        {
            Exception = exception;
            _type = type;
        }

        public AdvancedExceptionVerification IsWrappedInExceptionOfType(Type type)
        {
            return new AdvancedExceptionVerification(Exception, type);
        }

        public void IsThrown()
        {
            Assert.That(Exception, Is.Not.Null);
            Assert.That(Exception,Is.InstanceOf(_type));
        }

        public void IsThrownWithMessage(string message)
        {
            if (_type != null)
            {
                IsThrown();
            }
            Assert.That(Exception, Is.Not.Null);
            Assert.That(Exception.Message.Contains(message));
        }

        
    }
}