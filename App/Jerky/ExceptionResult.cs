using System;

namespace Jerky
{
    public class ExceptionResult
    {
        private  Exception _exception;
        private Type _type;

        public ExceptionResult(Exception exception)
        {
            _exception = exception;
        }

        public ExceptionVerification AnException()
        {
            return new ExceptionVerification(_exception, _type);
        }

        public ExceptionVerification TheThrownException()
        {
            return new ExceptionVerification(_exception, _type);
        }

        public ExceptionVerification AnExceptionOfType(Type t)
        {
            _type = t;
            return new ExceptionVerification(_exception, _type);
        }

        

        public ExceptionResult AndWhen(Action action)
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

        public ExceptionResult AndWhen<T1>(Action<T1> action, T1 arg1)
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

        public ExceptionResult AndWhen<T1, T2>(Action<T1, T2> action, T1 arg1, T2 arg2)
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

        public ExceptionResult AndWhen<T1, T2, T3>(Action<T1, T2, T3> action, T1 arg1, T2 arg2, T3 arg3)
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

        
    }
}