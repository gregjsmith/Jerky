using System;

namespace Jerky.Tests.TestObjects
{
    public class ExceptionThrower
    {
        public ExceptionThrower()
        {
            try
            {
                throw new ArgumentException();
            }
            catch (Exception exception)
            {
                ExceptionWrapper.Wrap(exception);
            }
        }
    }
}