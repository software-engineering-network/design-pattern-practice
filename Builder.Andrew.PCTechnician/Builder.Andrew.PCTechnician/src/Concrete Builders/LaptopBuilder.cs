using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Andrew.PCTechnician.src.Concrete_Builders
{
    class LaptopBuilder : ComputerBuilder
    {
        public LaptopBuilder()
        {
            computer = new Computer("Laptop");
        }

        public override void AddProcessor()
        {
            computer.Processor = "Intel Core Duo";
        }

        public override void AddStorage()
        {
            computer.Storage = "5400 RPM HDD";
        }

        public override void AddMemory()
        {
            computer.Memory = "Williams-Kilburn Tube Array";
        }

        public override void AddCooling()
        {
            computer.Cooling = "Single Small Fan";
        }
    }
}
