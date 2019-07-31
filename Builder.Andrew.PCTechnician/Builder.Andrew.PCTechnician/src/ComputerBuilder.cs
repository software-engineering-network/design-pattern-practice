using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Andrew.PCTechnician.src
{
    abstract class ComputerBuilder
    {
        protected Computer computer;

        public Computer Computer
        {
            get { return computer; }
        }

        public abstract void AddProcessor();
        public abstract void AddStorage();
        public abstract void AddMemory();
        public abstract void AddCooling();
    }
}
