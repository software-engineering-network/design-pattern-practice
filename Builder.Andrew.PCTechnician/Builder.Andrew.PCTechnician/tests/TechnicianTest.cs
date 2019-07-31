using Builder.Andrew.PCTechnician.src;
using Builder.Andrew.PCTechnician.src.Concrete_Builders;
using System;
using Xunit;

namespace Builder.Andrew.PCTechnician
{
    public class TechnicianTest
    {
        private readonly Workshop _workshop = new Workshop();

        [Fact]
        public void TestDesktopBuilder()
        {
            ComputerBuilder technician = new DesktopBuilder();
            _workshop.Assemble(technician);
            var contents = technician.Computer.LookInside();
            Assert.True(contents["processor"] == "Pentium Uno");
            Assert.True(contents["storage"] == "Samsung 2TB NVMe M.2 SSD");
            Assert.True(contents["memory"] == "Corsair 4x8GB 3200MHz");
            Assert.True(contents["cooling"] == "360mm Radiator");
        }

        [Fact]
        public void TestLaptopBuilder()
        {
            ComputerBuilder technician = new LaptopBuilder();
            _workshop.Assemble(technician);
            var contents = technician.Computer.LookInside();
            Assert.True(contents["processor"] == "Intel Core Duo");
            Assert.True(contents["storage"] == "5400 RPM HDD");
            Assert.True(contents["memory"] == "Williams-Kilburn Tube Array");
            Assert.True(contents["cooling"] == "Single Small Fan");
        }

        [Fact]
        public void TestTabletBuilder()
        {
            ComputerBuilder technician = new TabletBuilder();
            _workshop.Assemble(technician);
            var contents = technician.Computer.LookInside();
            Assert.True(contents["processor"] == "Apple A4");
            Assert.True(contents["storage"] == "16 GB Flash");
            Assert.True(contents["memory"] == "2GB RAM");
            Assert.True(contents["cooling"] == "Passive");
        }
    }
}
