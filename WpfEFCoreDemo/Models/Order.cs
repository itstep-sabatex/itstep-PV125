using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfEFCoreDemo.Models
{
    internal class Order
    {
        public int Id { get; set; }
        public ClientTable ClientTable { get; set; }
        public int ClientTableId { get; set; }
    }
}
