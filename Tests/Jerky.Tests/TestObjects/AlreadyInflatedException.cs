using System;

namespace Jerky.Tests.TestObjects
{
    public class AlreadyInflatedException : InvalidOperationException
    {
        public AlreadyInflatedException(string message) : base(message)
        {}

        public AlreadyInflatedException(string message, Exception innerException) : base(message, innerException)
        {
            
        }
    }
}