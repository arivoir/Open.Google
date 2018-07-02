using System;

namespace Open.Google
{
    public class GoogleException : Exception
    {
        public GoogleException(Exception exc)
            : base(exc.Message, exc)
        {

        }
    }
}
