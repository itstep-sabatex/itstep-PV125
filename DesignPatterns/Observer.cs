using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public abstract class Observer
    {
        public static void Do()
        {

        }
        public abstract void Update();
    }

    public abstract class Subject
    {
        private List<Observer> observers = new List<Observer>();
        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }
        public void Detach(Observer observer)
        {
            observers.Remove(observer);
        }
        public void Notify()
        {
            foreach (Observer observer in observers)
            {
                observer.Update();
            }
        }
    }

    public class ConcreteSubject:Subject
    {
        private string _subjectState;

        public string SubjectState
        {
            get { return _subjectState; }
            set { _subjectState = value; }
        }

    }


    public class ConcreteObserver : Observer
    {
        private string name;
        private string observerState;
        private ConcreteSubject subject;
        public ConcreteObserver(ConcreteSubject subject,string name)
        {
            this.subject = subject;
            this.name = name;

        }

        public override void Update()
        {
            observerState = subject.SubjectState;
            Console.WriteLine("Observer {0}' s new state is {1}", name, observerState);
        }

        public ConcreteSubject Subject
        {
            get { return subject; }
            set { subject = value; }
        }


    }



}
