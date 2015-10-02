using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAttributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Name = "Alice";

            Serialize(p);
            Console.Read();
        }

        private static void Serialize(object p)
        {
            foreach (var property in p.GetType().GetProperties())
            {
                var value = property.GetValue(p);
                var propertyName = property.Name;
                var attribute = property.GetCustomAttributes(true).OfType<SerializeAsAttribute>().FirstOrDefault();
                if (attribute != null)
                {
                    propertyName = attribute.Name;
                }
                Console.WriteLine(propertyName  + " -> " + value);
            }
        }
    }

    public class CommentAttribute : Attribute
    {
        public CommentAttribute(string text)
        {
            
        }
    }

    public class SerializeAsAttribute : Attribute
    {
        public string Name { get; set; }

        public SerializeAsAttribute(string name)
        {
            Name = name;
        }
    }

    [Comment("this is an interesting class")]
    class Person
    {
        [SerializeAs("FullName")]
        public string Name { get; set; }

        [Comment("this is an interesting method")]
        public void Test([Comment("whatever")]int i)
        {
            
        }
    }
}
