using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AssemblyPC.PCComponents
{
    public class TypeOfMotherBoards
    {
        [Key]
        public int ID { get; set; }
        public string TypeOfMOBA { get; set; }
    }
    [Table("MotherBoards")]
    public class MotherBoards : PCComponent
    {
        public TypeOfMotherBoards typeOfMotherBoards { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public int NumberOfMemorySlots { get; set; }
        public int MaxRamSupported_GB { get; set; }
        public string Socket { get; set; }
        public string Chipset { get; set; }
        public string Format { get; set; }
    }
}
