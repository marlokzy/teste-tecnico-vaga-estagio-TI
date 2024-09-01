// 4) Dado o valor de faturamento mensal de uma distribuidora, detalhado por estado:
// - SP – R$67.836,43
// - RJ – R$36.678,66
// - MG – R$29.229,88
// - ES – R$27.165,48
// - Outros – R$19.849,53
// Escreva um programa na linguagem que desejar onde calcule o percentual de representação que cada estado teve dentro do valor total mensal da distribuidora. 

namespace desafio_4;
public class DesafioQuatro
{
    public static void Main(){
        // valor
        double SP = 67836.43;
        double RJ = 36678.66;
        double MG = 29229.88;
        double ES = 27165.48;
        double Outros = 19849.53;
        double total = SP + RJ + MG + ES + Outros;

        // porcentagem
        double percSP = (SP / total) * 100;
        double percRJ = (RJ / total) * 100;
        double percMG = (MG / total) * 100;
        double percES = (ES / total) * 100;
        double percOutros = (Outros / total) * 100;

        // output
        Console.WriteLine($"SP: {percSP:F2}%");
        Console.WriteLine($"RJ: {percRJ:F2}%");
        Console.WriteLine($"MG: {percMG:F2}%");
        Console.WriteLine($"ES: {percES:F2}%");
        Console.WriteLine($"Outros: {percOutros:F2}%");

    }
}
