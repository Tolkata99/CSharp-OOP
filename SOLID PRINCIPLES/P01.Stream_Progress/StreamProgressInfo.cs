using System;
using System.Collections.Generic;
using System.Text;

namespace P01.Stream_Progress
{
    public class StreamProgressInfo
    {
        private IStreamable streamable;

        public StreamProgressInfo(IStreamable stream)
        {
            this.streamable = stream;
        }

        public int CalculateCurrentPercent()
        {
            return (this.streamable.ByteSent * 100) / this.streamable.Length;
        }
    }
}
