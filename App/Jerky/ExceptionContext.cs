using System;

namespace Jerky
{
    public class ExceptionContext
    {
        private Exception _exception;

        #region IsSuppliedTo

        public IntermediateExceptionResult IsSuppliedTo(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception ex)
            {
                _exception = ex;
            }

            return new IntermediateExceptionResult(_exception);
        }

        public ExceptionResult IsSuppliedTo<T>(Action<T> action, T arg1)
        {
            try
            {
                action.Invoke(arg1);
            }
            catch (Exception ex)
            {
                _exception = ex;
            }

            return new ExceptionResult(_exception);
        }

        public IntermediateExceptionResult IsSuppliedTo<T, T2>(Action<T, T2> action, T arg1, T2 arg2)
        {
            try
            {
                action.Invoke(arg1, arg2);
            }
            catch (Exception ex)
            {
                _exception = ex;
            }

            return new IntermediateExceptionResult(_exception);
        }

        public IntermediateExceptionResult IsSuppliedTo<T, T2, T3>(Action<T, T2, T3> action, T arg1, T2 arg2, T3 arg3)
        {
            try
            {
                action.Invoke(arg1, arg2, arg3);
            }
            catch (Exception ex)
            {
                _exception = ex;
            }

            return new IntermediateExceptionResult(_exception);
        }

        #endregion

        #region AreSuppliedTo

        public IntermediateExceptionResult AreSuppliedTo(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception ex)
            {
                _exception = ex;
            }

            return new IntermediateExceptionResult(_exception);
        }


        public IntermediateExceptionResult AreSuppliedTo<T>(Action<T> action, T arg1)
        {
            try
            {
                action.Invoke(arg1);
            }
            catch (Exception ex)
            {
                _exception = ex;
            }

            return new IntermediateExceptionResult(_exception);
        }

        public IntermediateExceptionResult AreSuppliedTo<T, T2>(Action<T, T2> action, T arg1, T2 arg2)
        {
            try
            {
                action.Invoke(arg1, arg2);
            }
            catch (Exception ex)
            {
                _exception = ex;
            }

            return new IntermediateExceptionResult(_exception);
        }

        public IntermediateExceptionResult AreSuppliedTo<T, T2, T3>(Action<T, T2, T3> action, T arg1, T2 arg2, T3 arg3)
        {
            try
            {
                action.Invoke(arg1, arg2, arg3);
            }
            catch (Exception ex)
            {
                _exception = ex;
            }

            return new IntermediateExceptionResult(_exception);
        }

        #endregion

        #region When

        public ExceptionResult When(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception ex)
            {
                _exception = ex;
            }
            return new ExceptionResult(_exception);
        }

        public ExceptionResult When<T1>(Action<T1> action, T1 arg1)
        {
            try
            {
                action.Invoke(arg1);
            }
            catch (Exception ex)
            {
                _exception = ex;
            }
            return new ExceptionResult(_exception);
        }

        public ExceptionResult When<T1, T2>(Action<T1, T2> action, T1 arg1, T2 arg2)
        {
            try
            {
                action.Invoke(arg1, arg2);
            }
            catch (Exception ex)
            {
                _exception = ex;
            }
            return new ExceptionResult(_exception);
        }

        public ExceptionResult When<T1, T2, T3>(Action<T1, T2, T3> action, T1 arg1, T2 arg2, T3 arg3)
        {
            try
            {
                action.Invoke(arg1, arg2, arg3);
            }

            catch (Exception ex)
            {
                _exception = ex;
            }
            return new ExceptionResult(_exception);
        }

        #endregion

        #region AndGiven
        public ExceptionContext AndGiven(Action action)
        {
            action.Invoke();
            return new ExceptionContext();
        }
        public ExceptionContext AndGiven<T1>(Action<T1> action, T1 arg) where T1 : class
        {
            action.Invoke(arg);
            return new ExceptionContext();
        }

        public ExceptionContext AndGiven<T1, T2, T3>(Action<T1, T2, T3> action, T1 arg, T2 arg2, T3 arg3)
        {
            action.Invoke(arg, arg2, arg3);
            return new ExceptionContext();
        }
        public ExceptionContext AndGiven<T1, T2>(Action<T1, T2> action, T1 arg, T2 arg2)
        {
            action.Invoke(arg, arg2);
            return new ExceptionContext();
        }

        #endregion

        public ExceptionContext AndGiven<T>(T arg)
        {
            return new ExceptionContext();
        }

        public ExceptionContext AndGiven<T1, T2, T3>(T1 arg, T2 arg2, T3 arg3)
        {
            return new ExceptionContext();
        }

        public ExceptionContext AndGiven<T1, T2>(T1 arg, T2 arg2)
        {
            return new ExceptionContext();
        }


    }
}