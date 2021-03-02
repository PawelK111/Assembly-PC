using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssemblyPC.PCComponents;
using System.Reflection;

namespace AssemblyPC.Creators
{
    public class ComponentCreator
    {

        private object component;
        private ModelDB context;
       /// <summary>
       /// CREATE PROCESSOR
       /// </summary>
        public ComponentCreator(string producer, string model, decimal cost, string additionalInfo, 
            int frequency, int maxFrequency, int cores, int threads, 
            int cache_MB, string socket, bool graphicLayout, bool unlockerMultiplier)
        {
            component = new Processors
            {
                Producer = producer,
                Model = model,
                Cost = cost,
                AdditionalInfo = additionalInfo,
                Frequency = frequency,
                MaxFrequency = maxFrequency,
                Cores = cores,
                Threads = threads,
                Cache_MB = cache_MB,
                Socket = socket,
                HasGraphicLayout = graphicLayout,
                HasUnlockerMultiplier = unlockerMultiplier
            };
        }
        /// <summary>
        /// CREATE GRAPHIC CARD
        /// </summary>
        public ComponentCreator(string producer, string model, decimal cost, string additionalInfo, 
            int width, int memory_GB, int cuda_cores, int coreFrequency, 
            int memoryFrequency, int effectiveMemoryFreq, string connector, string typeOfMemory, 
            bool raytracing)
        {
            component = new GraphicCards
            {
                Producer = producer,
                Model = model,
                Cost = cost,
                AdditionalInfo = additionalInfo,
                Width = width,
                Memory_GB = memory_GB,
                CUDA_Cores = cuda_cores,
                CoreFrequency = coreFrequency,
                MemoryFrequency = memoryFrequency,
                EffectiveMemoryFreq = effectiveMemoryFreq,
                Connector = connector,
                TypeOfMemory = typeOfMemory,
                RayTracing = raytracing
            };
        }
        /// <summary>
        /// CREATE MOTHERBOARD
        /// </summary>
        public ComponentCreator(string producer, string model, decimal cost, string additionalInfo, 
            TypeOfMotherBoards typeOfMOMBA, int height, int width, int numberOfMemorySlots, 
            int maxRamSupported, string socket, string chipset, string format)
        {
            component = new MotherBoards
            {
                Producer = producer,
                Model = model,
                Cost = cost,
                AdditionalInfo = additionalInfo,
                typeOfMotherBoards = typeOfMOMBA,
                Height = height,
                Width = width,
                NumberOfMemorySlots = numberOfMemorySlots,
                MaxRamSupported_GB = maxRamSupported,
                Socket = socket,
                Chipset = chipset,
                Format = format
            };
        }
        /// <summary>
        /// CREATE ENCLOSURE
        /// </summary>
        public ComponentCreator(string producer, string model, decimal cost, string additionalInfo,
            TypeOfEnclosures typeOfEnclosure, int height, int width, int depth, int max_Fans, 
            int max_GPU_Width, int max_CPUColling_Height)
        {
            component = new Enclosures
            {
                Producer = producer,
                Model = model,
                Cost = cost,
                AdditionalInfo = additionalInfo,
                typeOfEnclosures = typeOfEnclosure,
                Height = height,
                Width = width,
                Depth = depth,
                Max_Fans = max_Fans,
                Max_GPU_Width = max_GPU_Width,
                Max_CPUColling_Height = max_CPUColling_Height
            };
        }
        /// <summary>
        /// CREATE RAM
        /// </summary>
        public ComponentCreator(string producer, string model, decimal cost, string additionalInfo, 
            TypeOfRAM typeRAM, int memory_MB, int frequency_MHz, int latencyCL, 
            bool backLight)
        {
            component = new RAM
            {
                Producer = producer,
                Model = model,
                Cost = cost,
                AdditionalInfo = additionalInfo,
                typeOfRAM = typeRAM,
                Memory_MB = memory_MB,
                Frequency_MHz = frequency_MHz,
                LatencyCL = latencyCL,
                isBacklight = backLight
            };
        }
        /// <summary>
        /// CREATE POWER SUPPLY
        /// </summary>
        public ComponentCreator(string producer, string model, decimal cost, string additionalInfo, 
            int maxPOWER, string format)
        {
            component = new PowerSupplies
            {
                Producer = producer,
                Model = model,
                Cost = cost,
                AdditionalInfo = additionalInfo,
                MaxPOWER = maxPOWER,
                Format = format
            };
        }
        /// <summary>
        /// CREATE DISK
        /// </summary>
        public ComponentCreator(string producer, string model, decimal cost, string additionalInfo, 
            TypeOfHardDisk typeHardDisk, int memory_GB, string interfaceDisk, int writing_MB, 
            int reading_MB)
        {
            component = new HardDisks
            {
                Producer = producer,
                Model = model,
                Cost = cost,
                AdditionalInfo = additionalInfo,
                typeOfHardDisk = typeHardDisk,
                Memory_GB = memory_GB,
                InterfaceOfDisk = interfaceDisk,
                Writing_MB = writing_MB,
                Reading_MB = reading_MB
            };
        }

        public async Task SendToDBAsync()
        {
            context = new ModelDB();
            switch(component.GetType().Name)
            {
                case "Processors":
                    context.ProcessorsTable.Add((Processors)component);
                    break;
                case "GraphicCards":
                    context.GraphicCardsTable.Add((GraphicCards)component);
                    break;
                case "MotherBoards":
                    context.MotherBoardsTable.Add((MotherBoards)component);
                    break;
                case "Enclosures":
                    context.EnclosuresTable.Add((Enclosures)component);
                    break;
                case "RAM":
                    context.RAMTable.Add((RAM)component);
                    break;
                case "PowerSupplies":
                    context.PowerSuppliesTable.Add((PowerSupplies)component);
                    break;
                case "HardDisks":
                    context.HardDisksTable.Add((HardDisks)component);
                    break;
            }
            await context.SaveChangesAsync();
        }
    }
}
