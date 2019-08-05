using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Andrew.University.src
{
    class BusinessFactory : ICollegeFactory
    {
        public Course CreateCourse()
        {
            return new BusinessCourse("Accounting");
        }

        public Student CreateStudent()
        {
            return new BusinessStudent("Chad");
        }
    }
    
    class BusinessCourse : Course
    {
        public BusinessCourse(string ClassName)
        {
            this.ClassName = ClassName;
            this.ClassList = new List<Student>();
        }

        public override void AddStudent(Student stu)
        {
            if (stu is BusinessStudent)
            {
                ClassList.Add(stu);
            }
            else
            {
                new Exception("" + stu.Name + " is not in the Business College");
            }
        }
    }

    class BusinessStudent : Student
    {
        public BusinessStudent(string Name)
        {
            this.Name = Name;
        }
    }
}
