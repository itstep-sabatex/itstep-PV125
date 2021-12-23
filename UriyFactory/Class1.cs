namespace UriyFactory
{
    public abstract class Product
    {
        public int Height { get; set; }
        public int Width { get; set; }

    }
    public abstract class Creator
    {
        public abstract Product FactoryMethod();
        public static Product Create(Creator creator, int widnt, int height)
        {
            var result = creator.FactoryMethod();
            result.Height = height;
            result.Width = widnt;
            return result;
        }
        public static T Create<T>(int widnt, int height) where T : Product, new()
        {
            T result = new T();
            result.Height = height;
            result.Width= widnt;
            return result;
        }


        public static void Initial(Product result, int widnt, int height)
        {
           
            result.Height = height;
            result.Width = widnt;
        }

    }
    public class ConcreteProductA : Product
    {

    }

    public class ConcreteProductB : Product
    {

    }

    public class ConcreteCreatorA : Creator
    {
        public override Product FactoryMethod()
        {
            return new ConcreteProductA();
        }
    }

    public class ConcreteCreatorB : Creator
    {
        public override Product FactoryMethod()
        {
            return new ConcreteProductB();
        }
    }


}