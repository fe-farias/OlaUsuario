using System;

namespace tarefa2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeUsuario;

            Console.WriteLine("Digite o seu nome: ");
            nomeUsuario = Console.ReadLine();

            Console.WriteLine($"Olá, {nomeUsuario}!");
        }
    }
}
