using System;
namespace CursoCSharp.Fundamentos
{
    public class Inferencia
    {
        public static void Executar()
        {
            var nome = "Hellen";
            //por baixo dos panos, o c# identificou que a cadeia de caracteres entre as "" é do tipo string. isso é uma inferência.
            // nome = 123; - caso eu tente reatribuir outro valor de tipo diferente, não será permitido, pois a var nome ja foi reocnhecida com string.
            Console.WriteLine(nome);

            //int idade;
            var idade = 32; //quando ocorre inferencia, precisamos atribuir o valor da var no momento de sua criação.
            Console.WriteLine(idade);

            int a; //declaração de uma variavel;
            a = 3;

            int b = 2; //declaração + inicializaçao/atribuição da variavel;

            Console.WriteLine(a + b);
        }
    }
}


