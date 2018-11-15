using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Udemy_Intermediate
{
    public class Person
    {
        public string Name;

        public void Introduce(string to)
        {
            Console.WriteLine("HI {0}, I am {1}", to, Name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.Name = "John";
            person.Introduce("Mosh");
        }
    }
}
