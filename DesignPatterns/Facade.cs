using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FacadeDemo
{
    public class SubSystemOne
    {
        public void MrthodOne()
        {
            Console.WriteLine("SubsustemOne Method");
        }
    }
    public class SubSystemTwo
    {
        public void MrthodTwo()
        {
            Console.WriteLine("SubsustemTwo Method");
        }
    }
    public class SubSystemThree
    {
        public void MrthodThree()
        {
            Console.WriteLine("SubsustemThree Method");
        }
    }
    public class SubSystemFour
    {
        public void MrthodFour()
        {
            Console.WriteLine("SubsustemFour Method");
        }
    }

    public class Facade
    {
        SubSystemOne one = new SubSystemOne();
        SubSystemTwo two = new SubSystemTwo();
        SubSystemThree three = new SubSystemThree();
        SubSystemFour four = new SubSystemFour();
        public Facade()
        {
            one = new SubSystemOne();
            two = new SubSystemTwo();
            three = new SubSystemThree();
            four = new SubSystemFour();

        }
        public void MethodA()
        {
            Console.WriteLine("Method A");
            one.MrthodOne();
            two.MrthodTwo();
            four.MrthodFour();
        }
        public void MethodB()
        {
            Console.WriteLine("Method B");
            two.MrthodTwo();
            three.MrthodThree();
        }
    }
}
