using System;

namespace cs_1._17_ValidaCorreto2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variáveis
            double num, raiz;

            //{entrada de dados}
            do
            {
                Console.Write("Digite um número positivo: ");
                num = double.Parse(Console.ReadLine());
                
                // Exibe mensagem informando valor invalido ou pula uma linha, dependendo da verificação
                Console.WriteLine((num < 0)? "Valor Inválido" : "\n");

            } while (num < 0);

            //{Processamento: Tenta extrair a raiz quadrada do número lido}
            raiz = Math.Sqrt(num);

            Console.WriteLine($"Raiz quadrada de {num}: {raiz}");
        }
    }
}
