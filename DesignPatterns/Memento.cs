using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Memento
{
    public class Originator
    {
        string state;
        public string State
        {
            get { return state; }
            set 
            {
                state = value;
                Console.WriteLine("State=" + state);
            }
        }

        public Memento CreateMemento()
        {
            return new Memento(state);
        }

        public void SetMemento(Memento memento)
        {
            Console.WriteLine("Restoring state ...");
            state = memento.State;
        }
    }


    public class Memento
    {
        public static void Do()
        {
            Originator originator = new Originator();
            originator.State = "On";
            
            Caretaker caretaker = new Caretaker();
            caretaker.Memento = originator.CreateMemento();

            originator.State = "Off";

            originator.SetMemento(caretaker.Memento);
        }


        string stste; 
        public Memento(string state)
        {
            this.stste = state;
        }
        public string State => stste;
    }



    public class Caretaker
    {
        Memento memento;
        public Memento Memento { get=>memento; set=>memento=value; }
    }
}
