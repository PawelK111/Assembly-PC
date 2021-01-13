using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace AssemblyPC.PCComponents
{
    [Table("Processors")]
    public class Processors : PCComponent
    {
        public int Frequency { get;  set; }
        public int MaxFrequency { get;  set; }
        public int Cores { get;  set; }
        public int Threads { get;  set; }
        public int Cache_MB { get;  set; }
        public string Socket { get;  set; }
        public bool HasGraphicLayout { get;  set; }
        public bool HasUnlockerMultiplier { get;  set; }

    }
}
