using System;

namespace Jerky
{
    public class Behaviour
    {
        public AdvancedContext Given(Action action)
        {
            action.Invoke();
            return new AdvancedContext();
        }

        public AdvancedContext Given<T1>(Action<T1> action, T1 arg)
        {
            action.Invoke(arg);
            return new AdvancedContext();
        }

        public AdvancedContext Given<T1, T2>(Action<T1, T2> action, T1 arg1, T2 arg2)
        {
            action.Invoke(arg1, arg2);
            return new AdvancedContext();
        }

        public AdvancedContext Given<T1, T2, T3>(Action<T1, T2, T3> action, T1 arg1, T2 arg2, T3 arg3)
        {
            action.Invoke(arg1, arg2, arg3);
            return new AdvancedContext();
        }

        public IntermediateResult When(Action action)
        {
            action.Invoke();
            return new IntermediateResult();
        }

        public IntermediateResult When<T>(Action<T> action, T arg)
        {
            action.Invoke(arg);
            return new IntermediateResult();
        }

        public IntermediateResult When<T1, T2>(Action<T1, T2> action, T1 arg1, T2 arg2)
        {
            action.Invoke(arg1, arg2);
            return new IntermediateResult();
        }

        public IntermediateResult When<T1, T2, T3>(Action<T1, T2, T3> action, T1 arg1, T2 arg2, T3 arg3)
        {
            action.Invoke(arg1, arg2, arg3);
            return new IntermediateResult();
        }

        public AdvancedContext Given<T>(T actor)
        {
            return new AdvancedContext();
        }
    }
}