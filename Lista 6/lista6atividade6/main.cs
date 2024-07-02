using System;
using System.IO;

class Program {
    static void Main() {
        Console.WriteLine("Digite o número: ");
        int numero = int.Parse(Console.ReadLine());

        int somaDivisores = 0;

        for (int i = 1; i <= numero; i++) {
            if (numero % i == 0) {
                Console.WriteLine($"Divisor: {i}");
                somaDivisores += i;
            }
        }

        string caminhoArquivo = "somaDosDivisores.txt";
        using (StreamWriter sw = new StreamWriter(caminhoArquivo))
        {
            sw.WriteLine("Soma dos divisores de " + numero + ": " + somaDivisores);
        }

        Console.WriteLine("Soma total dos divisores: " + somaDivisores);
    }
}
