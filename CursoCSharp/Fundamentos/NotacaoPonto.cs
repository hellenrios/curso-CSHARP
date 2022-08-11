using System;
namespace CursoCSharp.Fundamentos
{
    public class NotacaoPonto
    {
        public static void Executar()
        {
            var saudacao = "olá ".ToUpper().Insert(3, " World!").Replace("World!", "Mundo!");
            Console.WriteLine("Teste".Length);
            Console.WriteLine(saudacao);

            Console.WriteLine("Teste".Length);

            string valorImportante = null;
            Console.WriteLine(valorImportante?.Length); //cuidado ao usar notacao . com coisas vazias.
                                                        //por isso, utilizamos o ?: ele deixa o código mais seguro e basicamente faz com que o valor da variavel
                                                        //so seja acessado caso ela nao esteja vazia. caso o valor seja null, ele retornará um valor vazio e nao dará erro.
        }
    }
}

