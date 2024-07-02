using System;
using System.IO;

class Program {
    static void Main() {
        Console.Write("Digite a quantidade de letras: ");
        int N = int.Parse(Console.ReadLine());

        string caminhoArquivo = "letras.txt";
        using (StreamWriter sw = new StreamWriter(caminhoArquivo)) {
            for (int i = 0; i < N; i++) {
                Console.Write("Digite a " + i + 1 + "ª letra: ");
                char letra = Console.ReadKey().KeyChar;
                sw.WriteLine(letra);
            }
        }
        
        int vogais = 0;
        using (StreamReader sr = new StreamReader(caminhoArquivo)) {
            while (!sr.EndOfStream) {
                char letra = sr.ReadLine().ToLower()[0];
                if ("aeiou".Contains(letra)) { vogais++; }
            }
        }

        Console.WriteLine("\nQuantidade de vogais no arquivo: "+ vogais);
    }
}
