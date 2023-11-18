using System;

namespace Queue
{
    /// <summary>
    /// Represents the queueing model.
    /// </summary>
    public class Queue
    {
        private Byte a;
        private Byte b;
        private Byte c;
        private Byte d;

        public Double First { get; set; }
        public Double Second { get; set; }

        public Queue()
        {
            First = 0.5;
            Second = 0.5;

            ClearState();
        }

        public Queue(Double first, Double second)
        {
            First = first;
            Second = second;

            ClearState();
        }

        public void ClearState()
        {
            a = 2;
            b = 0;
            c = 0;
            d = 0;
        }
    }
}
