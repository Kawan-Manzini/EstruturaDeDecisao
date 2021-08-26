using System;

namespace Estrutura_de_decisão
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double nota1, nota2, nota3, media;
            Console.WriteLine("Digite o nome do Aluno: ");
            nome = Console.ReadLine();

            Console.WriteLine("digite a nota1 do aluno: ");
            nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("digite a nota2 do aluno: ");
            nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("digite a nota3 do aluno: ");
            nota3 = double.Parse(Console.ReadLine());

            media = (nota1 + nota2 + nota3) / 3;

            if (media > 6)
            {
                Console.WriteLine("Parabens voce foi aprovado");
            }
            else if (media == 6)
            {
                Console.WriteLine("foi aprovado por pouco");
            }
            else
            {
                Console.WriteLine("voce foi reprovado");
            }
              



            
        }
    }
}
