using System;
using System.Collections.Generic;
using System.Text;

namespace TarefaTamba6._2
{
    public abstract class Pessoa
    {
        public string Nome { get; set; }
        public int Id { get; set; }

        public Pessoa(string nome, int id)
        {
            Nome = nome;
            Id = id;
        }

    }
}
