using System;
using NUnit.Framework;

namespace Jerky.Tests.Behaviour_Tests
{
// ReSharper disable InconsistentNaming
    public class Testing_ThenSteps
    {
        private string _stringTwo;
        private string _stringOne;
        private string _tempString;
        private bool _bool;

        [Test]
        public void Calling_AndThen_Once_Gives_Expected_Results()
        {
            new Behaviour()
                .Given(A_string_of, "Baby Jesus")
                .When(The_string_is_reversed)
                .And(The_reversed_string_is_saved_to_a_new_string)
                .Then(The_first_string_will_still_be, "Baby Jesus")
                .AndThen(The_second_string_will_be, "suseJ ybaB");
        }

        [Test]
        public void Passing_a_boolean_expression_to_AndThen()
        {
            new Behaviour()
                .When(() => _bool = 1 == 2)
                .Then(_bool == false)
                .AndThen(_bool == false);
        }


        private void A_string_of(string obj)
        {
            _stringOne = obj;
        }

        private void The_string_is_reversed()
        {
            var a = _stringOne.ToCharArray();
            Array.Reverse(a);
            _tempString = new string(a);
        }

        private void The_reversed_string_is_saved_to_a_new_string()
        {
            _stringTwo = _tempString;
        }

        private void The_first_string_will_still_be(string obj)
        {
            Assert.AreEqual(_stringOne, obj);
        }

        private void The_second_string_will_be(string obj)
        {
            Assert.AreEqual(_stringTwo, obj);
        }
    }
}
// ReSharper restore InconsistentNaming