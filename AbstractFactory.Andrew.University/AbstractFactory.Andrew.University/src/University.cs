using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Andrew.University.src
{
    //"Client" entity
    class EnrollmentService
    {
        private Course _course;
        private Student _student;

        public EnrollmentService(ICollegeFactory factory)
        {
            _course = factory.CreateCourse();
            _student = factory.CreateStudent();
        }

        public void Enroll()
        {
            _course.AddStudent(_student);
        }

        public void Deroll()
        {
            _course.RemoveStudent(_student);
        }

        public List<Student> ViewEnrolled()
        {
            return _course.ViewClassList();
        }
    }
}
