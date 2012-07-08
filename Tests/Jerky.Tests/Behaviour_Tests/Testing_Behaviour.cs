using System.Collections.Generic;
using NUnit.Framework;

// ReSharper disable InconsistentNaming
namespace Jerky.Tests.Behaviour_Tests
{
    public class Testing_Behaviour
    {
        private Stack<string> _stack;

        [Test]
        public void With_A_Stack()
        {
            new Behaviour()
                .Given(A, new Stack<string>())
                .AndGiven(We_pass_in, "One", "Two", "Three")
                .When(One_string_is_popped)
                .Then(There_will_be_two_strings_left);
        }

        private void We_pass_in(string arg1, string arg2, string arg3)
        {
            _stack.Push(arg1);
            _stack.Push(arg2);
            _stack.Push(arg3);
        }

        private void A(Stack<string> obj)
        {
            _stack = obj;
        }

        private void One_string_is_popped()
        {
            _stack.Pop();
        }

        private void There_will_be_two_strings_left()
        {
            Assert.AreEqual(_stack.Count, 2);
        }

    }
}
// ReSharper restore InconsistentNaming