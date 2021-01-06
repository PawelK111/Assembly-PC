using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyPC
{
    enum Components
    {
        CPU,
        GPU,
        MotherBoard,
        HDD,
        SSD,
        PowerSupply,
        Cover,
        RAM,
        Cooling
    }
    public abstract class PCComponent
    {
        protected string producent;
        protected string model;
        protected decimal cost;
        protected DateTime dateOfProduction;
        Components typeOfComponent;
    }
}
