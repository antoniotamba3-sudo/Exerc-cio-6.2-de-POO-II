using System;
using System.Collections.Generic;
using System.Text;

namespace TarefaTamba6._2
{
    public abstract class Avaliacao
    {
        public double Nota { get; set; }
        public double Peso { get; set; }

        public Avaliacao(double nota, double peso)
        {
            Nota = nota;
            Peso = peso;

        }
    }
}
