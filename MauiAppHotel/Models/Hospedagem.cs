using System;
using System.Collections.Generic;
using System.Text;

namespace MauiAppHotel.Models
{
    public class Hospedagem
    {
        public Quarto suite { get; set; }
        public int qntadultos { get; set; }

        public int qntcriancas { get; set; }

        public DateTime datacheckin { get; set; }

        public DateTime datacheckout { get; set; }

    
    }
}
