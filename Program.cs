using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Exercício de Sala de Aula
                Crie um novo Projeto do tipo “Console Aplicattion” e nomei-o como “EstruturaDeControle1”.
                Renomeie o arquivo “Program.cs” para “TestandoDoisValores.cs”.
                O objetivo do nosso programa é receber dois valores e indicar qual deles é o maior.
                Para tanto, insira o código marcado em negrito abaixo dentro do método principal “Main()”
             */
            int val1;
            int val2;

            Console.WriteLine("Digite o primeiro valor");
            val1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor");
            val2 = int.Parse(Console.ReadLine());

            if (val1 > val2)
            {
                Console.WriteLine("O primeiro valor é maior" + val1);
            }
            else
            {
                Console.WriteLine("O segundo valor é maior" + val2);
            }
        }
    }
}
