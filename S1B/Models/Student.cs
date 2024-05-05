using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1B.Models
{
    [Table("Studenci")]

    public partial class Student
    {
        [Key]
        public int StudentId { get; set; }
        [Column("Imie")]
        [MaxLength(30)]
        public string Imię { get; set; } = "";
        [MaxLength(50)]
        public string Nazwisko { get; set; } = "";
        public double? Ocena { get; set; }
        public byte Wiek {  get; set; }
    }
}
