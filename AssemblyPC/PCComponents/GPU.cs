using System.ComponentModel.DataAnnotations.Schema;

namespace AssemblyPC.PCComponents
{
    [Table("GraphicCards")]
    public class GraphicCards : PCComponent
    {
        public int Width { get; set; }
        public int Memory_GB { get;  set; }
        public int CUDA_Cores { get;  set; }
        public int CoreFrequency { get;  set; }
        public int MemoryFrequency { get;  set; }
        public int EffectiveMemoryFreq { get;  set; }
        public string Connector { get;  set; }
        public string TypeOfMemory { get;  set; }
        public bool RayTracing { get;  set; }
       
    }
}
