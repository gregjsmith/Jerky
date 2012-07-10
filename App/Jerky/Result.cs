using System;
using NUnit.Framework;

namespace Jerky
{
    public class Result
    {

        public Result AndThen(Action action)
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

        public Result AndThen<T>(Action<T> action, T arg)
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

        public Result AndThen<T1, T2>(Action<T1, T2> action, T1 arg1, T2 arg2)
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

        public Result AndThen<T1, T2, T3>(Action<T1, T2, T3> action, T1 arg1, T2 arg2, T3 arg3)
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

        public Result AndThen(bool predicate)
        {
            Assert.IsTrue(predicate);
            return new Result();
        }
    }
}