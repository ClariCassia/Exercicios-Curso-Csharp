using System;
using System.Collections.Generic;
using System.Linq;

namespace ListaDeAlunos
{
    public static class AlunoService
    {
        public static void ExibirDados(List<Aluno> alunos)
        {
            double somaNotas = alunos.Sum(aluno => aluno.Nota);
            int qtdeAlunos = alunos.Count;
            double mediaNotas = somaNotas / qtdeAlunos;

            Console.WriteLine("Lista de Alunos:\n");

            foreach (var aluno in alunos)
            {
                Console.WriteLine($"Nome: {aluno.Nome} \t Nota: {aluno.Nota}");
            }

            Console.WriteLine($"\nMédia das notas = {Math.Round(mediaNotas, 2)}");
            Console.WriteLine($"Total de Alunos: {qtdeAlunos}\n");
        }

        public static void Destaque(List<Aluno> alunos)
        {
            var destaques = alunos.FindAll(i => i.Nota >= 8);
            foreach (var item in destaques)
            {
                Console.WriteLine(item.Nome);
            }
        }
    }
}