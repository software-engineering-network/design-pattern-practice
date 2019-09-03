using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Andrew.PCTechnician.src.Concrete_Builders
{
    class TabletBuilder : ComputerBuilder
    {
        public TabletBuilder()
        {
            computer = new Computer("Tablet");
        }

        public override void AddMotherboard()
        {
            Random random = new Random();
            int selector = random.Next(2); //50/50 shot that you bought the right part
            switch (selector)
            {
                case 0: //accidental headphone jack
                    computer.Motherboard = "Iphone 4 SoC";
                    break;
                case 1: //this one will fit
                    computer.Motherboard = "A4 x999 prototype";
                    break;
            }
        }

        public override void AddProcessor()
        {
            if (computer.Motherboard == "Iphone 4 SoC")
            {
                throw new Exception("Oh no! The processor you bought cannot drive the headphone jack on this board.");
            }
            else computer.Processor = "Apple A4";
        }

        public override void AddStorage()
        {
            computer.Storage = "16 GB Flash";
        }

        public override void AddMemory()
        {
            computer.Memory = "2GB RAM";
        }

        public override void AddCooling()
        {
            computer.Cooling = "Passive";
        }
    }
}
