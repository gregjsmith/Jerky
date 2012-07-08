using System;

namespace Jerky.Tests.TestObjects
{
    public class AnotherTestType : IAnotherTestType
    {
        private readonly ITestType _testType;

        public AnotherTestType(ITestType testType)
        {
            _testType = testType;
        }

        public void MethodThree()
        {
            Console.WriteLine("In Method Three");
        }

        public void MethodFour()
        {
            _testType.State = "Done";
        }
    }
}