using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Andrew.University.src
{
    class BusinessFactory : CollegeFactory
    {
        public override Course CreateCourse()
        {
            return new BusinessCourse("Accounting");
        }

        public override Student CreateStudent()
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

        public override void AddStudent(Student x)
        {
            if (x is BusinessStudent)
            {
                ClassList.Add(x);
            }
            else
            {
                new Exception("" + x.Name + " is not in the Business College");
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

    class BusinessStudent : Student
    {
        public BusinessStudent(string Name)
        {
            this.Name = Name;
        }
    }
}
