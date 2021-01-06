using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyPC.PCComponents
{
    enum ProducentGPU
    {
       AMD,
       NVIDIA
    }
    public class GPU : PCComponent
    {
        public int Memory_GB { get; private set; }
        public int CUDA_Cores { get; private set; }
        public int CoreFrequency { get; private set; }
        public int MemoryFrequency { get; private set; }
        public int EffectiveMemoryFreq { get; private set; }
        public string Connector { get; private set; }
        public string TypeOfMemory { get; private set; }
        public bool RayTracing { get; private set; }
       
    }
}
