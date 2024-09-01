// 2) Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa na linguagem que desejar onde, informado um número, ele calcule a sequência de Fibonacci e retorne uma mensagem avisando se o número informado pertence ou não a sequência.
// IMPORTANTE: Esse número pode ser informado através de qualquer entrada de sua preferência ou pode ser previamente definido no código;

namespace desafio_2;

public class DesafioDois
{
    public static void Main()
    {
        // input
        Console.WriteLine("Saiba a sequência de Fibonacci!!!");
        Console.WriteLine("Digite um número:");

        int number = Convert.ToInt32(Console.ReadLine());

        int auxiliar = number + number;

        while (number <= auxiliar)
        {
            if (auxiliar >= number)
            {
                Console.WriteLine($"O número {number} pertence a sequência Fibonacci");
                number += auxiliar;
            }
            else
            {
                Console.WriteLine($"O número {number} não pertence a sequência Fibonacci");
                break;
            }
            number += auxiliar;
        }
    }
}

// EM CONSTRUÇÃO - TENTANDO RESOLVER
