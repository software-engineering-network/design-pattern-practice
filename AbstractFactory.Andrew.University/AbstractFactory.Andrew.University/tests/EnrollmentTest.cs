using System;
using System.Collections.Generic;
using Xunit;

namespace AbstractFactory.Andrew.University.src
{
    public class EnrollmentTest
    {
        [Fact]
        public void TestEngineeringEnrollmentt()
        {
            EngineeringFactory EngFact = new EngineeringFactory();

            EnrollmentService Cincinnati = new EnrollmentService(EngFact);
            Cincinnati.Enroll();
            Assert.True("Stanley" == Cincinnati.ViewEnrolled()[0].Name);
            Cincinnati.Deroll();
            Assert.True(0 == Cincinnati.ViewEnrolled().Count);
        }

        [Fact]
        public void TestBusinessEnrollment()
        {
            BusinessFactory BusFact = new BusinessFactory();

            EnrollmentService Cincinnati = new EnrollmentService(BusFact);
            Cincinnati.Enroll();
            Assert.True("Chad" == Cincinnati.ViewEnrolled()[0].Name);
            Cincinnati.Deroll();
            Assert.True(0 == Cincinnati.ViewEnrolled().Count);

        }
    }
}
