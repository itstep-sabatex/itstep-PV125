using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    internal abstract class Component
    {
        protected string name;
        public Component(string name)
        {
            this.name = name;
        }
        public abstract int GetSize();


        public abstract void Add(Component c);
        public abstract void Remove(Component c);
        public abstract Component GetChield(int index);
        public abstract void Display(int level);
    }


    internal class Folder : Component
    {
        List<Component> components = new List<Component>();
        public Folder(string name):base(name)
        {
        
        }


        public override void Add(Component c)
        {
            components.Add(c);
        }

        public override void Display(int level)
        {

            Console.WriteLine($"folder - {name} - {GetSize()}".PadLeft(level*4,' '));
            foreach (Component c in components)
            {
                c.Display(level+1);
            }
        }

        public override Component GetChield(int index)
        {
            return components[index];
        }

        public override int GetSize()
        {
            int result = 0;
            foreach (Component c in components)
            {
                result=result +c.GetSize();
            }
            return result;
        }

        public override void Remove(Component c)
        {
            components.Remove(c);
        }
   
        
    
    }

    internal class File : Component
    {
        protected int size;
        public File(string name,int size):base(name)
        {
            this.size = size;
        }

        public override void Add(Component c)
        {
            throw new NotImplementedException();
        }

        public override void Display(int level)
        {
            var s = $"file - {name} - {GetSize()}";
            //s.Append(' ', level * 4);
            Console.WriteLine(s. PadLeft(level * 4, ' '));
        }

        public override Component GetChield(int index)
        {
            throw new NotImplementedException();
        }

        public override int GetSize()
        {
            return size;
        }

        public override void Remove(Component c)
        {
            throw new NotImplementedException();
        }
    }


    public static class CompositeDemo
    {
        public static void Do()
        {
            var root = new Folder("root");
            root.Add(new File("A",100));
            root.Add(new File("C",150));
            root.Add(new File("D",23));
            var c1 = new Folder("E");
            root.Add(c1);
            c1.Add(new File("EA",35));
            c1.Add(new File("EC",46));
            root.Add(new Folder("F"));
            root.Display(0);
        }
    }


}
