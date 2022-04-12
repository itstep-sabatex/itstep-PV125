using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfEFCoreDemo.Models
{
    internal class Student
    {
        [Key]
        public int Id { get; set; }
        [Column("NameStudent",TypeName ="varchar(100)")]
        //[MaxLength(50)]
        
        public string Name { get; set; }
        [Comment("День народження")]
        public DateTime BirthDay { get; set; }
        public int StudentGroupId { get; set; }
        
    }
}
