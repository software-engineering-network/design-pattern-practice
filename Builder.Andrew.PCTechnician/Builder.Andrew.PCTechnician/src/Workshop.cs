using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Andrew.PCTechnician.src
{
    class Workshop
    {
        public void Assemble(ComputerBuilder computerBuilder)
        {
            computerBuilder.AddMotherboard();
            computerBuilder.AddProcessor();
            computerBuilder.AddStorage();
            computerBuilder.AddMemory();
            computerBuilder.AddCooling();
        }
    }
}
