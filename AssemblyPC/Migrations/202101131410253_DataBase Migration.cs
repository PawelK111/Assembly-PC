namespace AssemblyPC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataBaseMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AssembliedComputers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Enclosure_ID = c.Int(),
                        GraphicCard_ID = c.Int(),
                        HardDisk_ID = c.Int(),
                        MotherBoard_ID = c.Int(),
                        PowerSupply_ID = c.Int(),
                        Processor_ID = c.Int(),
                        ram_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Enlosures", t => t.Enclosure_ID)
                .ForeignKey("dbo.GraphicCards", t => t.GraphicCard_ID)
                .ForeignKey("dbo.HardDisks", t => t.HardDisk_ID)
                .ForeignKey("dbo.MotherBoards", t => t.MotherBoard_ID)
                .ForeignKey("dbo.PowerSupplies", t => t.PowerSupply_ID)
                .ForeignKey("dbo.Processors", t => t.Processor_ID)
                .ForeignKey("dbo.RAM", t => t.ram_ID)
                .Index(t => t.Enclosure_ID)
                .Index(t => t.GraphicCard_ID)
                .Index(t => t.HardDisk_ID)
                .Index(t => t.MotherBoard_ID)
                .Index(t => t.PowerSupply_ID)
                .Index(t => t.Processor_ID)
                .Index(t => t.ram_ID);
            
            CreateTable(
                "dbo.Enlosures",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Height = c.Int(nullable: false),
                        Width = c.Int(nullable: false),
                        Depth = c.Int(nullable: false),
                        Max_Fans = c.Int(nullable: false),
                        Max_GPU_Width = c.Int(nullable: false),
                        Max_CPUColling_Height = c.Int(nullable: false),
                        Producer = c.String(),
                        Model = c.String(),
                        Cost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        AdditionalInfo = c.String(),
                        typeOfEnclosures_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.TypeOfEnclosures", t => t.typeOfEnclosures_ID)
                .Index(t => t.typeOfEnclosures_ID);
            
            CreateTable(
                "dbo.TypeOfEnclosures",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TypeOfEnclosure = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.GraphicCards",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Width = c.Int(nullable: false),
                        Memory_GB = c.Int(nullable: false),
                        CUDA_Cores = c.Int(nullable: false),
                        CoreFrequency = c.Int(nullable: false),
                        MemoryFrequency = c.Int(nullable: false),
                        EffectiveMemoryFreq = c.Int(nullable: false),
                        Connector = c.String(),
                        TypeOfMemory = c.String(),
                        RayTracing = c.Boolean(nullable: false),
                        Producer = c.String(),
                        Model = c.String(),
                        Cost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        AdditionalInfo = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.HardDisks",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Memory_GB = c.Int(nullable: false),
                        InterfaceOfDisk = c.String(),
                        Writing_MB = c.Int(nullable: false),
                        Reading_MB = c.Int(nullable: false),
                        Producer = c.String(),
                        Model = c.String(),
                        Cost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        AdditionalInfo = c.String(),
                        typeOfHardDisk_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.TypeOfHardDisk", t => t.typeOfHardDisk_ID)
                .Index(t => t.typeOfHardDisk_ID);
            
            CreateTable(
                "dbo.TypeOfHardDisk",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TypeOfHD = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.MotherBoards",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Height = c.Int(nullable: false),
                        Width = c.Int(nullable: false),
                        NumberOfMemorySlots = c.Int(nullable: false),
                        MaxRamSupported_GB = c.Int(nullable: false),
                        Socket = c.String(),
                        Chipset = c.String(),
                        Format = c.String(),
                        Producer = c.String(),
                        Model = c.String(),
                        Cost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        AdditionalInfo = c.String(),
                        typeOfMotherBoards_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.TypeOfMotherBoards", t => t.typeOfMotherBoards_ID)
                .Index(t => t.typeOfMotherBoards_ID);
            
            CreateTable(
                "dbo.TypeOfMotherBoards",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TypeOfMOBA = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.PowerSupplies",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MaxPOWER = c.Int(nullable: false),
                        Format = c.String(),
                        Producer = c.String(),
                        Model = c.String(),
                        Cost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        AdditionalInfo = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Processors",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Frequency = c.Int(nullable: false),
                        MaxFrequency = c.Int(nullable: false),
                        Cores = c.Int(nullable: false),
                        Threads = c.Int(nullable: false),
                        Cache_MB = c.Int(nullable: false),
                        Socket = c.String(),
                        HasGraphicLayout = c.Boolean(nullable: false),
                        HasUnlockerMultiplier = c.Boolean(nullable: false),
                        Producer = c.String(),
                        Model = c.String(),
                        Cost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        AdditionalInfo = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.RAM",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Memory_MB = c.Int(nullable: false),
                        Frequency_MHz = c.Int(nullable: false),
                        LatencyCL = c.Int(nullable: false),
                        isBacklight = c.Boolean(nullable: false),
                        Producer = c.String(),
                        Model = c.String(),
                        Cost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        AdditionalInfo = c.String(),
                        typeOfRAM_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.TypeOfRAM", t => t.typeOfRAM_ID)
                .Index(t => t.typeOfRAM_ID);
            
            CreateTable(
                "dbo.TypeOfRAM",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TypeOfRam = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AssembliedComputers", "ram_ID", "dbo.RAM");
            DropForeignKey("dbo.RAM", "typeOfRAM_ID", "dbo.TypeOfRAM");
            DropForeignKey("dbo.AssembliedComputers", "Processor_ID", "dbo.Processors");
            DropForeignKey("dbo.AssembliedComputers", "PowerSupply_ID", "dbo.PowerSupplies");
            DropForeignKey("dbo.AssembliedComputers", "MotherBoard_ID", "dbo.MotherBoards");
            DropForeignKey("dbo.MotherBoards", "typeOfMotherBoards_ID", "dbo.TypeOfMotherBoards");
            DropForeignKey("dbo.AssembliedComputers", "HardDisk_ID", "dbo.HardDisks");
            DropForeignKey("dbo.HardDisks", "typeOfHardDisk_ID", "dbo.TypeOfHardDisk");
            DropForeignKey("dbo.AssembliedComputers", "GraphicCard_ID", "dbo.GraphicCards");
            DropForeignKey("dbo.AssembliedComputers", "Enclosure_ID", "dbo.Enlosures");
            DropForeignKey("dbo.Enlosures", "typeOfEnclosures_ID", "dbo.TypeOfEnclosures");
            DropIndex("dbo.RAM", new[] { "typeOfRAM_ID" });
            DropIndex("dbo.MotherBoards", new[] { "typeOfMotherBoards_ID" });
            DropIndex("dbo.HardDisks", new[] { "typeOfHardDisk_ID" });
            DropIndex("dbo.Enlosures", new[] { "typeOfEnclosures_ID" });
            DropIndex("dbo.AssembliedComputers", new[] { "ram_ID" });
            DropIndex("dbo.AssembliedComputers", new[] { "Processor_ID" });
            DropIndex("dbo.AssembliedComputers", new[] { "PowerSupply_ID" });
            DropIndex("dbo.AssembliedComputers", new[] { "MotherBoard_ID" });
            DropIndex("dbo.AssembliedComputers", new[] { "HardDisk_ID" });
            DropIndex("dbo.AssembliedComputers", new[] { "GraphicCard_ID" });
            DropIndex("dbo.AssembliedComputers", new[] { "Enclosure_ID" });
            DropTable("dbo.TypeOfRAM");
            DropTable("dbo.RAM");
            DropTable("dbo.Processors");
            DropTable("dbo.PowerSupplies");
            DropTable("dbo.TypeOfMotherBoards");
            DropTable("dbo.MotherBoards");
            DropTable("dbo.TypeOfHardDisk");
            DropTable("dbo.HardDisks");
            DropTable("dbo.GraphicCards");
            DropTable("dbo.TypeOfEnclosures");
            DropTable("dbo.Enlosures");
            DropTable("dbo.AssembliedComputers");
        }
    }
}
