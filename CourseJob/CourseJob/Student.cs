using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseJob
{
    public class Student
    {
        public string Name { get; }
        public string Group { get; }
        public Dictionary<string, int> Grades { get; }

        public Student(string name, string group)
        {
            Name = name;
            Group = group;
            Grades = new Dictionary<string, int>();
        }

        public void AddGrade(string subject, int grade)
        {
            Grades[subject] = grade;
        }

        public double GetAverageGrade()
        {
            if (Grades.Count > 0)
            {
                return Grades.Values.Average();
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
