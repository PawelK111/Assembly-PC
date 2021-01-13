using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AssemblyPC.PCComponents
{
    [Table("TypeOfHardDisk")]
    public class TypeOfHardDisk
    {
        [Key]
        public int ID { get; set; }
        public string TypeOfHD { get; set; }
    }
    [Table("HardDisks")]
    public class HardDisks : PCComponent
    {
        public TypeOfHardDisk typeOfHardDisk { get; set; }
        public int Memory_GB { get; set; }
        public string InterfaceOfDisk { get; set; }
        public int Writing_MB { get; set; }
        public int Reading_MB { get; set; }

    }
}
