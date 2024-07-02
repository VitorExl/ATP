using System;
using System.IO;

class Program {
    static void Main() {
        Console.WriteLine("Digite o caminho do arquivo: ");
        string caminhoArquivo = Console.ReadLine();
        using (StreamReader sr = new StreamReader(caminhoArquivo)) {
            int contadorLinhas = 0;
            string linha;

            while ((linha = sr.ReadLine()) != null) {
                Console.WriteLine(linha);
                contadorLinhas++;
            }

            Console.WriteLine("O arquivo possui " + contadorLinhas + " linhas.");
            }
        
    }
}
