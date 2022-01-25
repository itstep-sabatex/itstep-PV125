using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{



    public abstract class State
    {
        public static void Do()
        {
            var context = new Context(new ConcreteStateA());
            context.Request();
            context.Request();
            context.Request();
            context.Request();
        }

        public abstract void Handle(Context context);
    }
    public class ConcreteStateA:State
    {
        public override void Handle(Context context)
        {
            context.State=new ConcreteStateB();
        }
    }
    public class ConcreteStateB : State
    {
        public override void Handle(Context context)
        {
            context.State = new ConcreteStateA();
        }
    }


    public class Context
    {
        State state;
        public Context(State state)
        {
            this.state = state;
        }

        public State State
        {
            get =>state;
            set 
            {
                state = value;
                Console.WriteLine("State: " + state.GetType().Name);
            }
        }

        public void Request()
        {
            state.Handle(this);
        }

    }
}
