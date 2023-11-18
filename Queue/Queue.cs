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

        public Queue(Double first, Double second)
        {
            a = 2;
            b = 0;
            c = 0;
            d = 0;

            First = first;
            Second = second;
        }
    }
}
