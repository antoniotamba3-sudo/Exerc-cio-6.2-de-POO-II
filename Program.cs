using TarefaTamba6._2;

public class Program
{
    static void Main()
    {
        Docente docente = new Titular("JOÃO NSAKU VENTURA", 1);
        UnidadeCurricular uc = new UnidadeCurricular("POO II", docente);

        Estudante e1 = new Estudante("ANTÓNIO LOPES TAMBA", 101);
        Estudante e2 = new Estudante("LUKOMBO DAVID", 102);
        Estudante e3 = new Estudante("JEREMIAS MANUEL", 103);
        Estudante e4 = new Estudante("KULA ROMANO S. TAMBA", 104);
        Estudante e5 = new Estudante("MARIA NZUZI NKÓDIA", 105);
        Estudante e6 = new Estudante("ZOLA MAKINFUMU BENJAMIM", 106);

        e1.AdicionarAvaliacao(new Teste(15));
        e1.AdicionarAvaliacao(new Projeto(16));
        e1.AdicionarAvaliacao(new ExameFinal(14));

        e2.AdicionarAvaliacao(new Teste(12));
        e2.AdicionarAvaliacao(new Projeto(14));
        e2.AdicionarAvaliacao(new ExameFinal(10));

        e3.AdicionarAvaliacao(new Teste(18));
        e3.AdicionarAvaliacao(new Projeto(17));
        e3.AdicionarAvaliacao(new ExameFinal(15));

        e4.AdicionarAvaliacao(new Teste(10));
        e4.AdicionarAvaliacao(new Projeto(15));
        e4.AdicionarAvaliacao(new ExameFinal(16));

        e5.AdicionarAvaliacao(new Teste(17));
        e5.AdicionarAvaliacao(new Projeto(14));
        e5.AdicionarAvaliacao(new ExameFinal(16.5));

        uc.AdicionarEstudante(e1);
        uc.AdicionarEstudante(e2);
        uc.AdicionarEstudante(e3);
        uc.AdicionarEstudante(e4);
        uc.AdicionarEstudante(e5);

        uc.EmitirPauta();
    }

}