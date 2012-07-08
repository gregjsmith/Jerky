using Jerky.Tests.TestObjects;
using NUnit.Framework;

namespace Jerky.Tests.Behaviour_Tests
{
// ReSharper disable InconsistentNaming
    public class Testing_AreSuppliedTo
    {
        [Test]
        public void AreSuppliedTo_passes_two_dependencies_to_a_service()
        {
            new Behaviour()
                .Given(A_string_of, "How Now")
                .AndGiven(Another_string_of,"Brown Cow")
                .AreSuppliedTo(A_StringConcatenator_Service)
                .When(Concatenate_is_called)
                .Then(The_result_will_be,"How Now Brown Cow")
                ;
        }

        [Test]
        public void AreSuppliedTo_Can_Take_two_dependencies_from_the_same_Given_Step()
        {
            new Behaviour()
                .Given(The_Strings, "Dear", "Deardrie")
                .AreSuppliedTo(A_StringConcatenator_Service)
                .When(Concatenate_is_called)
                .Then(The_result_will_be, "Dear Deardrie");
        }


        private void Another_string_of(string obj)
        {
            stringTwo = obj;
        }

        private void A_StringConcatenator_Service()
        {
            _concatenator = new StringConcatenator(stringOne, stringTwo);
        }

        private void A_string_of(string obj)
        {
            stringOne = obj;
        }

        private void Concatenate_is_called()
        {
            _result = _concatenator.Concanenate();
        }

        private void The_result_will_be(string obj)
        {
            Assert.AreEqual(_result, obj);
        }


        private void The_Strings(string arg1, string arg2)
        {
            stringOne = arg1;
            stringTwo = arg2;
        }

        private string stringOne;
        private string stringTwo;
        private StringConcatenator _concatenator;
        private string _result;
    }
}
// ReSharper restore InconsistentNaming