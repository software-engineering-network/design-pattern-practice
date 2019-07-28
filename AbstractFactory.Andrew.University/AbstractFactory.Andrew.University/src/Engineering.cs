using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Andrew.University.src
{
    class EngineeringFactory : CollegeFactory
    {
        public override Course CreateCourse()
        {
            return new EngineeringCourse("Robotics");
        }

        public override Student CreateStudent()
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
        public override void AddStudent(Student x)
        {
            if (x is EngineeringStudent)
            {
                ClassList.Add(x);
            }
            else
            {
                new Exception("" + x.Name + " is not in the Engineering College");
            }
        }
        public override void RemoveStudent(Student x)
        {
            if (ClassList.Contains(x))
            {
                ClassList.Remove(x);
            }
        }
        public override List<Student> ViewClassList()
        {
            return ClassList;
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
