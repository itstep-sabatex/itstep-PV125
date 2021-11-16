using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCDemo
{
    internal class DemoClass:IDisposable
    {
        public string FirstName { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int GroupId { get; set; }
        private bool _disposed=false;
        ~DemoClass()
        {
            Dispose();
            
        }

        
        public void Dispose()
        {
            if (!_disposed)
            {
                // dispose resurce
                Name = null;

                _disposed=true;

            }
        }
    }
}
