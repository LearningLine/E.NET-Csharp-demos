namespace Linq2Object
{
    internal class Employee
    {
        public string Name { get; set; }
        public string Region { get; set; }
        public int Rating { get; set; }
        public int Salary { get; set; }
        public Gender Gender { get; set; }
    }

    public enum Gender

    {
        Male,
        Female
    }
}