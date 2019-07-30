using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Andrew.University.src
{
    interface ICollegeFactory
    {
        Course CreateCourse();
        Student CreateStudent();
    }

    abstract class Course
    {
        protected List<Student> ClassList;
        public string ClassName;
        public abstract void AddStudent(Student stu);
        public void RemoveStudent(Student stu)
        {
            if (ClassList.Contains(stu))
            {
                ClassList.Remove(stu);
            }
        }
        public List<Student> ViewClassList()
        {
            return ClassList;
        }
    }

    abstract class Student
    {
        public string Name;
    }
}
