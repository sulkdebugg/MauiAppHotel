using System;
using System.Collections.Generic;
using System.Text;

namespace MauiAppEventos.Models
{
    public class Evento
    {
        public string NomeEvento { get; set; }

        public DateTime DataInicio { get; set; } = DateTime.Now;

        public DateTime DataTermino { get; set; } = DateTime.Now;

        public int NumeroParticipantes { get; set; }

        public string LocalEvento { get; set; }

        public double CustoPorParticipante { get; set; }

        // Calcula duração do evento
        public TimeSpan DuracaoEvento
        {
            get
            {
                return DataTermino - DataInicio;
            }
        }

        // Calcula custo total
        public double CustoTotal
        {
            get
            {
                return NumeroParticipantes * CustoPorParticipante;
            }
        }
    }
}