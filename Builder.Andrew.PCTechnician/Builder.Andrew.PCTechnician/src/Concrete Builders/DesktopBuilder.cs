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

        public override void AddMotherboard()
        {
            Random random = new Random();
            int selector = random.Next(2); //50/50 shot that you bought the right part
            switch (selector)
            {
                case 0: //AMD board, processor won't fit
                    computer.Motherboard = "MSI x470 AM4";
                    break;
                case 1: //this one will fit
                    computer.Motherboard = "Gigabyte B360M LGA1151";
                    break;
            }
        }

        public override void AddProcessor()
        {
            if (computer.Motherboard == "MSI x470 AM4" )
            {
                throw new Exception("Oh no! The processor you bought will not fit in the socket on this motherboard.");
            }
            else computer.Processor = "Pentium Uno";
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
