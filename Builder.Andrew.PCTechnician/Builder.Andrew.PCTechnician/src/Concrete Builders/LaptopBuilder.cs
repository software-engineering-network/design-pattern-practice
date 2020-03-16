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

        public override void AddMotherboard()
        {
            Random random = new Random();
            int selector = random.Next(2); //50/50 shot that you bought the right part
            switch (selector)
            {
                case 0: //low on memory sockets
                    computer.Motherboard = "Verizon Mobile Computing Platform x123";
                    break;
                case 1: //this one will suffice
                    computer.Motherboard = "Lenovo Ideapad P400";
                    break;
            }
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
            if (computer.Motherboard == "Verizon Mobile Computing Platform x123")
            {
                throw new Exception("Oh no! That board doesn't have the proper connectivity for the Tube Memory! :(");
            }
            else computer.Memory = "Williams-Kilburn Tube Array";
        }

        public override void AddCooling()
        {
            computer.Cooling = "Single Small Fan";
        }
    }
}
