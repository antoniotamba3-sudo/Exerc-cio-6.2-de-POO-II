using System;
using System.Collections.Generic;
using System.Text;

namespace TarefaTamba6._2
{
    public class UnidadeCurricular
    {
        public string Nome { get; set; }
        public Docente Docente { get; set; }

        // Agregação

        private List<Estudante> estudantes = new List<Estudante>();

        // Composição

        private List<Avaliacao> avaliacoes = new List<Avaliacao>();

        public UnidadeCurricular(string nome, Docente docente)
        {
            Nome = nome;
            Docente = docente;
        }

        public void AdicionarEstudante(Estudante e)
        {
            estudantes.Add(e);
        }

        public void AdicionarAvaliacao(Avaliacao a)
        {
            avaliacoes.Add(a);
        }

        public void EmitirPauta()
        {
            var ordenados = estudantes
                .OrderByDescending(e => e.CalcularNotaFinal())
                .ToList();

            Console.WriteLine("=== PAUTA FINAL ===\n");
            

            foreach (var e in ordenados)
            {
                Console.WriteLine($"{e.Nome} - Nota Final: {e.CalcularNotaFinal():F2}");
            }
        }

    }
}
