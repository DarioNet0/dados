using System;
using System.Collections.Generic;

class Program
{
    static Random random = new Random();

    static void Main()
    {
        int valorTotalJogador1 = 0;
        int valorTotalJogador2 = 0;

        Console.WriteLine("Jogador 1, jogou o dado 3 vezes e estes são seus números");

        (int valor1, int valor2, int valor3) = jogaDado();

        List<int> listaJogador1 = new List<int> { valor1, valor2, valor3 };

        foreach (int valor in listaJogador1)
        {
            valorTotalJogador1 += valor;
            Console.WriteLine(valor);
        }

        Console.WriteLine("Total Jogador 1: " + valorTotalJogador1);

        Console.WriteLine("Jogador 2, jogou o dado 3 vezes e estes são seus números");

        (int valor4, int valor5, int valor6) = jogaDado();

        List<int> listaJogador2 = new List<int> { valor4, valor5, valor6 };

        foreach (int valor in listaJogador2)
        {
            valorTotalJogador2 += valor;
            Console.WriteLine(valor);
        }

        Console.WriteLine("Total Jogador 2: " + valorTotalJogador2);

        if (valorTotalJogador1 > valorTotalJogador2)
        {
            Console.WriteLine("Jogador 1 venceu!");
        }
        else if (valorTotalJogador1 < valorTotalJogador2)
        {
            Console.WriteLine("Jogador 2 venceu!");
        }
        else
        {
            Console.WriteLine("Empate!");
        }
    }

    static (int, int, int) jogaDado()
    {
        int valor1 = random.Next(1, 7);
        int valor2 = random.Next(1, 7);
        int valor3 = random.Next(1, 7);

        return (valor1, valor2, valor3);
    }
}
