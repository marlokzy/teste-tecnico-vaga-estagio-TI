﻿// 1) Observe o trecho de código abaixo: 
// int INDICE = 13, SOMA = 0, K = 0;
// Enquanto K < INDICE faça { K = K + 1; SOMA = SOMA + K; }
// Imprimir(SOMA);
// Ao final do processamento, qual será o valor da variável SOMA?

namespace desafio_1;

    public class DesafioUm
    {
        public static void Main(){
            int INDICE = 13;
            int SOMA = 0;
            int K = 0;

            while (K < INDICE)
            {
                // K = K + 1;
                K++;
                // SOMA = SOMA + K;
                SOMA += K;
            }

            Console.WriteLine(SOMA);  // O valor da variável SOMA é 91!
        }
    }
