using System;
class Program {
        static void Main(string[] args) {
            string frase = Console.ReadLine();

            string vogais = "aeiouAEIOU";

            foreach (char caractere in frase) {
                if (!vogais.Contains(caractere)) {
                    Console.Write(caractere);
                }
            }
        }
}
