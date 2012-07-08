using System;

namespace Jerky
{
    public class ExceptionBehaviour
    {
        private Exception _exception;

        public ExceptionContext Given(Action action)
        {
            action.Invoke();
            return new ExceptionContext();
        }
        public ExceptionContext Given<T1>(Action<T1> action, T1 arg)
        {
            action.Invoke(arg);
            return new ExceptionContext();
        }

        public ExceptionContext Given<T1, T2, T3>(Action<T1, T2, T3> action, T1 arg, T2 arg2, T3 arg3)
        {
            action.Invoke(arg, arg2, arg3);
            return new ExceptionContext();
        }
        public ExceptionContext Given<T1,T2>(Action<T1,T2> action, T1 arg, T2 arg2) 
        {
            action.Invoke(arg, arg2);
            return new ExceptionContext();
        }

        #region When

        public IntermediateExceptionResult When(Action action)
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

        public IntermediateExceptionResult When<T1>(Action<T1> action, T1 arg1)
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

        public IntermediateExceptionResult When<T1, T2>(Action<T1, T2> action, T1 arg1, T2 arg2)
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

        public IntermediateExceptionResult When<T1, T2, T3>(Action<T1, T2, T3> action, T1 arg1, T2 arg2, T3 arg3)
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
    }
}