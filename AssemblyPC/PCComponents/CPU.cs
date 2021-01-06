using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyPC.PCComponents
{
    enum ProducentCPU
    {
        AMD,
        Intel
    }
    public class CPU : PCComponent
    {
        public int Frequency { get; private set; }
        public int MaxFrequency { get; private set; }
        public int Cores { get; private set; }
        public int Threads { get; private set; }
        public int Cache_MB { get; private set; }
        public string Socket { get; private set; }
        public bool HasGraphicLayout { get; private set; }
        public bool HasUnlockerMultiplier { get; private set; }

    }
}
