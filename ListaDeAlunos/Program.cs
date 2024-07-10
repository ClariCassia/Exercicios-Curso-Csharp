using System;
using System.Collections.Generic;
using System.Linq;

namespace ListaDeAlunos
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<Aluno> alunos = FonteDados.GetAlunos();

            AlunoService.ExibirDados(alunos);

            alunos.Add(new Aluno() { Nome = "Bia", Nota = 7.75 });
            alunos.Add(new Aluno() { Nome = "Mario", Nota = 8.85 });

            AlunoService.ExibirDados(alunos);

            var alunoExiste = alunos.Find(i => i.Nome.Equals("Amanda"));

            alunos.Remove(alunoExiste);

            AlunoService.ExibirDados(alunos);

            alunos = alunos.OrderBy(aluno => aluno.Nome).ToList();

            AlunoService.ExibirDados(alunos);

            Console.WriteLine("Alunos Destaques: \n");

            AlunoService.Destaque(alunos);
        }
    }
}