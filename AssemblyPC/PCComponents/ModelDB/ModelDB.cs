using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace AssemblyPC.PCComponents
{
    public class ModelDB : DbContext
    {
        public ModelDB() : base("name = AssemblyPCConnection") { }
        public DbSet<MotherBoards> MotherBoardsTable { get; set; }
        public DbSet<Processors> ProcessorsTable { get; set; }
        public DbSet<GraphicCards> GraphicCardsTable { get; set; }
        public DbSet<HardDisks> HardDisksTable { get; set; }
        public DbSet<PowerSupplies> PowerSuppliesTable { get; set; }
        public DbSet<RAM> RAMTable { get; set; }
        public DbSet<Enclosures> EnclosuresTable { get; set; }
        public DbSet<TypeOfEnclosures> TypeOfEnclosuresTable { get; set; }
        public DbSet<TypeOfHardDisk> TypeOfHardDiskTable { get; set; }
        public DbSet<TypeOfMotherBoards> TypeOfMotherBoardsTable { get; set; }
        public DbSet<TypeOfRAM> TypeOfRAMTable { get; set; }
        public DbSet<Computers> ComputersTable { get; set; }
    }
}
