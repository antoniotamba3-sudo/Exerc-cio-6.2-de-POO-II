using System;
using System.Collections.Generic;
using System.Text;

namespace TarefaTamba6._2
{
    public class Teste: Avaliacao
    {

    public Teste(double nota) : base(nota, 0.3) { }
    }
    public class Projeto : Avaliacao
    {
        public Projeto(double nota) : base(nota, 0.4) { }
    }
    public class ExameFinal : Avaliacao
    {
        public ExameFinal(double nota) : base(nota, 0.3) { }
    }

}

