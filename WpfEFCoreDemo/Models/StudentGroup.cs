using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfEFCoreDemo.Models
{
    [Table("StudentGroups")]
    [Comment("My table")]
    internal class StudentGroup
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();
        public string Прізвище { get; set; }
    }
}

