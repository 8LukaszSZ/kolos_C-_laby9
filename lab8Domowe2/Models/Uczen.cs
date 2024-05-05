using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8Domowe2.Models
{
    [Table("Uczniowie")]
    public partial class Uczen
    {
        [Key]
        public int UczenId { get; set; }
        [Column("Imie")]
        [MaxLength(30)]
        public string Imię { get; set; } = "";
        [MaxLength(50)]
        public string Nazwisko { get; set; } = "";
        public double? Ocena { get; set; }
        public byte Wiek { get; set; }
    }
}
