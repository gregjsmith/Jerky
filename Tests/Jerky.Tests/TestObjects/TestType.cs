namespace Jerky.Tests.TestObjects
{
    public class TestType : ITestType
    {
        private readonly IAnotherTestType _anotherTestType;

        public TestType()
        {
            SomeInt = 1;
        }

        public TestType(IAnotherTestType anotherTestType)
        {
            _anotherTestType = anotherTestType;
        }

        public string State { get; set; }

        public int SomeInt { get; set; }

        public void MethodOne()
        {
            _anotherTestType.MethodThree();
        }

        public void MethodTwo()
        {
            _anotherTestType.MethodFour();
        }
    }
}