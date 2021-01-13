using System.ComponentModel.DataAnnotations.Schema;

namespace AssemblyPC.PCComponents
{
    [Table("PowerSupplies")]
    public class PowerSupplies : PCComponent
    {
        public int MaxPOWER { get; set; }
        public string Format { get; set; }
    }
}
