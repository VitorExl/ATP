using System;


    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite sua frase: ");
            string texto = Console.ReadLine();

            int contadorEspacos = 0;
            foreach (char caractere in texto)
            {
                if (char.IsWhiteSpace(caractere))
                {
                    contadorEspacos++;
                }
            }

            Console.WriteLine("A frase possui " + contadorEspacos + " espaços em branco");
        }
    }

