namespace Inheritance
{
    class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; protected set; }
        public int Age { get; protected set; }
    }
}