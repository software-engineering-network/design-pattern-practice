using System;
using System.Collections.Generic;
using Xunit;

namespace AbstractFactory.Andrew.University.src
{
    public class UnitTest1
    {
        [Fact]
        public void TestEngineeringCollege()
        {
            EngineeringFactory _engineering = new EngineeringFactory();

            University _ofCincinnati = new University(_engineering);
            _ofCincinnati.Enroll();
            Assert.True("Stanley" == _ofCincinnati.ViewEnrolled()[0].Name);
            _ofCincinnati.Deroll();
            Assert.True(0 == _ofCincinnati.ViewEnrolled().Count);
        }

        [Fact]
        public void TestBusinessCollege()
        {
            BusinessFactory _business = new BusinessFactory();

            University _ofCincinnati = new University(_business);
            _ofCincinnati.Enroll();
            Assert.True("Chad" == _ofCincinnati.ViewEnrolled()[0].Name);
            _ofCincinnati.Deroll();
            Assert.True(0 == _ofCincinnati.ViewEnrolled().Count);

        }
    }
}
