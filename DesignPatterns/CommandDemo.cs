using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    
    public abstract class Command
    {
        protected Receiver reciver;
        public Command(Receiver receiver)
        {
            this.reciver = receiver;
        }
        public abstract void Execute();
    }

    public class ConcreteCommand:Command
    {
        public ConcreteCommand(Receiver receiver):base(receiver)
        {

        }

        public override void Execute()
        {
            reciver.Action();
        }
    }

    public class Receiver
    {
        public void Action()
        {
            Console.WriteLine("Called Receiver.Action");
        }
    }

    public class Invorer
    {
        Command command;
        public void SetCommand(Command command)
        {
            this.command = command;
        }

        public void ExecuteCommand()
        {
            command.Execute();
        }
    }


}
