using System;
using NUnit.Framework;

namespace Jerky
{
    public class Context
    {
        #region AndGiven

        public AdvancedContext AndGiven(Action action)
        {
            action.Invoke();
            return new AdvancedContext();
        }

        public AdvancedContext AndGiven<T1>(Action<T1> action, T1 arg1)
        {
            action.Invoke(arg1);
            return new AdvancedContext();
        }

        public AdvancedContext AndGiven<T1, T2>(Action<T1, T2> action, T1 arg1, T2 arg2)
        {
            action.Invoke(arg1, arg2);
            return new AdvancedContext();
        }

        public AdvancedContext AndGiven<T1, T2, T3>(Action<T1, T2, T3> action, T1 arg1, T2 arg2, T3 arg3)
        {
            action.Invoke(arg1, arg2, arg3);
            return new AdvancedContext();
        }

        #endregion

        #region IsSuppliedTo

        public AdvancedContext IsSuppliedTo(Action action)
        {
            action.Invoke();
            return new AdvancedContext();
        }

        public AdvancedContext IsSuppliedTo<T>(Action<T> action, T arg)
        {
            action.Invoke(arg);
            return new AdvancedContext();
        }

        public AdvancedContext IsSuppliedTo<T1, T2>(Action<T1, T2> action, T1 arg1, T2 arg2)
        {
            action.Invoke(arg1, arg2);
            return new AdvancedContext();
        }

        public AdvancedContext IsSuppliedTo<T1, T2, T3>(Action<T1, T2, T3> action, T1 arg1, T2 arg2, T3 arg3)
        {
            action.Invoke(arg1, arg2, arg3);
            return new AdvancedContext();
        }

        #endregion

        #region AreSuppliedTo

        public AdvancedContext AreSuppliedTo(Action action)
        {
            action.Invoke();
            return new AdvancedContext();
        }

        public AdvancedContext AreSuppliedTo<T>(Action<T> action, T arg)
        {
            action.Invoke(arg);
            return new AdvancedContext();
        }

        public AdvancedContext AreSuppliedTo<T1, T2>(Action<T1, T2> action, T1 arg1, T2 arg2)
        {
            action.Invoke(arg1, arg2);
            return new AdvancedContext();
        }

        public AdvancedContext AreSuppliedTo<T1, T2, T3>(Action<T1, T2, T3> action, T1 arg1, T2 arg2, T3 arg3)
        {
            action.Invoke(arg1, arg2, arg3);
            return new AdvancedContext();
        }

        #endregion

        #region Then
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
        #endregion

    }
}
