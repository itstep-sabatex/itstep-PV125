using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge
{
    public abstract class implementor
    {
        public abstract void Operation();
    }

    public class Abstraction
    {
        public static void Do()
        {
            Abstraction ab=new RefinedAbstraction();
            ab.Implementor = new ConcreteImplementorA();
            ab.Operation();

            ab.implementor = new ConcreteImplementorB();
            ab.Operation();

        }
        protected implementor implementor;
        public implementor Implementor { set => implementor = value; }
        public virtual void Operation()
        {
            implementor.Operation();
        }
    }

    public class RefinedAbstraction : Abstraction
    {
        public override void Operation()
        {
            implementor.Operation();
        }
    }

    // rar (low - 1)/(hight - 5) 
    public class ConcreteImplementorA : implementor
    {
        public override void Operation()
        {
            Console.WriteLine("Concrete Implementor A Operation");
        }
    }
    public class ConcreteImplementorB : implementor
    {
        public override void Operation()
        {
            Console.WriteLine("Concrete Implementor B Operation");
        }
    }
}
