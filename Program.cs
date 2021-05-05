using System;

namespace AnaliseCredito
{
    class Program
    {
        static void Main(string[] args)
        {
            Double Valor, Parcelas, Renda, Porcentagem, ValorPar;

            Console.WriteLine("-----Analise de credito-----");

            Console.WriteLine();

            Console.WriteLine("Por favor, digite o valor do empréstimo: ");
            Valor = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Digite a quantidade de parcelas que deseja fazer:");
            Parcelas = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Digite sua renda mensal:");
            Renda = Convert.ToDouble(Console.ReadLine());

            Porcentagem = (30* Renda) /100;

            Console.WriteLine($"30% da renda mensal é: {Porcentagem}");

            Console.WriteLine();

            ValorPar = Valor/Parcelas;

            if (ValorPar > Porcentagem){
                Console.WriteLine("Seu empréstimo foi negado, pois o valor desejado ultrapassa os 30% da renda");
            }

            else{
                Console.WriteLine("Seu empréstimo foi autorizado!!");
            }
            Console.ReadKey();


        }
    }
}
