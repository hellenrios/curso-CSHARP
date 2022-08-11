using System;
using System.Globalization;
namespace CursoCSharp.Fundamentos
{
    public class LendoDados
    {
        public static void Executar()
        {
            Console.WriteLine("Qual é o seu nome? ");
            string nome = Console.ReadLine();   //essa sentença le uma linha digitada no console e o resultado será armazenado na variavel nome

            Console.WriteLine("Qual é a sua idade? ");
            int idade = int.Parse(Console.ReadLine());  //o parse irá converter a string para int.

            Console.WriteLine("Qual é o seu salário?");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); //o culture info serve para usar o . como seprador de casas decimais

            Console.WriteLine($"{nome} {idade} R${salario}");
        }
    }
}

