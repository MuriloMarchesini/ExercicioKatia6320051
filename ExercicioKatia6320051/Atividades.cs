using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioKatia6320051
{
    public class Atividades
    {
        public string Nome { get; set; }
        public string Local { get; set; }
        public DateTime Data { get; set; }
        public string Hora { get; set; }

        public void Calcular()
        {
            Consumo c = new Consumo();
            c.Calcular();
        }

    }
}
