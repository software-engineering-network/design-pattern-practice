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

        public override void AddProcessor()
        {
            computer.Processor = "Apple A4";
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
