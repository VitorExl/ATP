using System;
using System.IO;

class Program {
    static void Main(string[] args) {
        Console.Write("Digite o caminho do arquivo de texto: ");
        string caminhoArquivo = Console.ReadLine();

    
        string conteudo = File.ReadAllText(caminhoArquivo);
        int contadorA = 0;

        foreach (char caractere in conteudo) {
            if (char.ToLower(caractere) == 'a') { contadorA++; }
        }

        Console.WriteLine("Quantidade de a: " + contadorA);
    }
}
