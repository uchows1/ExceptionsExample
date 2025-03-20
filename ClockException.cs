using System;


namespace CustomExceptions
{
    class ClockException: Exception
    {
        public ClockException(): base()
        {
            
        }

        public ClockException(string msg) : base(msg)
        {

        }

        public ClockException(string msg, Exception inner) : base(msg, inner)
        {

        }
    }
}
