using System;

namespace MaiorNumero;

public class Program
{
    static void Main(string[] args)
    {
        int N1, N2;

        Console.WriteLine("Bom dia, vamos ver qual dos numeros digotas é o maior.");
        Console.Write("Digite por favor um numero inteiro = ");
        N1 = int.Parse(Console.ReadLine());
        Console.Write("Digite por favor outro numero inteiro = ");
        N2 = int.Parse(Console.ReadLine());

        if(N1 > N2)
        {
            Console.WriteLine("Maior numero digitado é = " + N1);
        }
        else if(N1 < N2)
        {
            Console.WriteLine("Maior numero digitado é = " + N2);
        }
    }
}