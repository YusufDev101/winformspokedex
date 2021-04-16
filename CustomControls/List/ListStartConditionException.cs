using System;

namespace CustomControls
{
    class ListStartConditionException : Exception {
        public ListStartConditionException()
        {
        }

        public ListStartConditionException(string message) : base(message)
        {
        }

        public ListStartConditionException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
