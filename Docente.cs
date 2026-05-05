using System;
using System.Collections.Generic;
using System.Text;

namespace TarefaTamba6._2
{
    public abstract class Docente : Pessoa
    {
        public Docente(string nome, int id) : base(nome, id) { }
    }
    public class Titular : Docente
    {
        public Titular(string nome, int id) : base(nome, id) { }
    }
    public class Assistente : Docente
    {
        public Assistente(string nome, int id) : base(nome, id) { }
    }


}



