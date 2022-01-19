using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Flyweight
{

    public class FlyweightFactory
    {
        private Dictionary<string, Flyweight> _flyweights= new Dictionary<string, Flyweight>();
        public FlyweightFactory()
        {
            _flyweights.Add("X", new ConcreteFlyweight());
            _flyweights.Add("Y", new ConcreteFlyweight());
            _flyweights.Add("Z", new ConcreteFlyweight());
        }
        public Flyweight GetFlyweight(string key)
        {
            return (Flyweight)_flyweights[key];
        }

    }


    public abstract class Flyweight
    {
        public static void Do()
        {
            int extrinsistate = 22;
            var factory = new FlyweightFactory();
            var fx = factory.GetFlyweight("X");
            fx.Operation(--extrinsistate);
            var fy = factory.GetFlyweight("Y");
            fy.Operation(--extrinsistate);
            var fz = factory.GetFlyweight("Z");
            fz.Operation(--extrinsistate);
            var fxx = factory.GetFlyweight("X");
            fxx.Operation(--extrinsistate);


            var fu = new UnsharedConcreteFlyweight();
            fu.Operation(--extrinsistate);

        }
        public abstract void Operation(int extrinsicstate);
    }


    public class ConcreteFlyweight : Flyweight
    {
        public override void Operation(int extrinsicstate)
        {
            Console.WriteLine("ConcreteFlyweght: "+ extrinsicstate);
        }
    }
    public class UnsharedConcreteFlyweight : Flyweight
    {
        public override void Operation(int extrinsicstate)
        {
            Console.WriteLine("UnsharedConcreteFlyweght: " + extrinsicstate);
        }
    }

}
