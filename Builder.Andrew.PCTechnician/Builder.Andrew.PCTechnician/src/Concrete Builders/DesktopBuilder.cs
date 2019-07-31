using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Andrew.PCTechnician.src.Concrete_Builders
{
    class DesktopBuilder : ComputerBuilder
    {
        public DesktopBuilder()
        {
            computer = new Computer("Desktop");
        }

        public override void AddProcessor()
        {
            computer.Processor = "Pentium Uno";
        }

        public override void AddStorage()
        {
            computer.Storage = "Samsung 2TB NVMe M.2 SSD";
        }

        public override void AddMemory()
        {
            computer.Memory = "Corsair 4x8GB 3200MHz";
        }

        public override void AddCooling()
        {
            computer.Cooling = "360mm Radiator";
        }
    }
}
