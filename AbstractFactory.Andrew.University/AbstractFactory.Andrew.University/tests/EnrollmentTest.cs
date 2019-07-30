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
            EngineeringFactory engFact = new EngineeringFactory();

            EnrollmentService cincinnati = new EnrollmentService(engFact);
            cincinnati.Enroll();
            Assert.True("Stanley" == cincinnati.ViewEnrolled()[0].Name);
            cincinnati.Deroll();
            Assert.True(0 == cincinnati.ViewEnrolled().Count);
        }

        [Fact]
        public void TestBusinessEnrollment()
        {
            BusinessFactory busFact = new BusinessFactory();

            EnrollmentService cincinnati = new EnrollmentService(busFact);
            cincinnati.Enroll();
            Assert.True("Chad" == cincinnati.ViewEnrolled()[0].Name);
            cincinnati.Deroll();
            Assert.True(0 == cincinnati.ViewEnrolled().Count);

        }
    }
}
