using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfEFCoreDemo.Models
{
    internal class ClientTable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Order> Orders { get; set; }
    }
}
