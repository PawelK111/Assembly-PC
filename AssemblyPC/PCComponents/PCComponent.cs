using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace AssemblyPC
{
    public abstract class PCComponent
    {
        [Key]
        public int ID { get; set; }
        public string Producer { get; set; }
        public string Model { get; set;}
        public decimal Cost { get; set;}
        public string AdditionalInfo { get; set; }
    }
}
