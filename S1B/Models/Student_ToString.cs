using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1B.Models
{
    public partial class Student
    {
        public override string ToString()
        {
            return $"{Imię} {Nazwisko}, Wiek: {Wiek}, Ocena: {Ocena}";
        }
    }
}
