using System;
using System.Collections.Generic;

class Aluno
{
    public string Nome { get; set; }
    public int Matricula { get; set; }
}

class Program
{
    static Aluno BuscarAluno(List<Aluno> alunos, int matricula)
    {
        foreach (var aluno in alunos)
            if (aluno.Matricula == matricula) return aluno;
        return null;
    }

    static void Main()
    {
        var alunos = new List<Aluno>
        {
            new Aluno { Nome = "Ana", Matricula = 101 },
            new Aluno { Nome = "Bruno", Matricula = 102 }
        };

        int matriculaProcurada = 101;
        Aluno encontrado = BuscarAluno(alunos, matriculaProcurada);

        Console.WriteLine(encontrado != null ? $"Aluno: {encontrado.Nome}" : "Matrícula não encontrada.");
    }
}
]