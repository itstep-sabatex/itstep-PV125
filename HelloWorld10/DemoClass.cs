using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld10
{
    public class DemoClass:Object
    {
        public static string Student = "Petrenco Petro";
        public string Person;
        private string _student;
        protected string BC;
        public const string Name = "2423432";
        public readonly int _id;

        public  double Add( ref double a,out double b)
        {

            b = 23;
            a = a + b;
            return a + b + this._id;
        }

        public double Add(double[] a)
        {

            return 10;
        }

        public double Add(params object[] a)
        {
            return 10;
        }

        public DemoClass()
        {
            _id = 10;
            Person = "Jonn";
        }
        public DemoClass(int id)
        {
            _id = id;
            Person = "Jonn";
        }
        ~DemoClass(){ }

        static DemoClass()
        {
            Student = "wiuehiw";
        }

    }

    public class MyClass : DemoClass
    {
        public int MyProperty 
        { 
            get // int get(){}
            { 
                return B;
            }
            set // void set(int value){}
            {
                B += value;

            }
        }
        public int DemoProperty { get; set; }

        int B;
        void Test()
        {
            
        }
    }

}
