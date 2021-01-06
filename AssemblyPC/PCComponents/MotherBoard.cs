using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyPC.PCComponents
{
    enum MOBAProducer
    {
        ASUS,
        Gigabyte,
        MSI,
        ASRock,
        NZXT
    }
    public enum Format
    {
        ATX,
        mATX,
        mITX,
        uATX,
        E_ATX,
        mDTX
    }
    public class MotherBoard : PCComponent
    {
        public int Height { get; private set; }
        public int Weight { get; private set; }
        public int NumberOfMemorySlots { get; private set; }
        public int MaxRamSupported_GB { get; private set; }
        public string Socket { get; private set; }
        public string Chipset { get; private set; }
        public Format Format { get; set; }
        public Dictionary<string, int> TypeOfMemorySupported { get; private set; }
    }
}
