// 5) Escreva um programa que inverta os caracteres de um string.
// IMPORTANTE:
// a) Essa string pode ser informada através de qualquer entrada de sua preferência ou pode ser previamente definida no código;
// b) Evite usar funções prontas, como, por exemplo, reverse;

using System;

namespace desafio_5;

public class DesafioCinco(){
    public static void Main(){
        Console.WriteLine("Digite algo e veja ao contrário:");

        string palavra = Console.ReadLine();
        string palavraInvertida = "";

        for (int i = palavra.Length - 1; i >= 0; i--)
        {
            palavraInvertida = palavraInvertida + palavra[i];
        }

        Console.WriteLine(palavraInvertida);
    }
}