using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkUtils
{
    public class ProgressEventArgs : EventArgs
    {
        public ProgressEventArgs(uint current, uint maximum)
        {
            this.current = current;
            this.maximum = maximum;
        }

        public uint current { get; set; }
        public uint maximum { get; set; }
    }
}
