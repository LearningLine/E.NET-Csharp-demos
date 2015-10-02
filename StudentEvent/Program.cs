using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEvent
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.GradeChanged += (sender, grade) =>
            {
                Console.WriteLine("grade changed to " + grade);
            };
            s.Grade = 1;
            s.Grade = 2;
            s.Grade = 3;
            Console.Read();
        }
    }

    public class Student
    {
        private int grade;

        public int Grade
        {
            get { return grade; }
            set
            {
                grade = value;
                GradeChanged?.Invoke(this, value);
            }
        }

        public event EventHandler<int> GradeChanged;

    }
}
