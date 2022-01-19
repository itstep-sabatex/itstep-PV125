using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    internal class Singelton
    {
        private Singelton()
        {
                
        }
        private static Singelton instance;
        public static Singelton GetInstance()
        {
            if (instance == null)
            {
                instance = new Singelton();
            }
            return instance;
        }

        public List<string> Catalog = new List<string>();

    }
}
