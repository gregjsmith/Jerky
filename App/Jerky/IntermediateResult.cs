using System;
using NUnit.Framework;

namespace Jerky
{
    public class IntermediateResult : Result
    {
        public IntermediateResult And(Action action)
        {
            action.Invoke();
            return new IntermediateResult();
        }

        public IntermediateResult And<T>(Action<T> action, T arg1)
        {
            action.Invoke(arg1);
            return new IntermediateResult();
        }

        public IntermediateResult And<T1, T2, T3>(Action<T1, T2, T3> action, T1 arg1, T2 arg2, T3 arg3)
        {
            action.Invoke(arg1, arg2, arg3);
            return new IntermediateResult();
        }

        public IntermediateResult And<T1, T2>(Action<T1, T2> action, T1 arg1, T2 arg2)
        {
            action.Invoke(arg1, arg2);
            return new IntermediateResult();
        }

        public IntermediateResult IsSuppliedTo<T>(Action<T> action, T arg1)
        {
            action.Invoke(arg1);
            return new IntermediateResult();
        }

        public IntermediateResult IsSuppliedTo<T1, T2>(Action<T1,T2> action, T1 arg1, T2 arg2)
        {
            action.Invoke(arg1, arg2);
            return new IntermediateResult();
        }

        public IntermediateResult IsSuppliedTo<T1, T2, T3>(Action<T1, T2, T3> action, T1 arg1, T2 arg2, T3 arg3)
        {
            action.Invoke(arg1, arg2, arg3);
            return new IntermediateResult();
        }

        public Result Then(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (NotImplementedException)
            {
                Assert.Inconclusive();
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
            return new Result();
        }

        public Result Then<T>(Action<T> action, T arg)
        {
            try
            {
                action.Invoke(arg);
            }
            catch (NotImplementedException)
            {
                Assert.Inconclusive();
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }

            return new Result();
        }

        public Result Then<T1, T2>(Action<T1, T2> action, T1 arg1, T2 arg2)
        {
            try
            {
                action.Invoke(arg1, arg2);
            }
            catch (NotImplementedException)
            {
                Assert.Inconclusive();
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }

            return new Result();
        }

        public Result Then<T1, T2, T3>(Action<T1, T2, T3> action, T1 arg1, T2 arg2, T3 arg3)
        {
            try
            {
                action.Invoke(arg1, arg2, arg3);
            }
            catch (NotImplementedException)
            {
                Assert.Inconclusive();
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }

            return new Result();
        }


        public Result Then(bool predicate)
        {
            Assert.IsTrue(predicate);
            return new Result();
        }

        public Result AndThen(bool predicate)
        {
            Assert.IsTrue(predicate);
            return new Result();
        }

    }
}