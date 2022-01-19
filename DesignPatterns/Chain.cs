using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Chain
{

    public abstract class Handler
    {
        public static void Do()
        {
            var h1 = new ConcreteHandler1();
            var h2 = new ConcreteHandler2();
            var h3 = new ConcreteHandler3();
            h1.SetSuccessor(h2);
            h2.SetSuccessor(h3);

            int[] requesrts = { 2, 5, 4, 8, 1, 30, 34, 21, 78, 34, 23, 12, 35 };
            foreach (int i in requesrts) h1.HandleRequest(i);

        }
        protected Handler successor;
        public void SetSuccessor(Handler successor)
        {
            this.successor = successor;
        }
        public abstract void HandleRequest(int request);
    }

    public class ConcreteHandler1 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 0 && request <10)
            {
                Console.WriteLine($"{this.GetType().Name} handle request {request}");
            }
            else if (successor != null)
            {
                successor.HandleRequest(request);
            }
        }
    }

    public class ConcreteHandler2 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 10 && request < 20)
            {
                Console.WriteLine($"{this.GetType().Name} handle request {request}");
            }
            else if (successor != null)
            {
                successor.HandleRequest(request);
            }
        }
    }
    public class ConcreteHandler3 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 20 && request < 30)
            {
                Console.WriteLine($"{this.GetType().Name} handle request {request}");
            }
            else if (successor != null)
            {
                successor.HandleRequest(request);
            }
        }
    }
 
}
