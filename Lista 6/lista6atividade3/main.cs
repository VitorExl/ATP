using System;

class Program {

    static string CodificarCesar(string texto, int deslocamento){
        string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string resultado = "";

        foreach (char caractere in texto) {
            if (char.IsLetter(caractere)) {
                char maiusculo = char.ToUpper(caractere);
                int indice = (maiusculo - 'A' + deslocamento) % 26;
                char novoCaractere = alfabeto[indice];
                resultado += char.IsLower(caractere) ? char.ToLower(novoCaractere) : novoCaractere;
            }
            else { resultado += caractere; }
        }

        return resultado;
    }
    
    static void Main(string[] args) {
        Console.Write("Digite a frase: ");
        string frase = Console.ReadLine();

        string fraseCodificada = CodificarCesar(frase, 3);

        Console.WriteLine("Nova string: " + fraseCodificada);
    }

        
}

