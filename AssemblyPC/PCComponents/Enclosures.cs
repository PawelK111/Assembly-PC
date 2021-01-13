using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AssemblyPC.PCComponents
{
    [Table("TypeOfEnclosures")]
    public class TypeOfEnclosures
    {
        [Key]
        public int ID { get; set; }
        public int TypeOfEnclosure { get; set; }
    }
    [Table("Enlosures")]
    public class Enclosures : PCComponent
    {
        public TypeOfEnclosures typeOfEnclosures { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public int Depth { get; set; }
        public int Max_Fans { get; set; }
        public int Max_GPU_Width { get; set; }
        public int Max_CPUColling_Height { get; set; }
    }
}
