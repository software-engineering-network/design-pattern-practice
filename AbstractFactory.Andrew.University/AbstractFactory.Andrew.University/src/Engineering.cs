using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Andrew.University.src
{
    class EngineeringFactory : ICollegeFactory
    {
        public Course CreateCourse()
        {
            return new EngineeringCourse("Robotics");
        }

        public Student CreateStudent()
        {
            return new EngineeringStudent("Stanley");
        }
    }

    class EngineeringCourse : Course
    {
        public EngineeringCourse(string ClassName)
        {
            this.ClassName = ClassName;
            this.ClassList = new List<Student>();
        }
        public override void AddStudent(Student stu)
        {
            if (stu is EngineeringStudent)
            {
                ClassList.Add(stu);
            }
            else
            {
                new Exception("" + stu.Name + " is not in the Engineering College");
            }
        }
    }

    class EngineeringStudent : Student
    {
        public EngineeringStudent(string Name)
        {
            this.Name = Name;
        }
    }
}
