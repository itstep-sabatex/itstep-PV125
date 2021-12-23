using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public abstract class ProductA
    {
    }
    public abstract class ProductB
    {
    }

    public class ProductA1 : ProductA { }
    public class ProductA2 : ProductA { }
    public class ProductB1 : ProductB { }
    public class ProductB2 : ProductB { }


    public abstract class AbstractFactory
    {
        public abstract ProductA CreateProductA();
        public abstract ProductB CreateProductB();
    }

    public class ConcreteFactory1 : AbstractFactory
    {
        public override ProductA CreateProductA()
        {
            return new ProductA1();
        }

        public override ProductB CreateProductB()
        {
            return new ProductB1();
        }
    }
    public class ConcreteFactory2 : AbstractFactory
    {
        public override ProductA CreateProductA()
        {
            return new ProductA2();
        }

        public override ProductB CreateProductB()
        {
            return new ProductB2();
        }
    }

    public class Client
    {
        private ProductA _productA;
        private ProductB _productB;
        public Client(AbstractFactory factory)
        {
            _productA = factory.CreateProductA();
            _productB = factory.CreateProductB();
        }
        public void Run() { }
    }
    


}
