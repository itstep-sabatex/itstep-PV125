using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    internal interface IBuilder
    {
        void Reset();
        void BuildStep1();
        void BuildStep2();
        void BuildStep3();
        Product GetObject();
    }

    internal class Director
    {
        IBuilder _builder;
        public Director(IBuilder builder)
        {
            _builder = builder;
        }
        public void ChangeBuilder(IBuilder builder)
        {
            _builder = builder; 
        }

        public IBuilder Make()
        {
            _builder.BuildStep1();
            _builder.BuildStep2();
            _builder.BuildStep3();
            return _builder;
        }


        public static void Demo()
        {
            var builder= new Builder2();
            //builder.BuildStep1();
            //builder.BuildStep3();
           //Console.WriteLine(builder.GetResult().ToString());

        }

    }



    public class Product
    {
        private List<string> _parts = new List<string>();
        public void AddPart(string part)=>_parts.Add(part);
        public override string ToString()
        {
            var result = new StringBuilder("Product parts:\n");
            foreach (var part in _parts) result.Append($"{part}\n");
            return result.ToString();
        }
    }

    public class Builder1 : IBuilder
    {
        private Product _product = new Product();
        public void BuildStep1()
        {
            _product.AddPart("Part1");
        }

        public void BuildStep2()
        {
            _product.AddPart("Part2");
        }

        public void BuildStep3()
        {
            _product.AddPart("Part3");
        }

        public Product GetObject()
        {
            return _product;
        }

        public void Reset()
        {
            _product = new Product();
        }
    }

    public class Builder2 : IBuilder
    {
        private Product _product = new Product();
        public void BuildStep1()
        {
            _product.AddPart("Part1X");
        }

        public void BuildStep2()
        {
            _product.AddPart("Part2X");
        }

        public void BuildStep3()
        {
            _product.AddPart("Part3X");
        }

        public Product GetObject()
        {
            return _product;
        }

        public void Reset()
        {
            _product = new Product();
        }
    }




}
