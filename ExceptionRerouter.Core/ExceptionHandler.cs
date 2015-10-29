using System;

namespace ExceptionRerouter.Core
{
    public class ExceptionHandler
    {
        private readonly ExceptionContext exceptionContext;

        public ExceptionHandler(ExceptionContext exceptionContext)
        {
            this.exceptionContext = exceptionContext;
        }

        public void Handle(Exception exception)
        {
        }
    }
}