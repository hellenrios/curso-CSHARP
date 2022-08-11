using System;
namespace CursoCSharp.Fundamentos
{
    public class VariaveisEConstantes
    {
        public static void Executar()
        {
            //area da circunferencia
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5; //posso reatribuir valor
            // PI = 3.1415; - nao posso reatribuir valor pois é uma constante

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("A área é " + area);

            //Tipos internos:
            bool estaChovendo = true;
            Console.WriteLine("Está chovendo? " + estaChovendo);

            //Tipos internos inteiros:
            //byte, short, int e long = tds aceitam numeros inteiros, a diferença é a capacidade de armazenamento que eles possuem. 
            byte idade = 45;
            Console.WriteLine("Idade: " + idade);

            //o sbyte é um tipo que tem sinal. 
            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de gols: " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("O salário é: " + salario);

            int menorValorInt = int.MinValue; //tipo mais usado dos inteiros;
            Console.WriteLine("Menor valor int: " + menorValorInt);

            //inteiro unsigned:
            uint populacaoBrasileira = 207_600_000; //o _ pode deixar os valores mais legíveis.

            Console.WriteLine("População Brasileira: " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor valor long: " + menorValorLong);

            //long unsigned
            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("A população mundial é: " + populacaoMundial);

            //Tipos internos de valores reais = ponto flutuante
            float precoComputador = 1299.99f; //por padrão, td valor que tem casa decimal é do tipo double. Se eu quiser que seja do tipo float, preciso adicionar um f no final.
            Console.WriteLine("Preço do computador: " + precoComputador);

            double valorDeMercadoDaApple = 1_000_000_000_000.00; //tipo mais usado dos reais.
            Console.WriteLine("O valor de mercado da Apple é " + valorDeMercadoDaApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue; //usado para valores exorbitantes.
            Console.WriteLine("Distancia entre estrelas: " + distanciaEntreEstrelas);

            //Tipo interno - caracteres
            char letra = 'b';  //usa ''e armazena uma unica letra
            Console.WriteLine("letra " + letra);

            string cadeiaDeLetras = "Curso de C#";
            Console.WriteLine(cadeiaDeLetras);
        }
    }
}

