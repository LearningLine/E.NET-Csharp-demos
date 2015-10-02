namespace Inheritance
{
    internal class Student : Person
    {
        public Student(string name, int age, string id, int grade)
            : this(name, age, id)
        {
            Grade = grade;
        }

        public Student(string name, int age, string id)
            : base(name, age)
        {
            Id = id;
        }

        public int Grade { get; set; }
        public string Id { get; set; }
    }
}