using System;
using System.Collections.Generic;
using System.Text;

namespace TarefaTamba6._2
{
    public class Estudante: Pessoa, IAvaliavel
    {
        private List<Avaliacao> avaliacoes = new List<Avaliacao>();

        public Estudante(string nome, int id) : base(nome, id) { }

        public void AdicionarAvaliacao(Avaliacao a)
        {
            avaliacoes.Add(a);
        }

        public double CalcularNotaFinal()
        {
            if (avaliacoes.Count == 0) return 0;

            double soma = avaliacoes.Sum(a => a.Nota * a.Peso);
            double totalPesos = avaliacoes.Sum(a => a.Peso);

            return totalPesos == 0 ? 0 : soma / totalPesos;
        }

    }
}
