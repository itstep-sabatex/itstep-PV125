using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharpDemo
{
    public record  Student
    {
        public Student(string name,string firstName,string lastName)
        {
            Name = name;
            FirstName = firstName;
            LastName = lastName;
                
        }

        public string Name { get; set; } = default!;
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
    }
    

    public record struct Point(int X,int Y);

    public class DemoClass:Object
    {
        public Student Student { get; set; }
        //public static string Student = "Petrenco Petro";
        public string Person;
        private string _student;
        protected string BC;
        public const string Name = "2423432";
        public readonly int _id;
        /// <summary>
        /// додавання двох double
        /// </summary>
        /// <param name="a">параметр а (має бути менше 1000 та більше нуля)</param>
        /// <param name="b">параметр b (має бути більше нуля)</param>
        /// <returns>сумма двох даблів </returns>
        public  double Add( ref double a,out double b)
        {

            b = 23;
            a = a + b;
            return a + b + this._id;
        }

        //public double Add(double[] a)
        //{

        //    return 10;
        //}

        //public double Add(params object[] a)
        //{
        //    return 10;
        //}

        public DemoClass()
        {
            _id = 10;
            Person = "Jonn";
        }
        public DemoClass(int id)
        {
            _id = id;
            Person = "Jonn";
            Student = new Student("Петро", "Петренко", "Петрович");
            Student.Name="";
            // Student.ToString() =>"{ Name = Петро, FirstName = Петренко, LastName = Петрович }"
        }
        ~DemoClass(){ }

        static DemoClass()
        {
            //Student = new Student("Петро","Петренко","Петрович");
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
