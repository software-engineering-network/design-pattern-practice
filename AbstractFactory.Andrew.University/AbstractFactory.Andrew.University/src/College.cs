using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Andrew.University.src
{
    abstract class CollegeFactory
    {
        public abstract Course CreateCourse();
        public abstract Student CreateStudent();
    }

    abstract class Course
    {
        protected List<Student> ClassList;
        public string ClassName;
        public abstract void AddStudent(Student x);
        public abstract void RemoveStudent(Student x);
        public abstract List<Student> ViewClassList();
    }

    abstract class Student
    {
        public string Name;
    }
}
