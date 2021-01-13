using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AssemblyPC.PCComponents
{
    [Table("AssembliedComputers")]
    public class Computers
    {
        [Key]
        public int ID { get; set; }
        public Enclosures Enclosure { get; set; }
        public MotherBoards MotherBoard { get; set; }
        public Processors Processor { get; set; }
        public GraphicCards GraphicCard { get; set; }
        public RAM ram { get; set; }
        public HardDisks HardDisk { get; set; }
        public PowerSupplies PowerSupply { get; set; }
    }
}
