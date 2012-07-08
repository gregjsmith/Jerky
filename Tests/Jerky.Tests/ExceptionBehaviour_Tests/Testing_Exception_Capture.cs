using System;
using Jerky.Tests.TestObjects;
using NUnit.Framework;

// ReSharper disable InconsistentNaming
namespace Jerky.Tests.ExceptionBehaviour_Tests
{
    public class Testing_Exception_Capture
    {
        [Test]
        public void With_When_step_first_and_simple_exception_type_verification()
        {
           new ExceptionBehaviour()
            .When(Trying_to_convert_to_integer_with,90000000000000)
            .AnExceptionOfType(typeof(OverflowException))
            .IsThrown();
        }

        [Test]
        public void Using_AreSuppliedTo_and_Capturing_Exception_Message()
        {
            new ExceptionBehaviour()
                .Given(A_string_of, "Come The Day")
                .AndGiven(Another_string_of, "Come The Hour")
                .AreSuppliedTo(A_new_StringReverser)
                .When(Reverse_is_called)
                .AndWhen(Compare_is_called)
                .AnException()
                .IsThrownWithMessage("The strings do not match");
        }

        [Test]
        public void Using_IsSupplied_To_Step_and_simple_exception_type_verification()
        {
            new ExceptionBehaviour()
                .Given(A_null_string)
                .IsSuppliedTo(A_Constructor_That_cannot_accept_nulls)
                .AnExceptionOfType(typeof(ArgumentNullException))
                .IsThrown();
        }

        [Test]
        public void Can_Check_both_Exception_type_and_exception_message()
        {
            new ExceptionBehaviour()
                .Given(A_Withdrawl_is_made_from_an_account)
                .When(The_account_is_left_with_negative_balance)
                .AnExceptionOfType(typeof(InvalidOperationException))
                .IsThrownWithMessage("You do not have enough funds");
        }

        private void A_Withdrawl_is_made_from_an_account()
        {
            _withdrawl = 500;
        }

        private void The_account_is_left_with_negative_balance()
        {
            _account = new Account("Dave");

            _account.Withdraw(_withdrawl);
        }




        private void A_null_string()
        {
            stringOne = null;
        }

        private void A_Constructor_That_cannot_accept_nulls()
        {
            new Account(stringOne);
        }

        private void A_string_of(string obj)
        {
            stringOne = obj;
        }

        private void Another_string_of(string obj)
        {
            stringTwo = obj;
        }

        private void A_new_StringReverser()
        {
            _reverser = new StringReverser(stringOne, stringTwo);
        }

        private void Reverse_is_called()
        {
            _reverser.Reverse();
        }

        private void Compare_is_called()
        {
            _reverser.Compare();
        }

        private static void Trying_to_convert_to_integer_with(long obj)
        {
            Convert.ToInt32(obj);
        }

        private Account _account;
        private int _withdrawl;
        private string stringOne;
        private string stringTwo;
        private StringReverser _reverser;
    }
}
// ReSharper restore InconsistentNaming