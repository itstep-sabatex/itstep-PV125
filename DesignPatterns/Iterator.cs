using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public abstract class Iterator
    {
        public static void Do()
        {
            ConcreteAggregate a = new ConcreteAggregate();
             foreach (var it in a)
            {

            }

            Iterator i = a.CreateIterator();
            object item = null;
            do
            {
                item = i.Next();

            } while (item != null); 
        }


        public abstract object Next();
        public abstract void First();
        public abstract bool IsDone();
        public abstract object CurrentItem();
    }

    public abstract class Aggregate
    {
        public abstract Iterator CreateIterator();
    } 


    public class ConcreteAggregate : Aggregate,IEnumerable
    {
        

        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int Count=> 5;
        public object this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0: return "one item";
                    case 1: return "o ho ho";
                    default: return "null";
                }
            }
        }
    }

    public class CharpEnumerator : IEnumerator
    {
        ConcreteAggregate aggregate;
        int current = 0;

        public object Current => aggregate[current];

        public bool MoveNext()
        {   
            current++;
            if (current < aggregate.Count)
            {
                return true;
            }
            return false;
        }

        public void Reset()
        {
            current=0;
        }
    }


    public class ConcreteIterator : Iterator
    {
        ConcreteAggregate aggregate;
        int current = 0;
        public ConcreteIterator(ConcreteAggregate aggregate)
        {
            this.aggregate = aggregate;   
        }


        public override object CurrentItem()
        {
            return aggregate[current];
        }

        public override void First()
        {
            current = 0;
        }

        public override bool IsDone()
        {
            return current >=aggregate.Count;
        }

        public override object Next()
        {
            if (current < aggregate.Count -1)
                return aggregate[++current];
            else
                return null;
        }
    }


}
