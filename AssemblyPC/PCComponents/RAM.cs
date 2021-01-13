using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AssemblyPC.PCComponents
{
    [Table("TypeOfRAM")]
    public class TypeOfRAM
    {
        [Key]
        public int ID { get; set; }
        public string TypeOfRam { get; set; }
    }
    [Table("RAM")]
    public class RAM : PCComponent
    {
        public TypeOfRAM typeOfRAM { get; set; }
        public int Memory_MB { get; set; }
        public int Frequency_MHz { get; set; }
        public int LatencyCL { get; set; }
        public bool isBacklight { get; set; }

    }
}
