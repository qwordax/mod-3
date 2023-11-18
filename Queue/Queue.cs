using System;

namespace Queue
{
    /// <summary>
    /// Represents the queueing model.
    /// </summary>
    public class Queue
    {
        private readonly Random random = new Random();

        private Byte a;
        private Byte b;
        private Byte c;
        private Byte d;

        public Double First { get; set; }
        public Double Second { get; set; }

        public Int32 RequestCount { get; private set; }
        public Int32 FailureCount { get; private set; }
        public Int32 QueueCount { get; private set; }

        public Queue(Double first, Double second)
        {
            a = 2;
            b = 0;
            c = 0;
            d = 0;

            First = first;
            Second = second;

            RequestCount = 0;
            FailureCount = 0;
            QueueCount = 0;
        }

        public void NextState()
        {
            if (d == 1)
            {
                if (random.NextDouble() > First)
                {
                    d = 0;
                }
            }

            if (c == 1)
            {
                if (d == 0)
                {
                    c = 0;
                    d = 1;
                }
            }

            if (b == 1)
            {
                if (random.NextDouble() > Second)
                {
                    if (c == 0)
                    {
                        c = 1;

                        if (d == 0)
                        {
                            c = 0;
                            d = 1;
                        }
                        else
                        {
                            QueueCount++;
                        }
                    }
                    else
                    {
                        FailureCount++;
                    }

                    b = 0;
                }
            }

            if (a == 1)
            {
                a = 2;
            }
            else
            {
                a = 1;
            }

            if (a == 2)
            {
                RequestCount++;

                if (b == 0)
                {
                    b = 1;
                }
                else
                {
                    FailureCount++;
                }
            }
        }
    }
}
