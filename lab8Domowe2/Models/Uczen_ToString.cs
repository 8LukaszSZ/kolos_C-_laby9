using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8Domowe2.Models
{
    public partial class Uczen
    {
        public override string ToString()
        {
            return $"{Imię} {Nazwisko}, Wiek: {Wiek}, Ocena: {Ocena}";
        }
    }
}
