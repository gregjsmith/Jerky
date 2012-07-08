using System;

namespace Jerky.Tests.TestObjects
{
    public class ExceptionWrapper
    {
        public static void Wrap(Exception exception)
        {
            throw new InvalidOperationException("An exception was Wrapped");
        }
    }
}