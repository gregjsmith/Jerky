#Jerky#

Small and lightweight C# testing DSL. Allows the description of behaviours. 

The project is still at an early stage of development and, as such, is not currently at a stable version.

##Dependencies##

NUnit - 2.6.x

##Usage Guide##

To use Jerky, you define a new Behaviour() class. 
From there, you can use the fluent API in a
number of ways to get the results you need for your situation.

Jerky defines "steps" which can be used to describe the 
the behaviour you wish to achieve in a readable way 
The steps are designed to be discoverable and easy to use

These steps take an arbitrary method pointer
to be implemented as required

    public class Use_a_given_when_then_syntax
    {
        [Test]
        public void To_specify_a_readable_behaviour()
        {
            new Behaviour()
                .Given(Some_Method_pointer_to_set_context)
                .When(Some_behaviour_is_invoked)
                .Then(Something_verifiable_will_be_the_result);
        }


        public void Some_Method_pointer_to_set_context()
        {
            _context = new Something();
        }

        public void Some_behaviour_is_invoked()
        {
            _result.Bar = _context.Foo();
        }

        public void Something_verifiable_will_be_the_result()
        {
            Assert.AreEqual("Yadda Yadda" _result.Bar);            
        }

        private SomeThing _context;
        private SomethingElse _result;
    }

    public class You_can_add_some_flexibility
    {
        [Test]
        public void By_passing_along_some_arguments()
        {
            new Behaviour()
                .Given(A, new Stack<string>())
                .AndGiven(We_pass_it, "One", "Two", "Three")
                .When(The_stack_gets_popped)
                .Then(The_popped_string_will_be,"Three")
                .AndThen(The_count_of_elements_in_the_stack_will_be, 2);
        }

        public void A(Stack<string> obj)
        {
            _stack = obj;
        }

        public void We_pass_it(string a, string b, string c)
        {
            _stack.Push(a);
            _stack.Push(b);
            _stack.Push(c);
        }

        public void The_stack_gets_popped()
        {
            stringOne = _stack.Pop();
        }

        public void The_popped_string_will_be(string obj)
        {
            stringOne.ShouldEqual(obj);
        }

        public void The_count_of_elements_in_the_stack_will_be(int obj)
        {
            Asert.That(_stack.Count,Is.EqualTo(2));        
        }

        private Stack<string> _stack;
        private string stringOne;
    }

    public class For_The_simplest_Tests
    {
        [Test]
        public void You_can_start_with_a_When_step()
        {
            new Behaviour()
                .When(A_new_Account_is_created)
                .Then(The_account_balance_will_be, 0);
        }

        public void A_new_Account_is_created()
        {
            _account = new Account();
        }

        public void The_account_balance_will_be(int obj)
        {
            Assert.That(_account.GetBalance(),Is.EqualTo(obj));            
        }

        private Account _account;
    }

    
Jerky also exposes an ExceptionBehaviour 
type to allow designing for exceptions 
in a clean way - no try catch blocks

    
    public class Design_for_exceptions
    {
		[Test]
        public void Using_the_ExceptionBehaviour_syntax()
        {
            new ExceptionBehaviour()
                .When(An_unacceptable_input)
                .IsSuppliedTo(A_Fussy_Method)
                .AnExceptionOfType(typeof (DodgyInputException))
                .IsThrown();
        }

        public void An_unacceptable_input()
        {
            _rubbish = null;
        }

        public void A_Fussy_Method()
        {
            new FussyThing(_rubbish);
        }

        private Rubbish _rubbish;
    }


    public class You_can_also
    {
        [Test]
        public void Supply_values_as_before()
        {
            new ExceptionBehaviour()
                .Given(An_account_with_balance_of, 1000)
                .When(A_withdrawl_is_made_of, 1001)
                .AndWhen(The_account_has_no_overdraft)
                .AnException()
                .IsThrownWithMessage("Insufficient Funds");
        }

        public void An_account_with_balance_of(int obj)
        {
            _account = new Account();
            _account.Deposit(obj);
        }

        public void The_account_has_no_overdraft()
        {
            _account.SetOverdraftLimit(0);
        }

        public void A_withdrawl_is_made_of(int obj)
        {
            _account.Withdraw(obj);
        }
    }
    
