using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public static class Demo
    {
        public static void Execute()
        {
            Target target = new Target();
            target.Request();
            target = new Adapter();
            target.Request();
        }
    }


    internal class Target
    {
        public virtual string Name { get; set; }
        public virtual string Surname { get; set; }
        public virtual string LastName { get; set; }

        public virtual void Request()
        {
            Console.WriteLine("Called target request()");
        }

    }


    internal class Adapter:Target
    {
        private Adaptee _adaptee = new Adaptee();
        public override void Request()
        {
            _adaptee.SpecificRequest();
        }

    }
    internal class Adaptee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string SecondName { get; set; }

        public void SpecificRequest()
        {
            Console.WriteLine("Called specificRequest()");
        }
    }
}
