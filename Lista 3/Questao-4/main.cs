using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine("Digite um número ");
    int numero = int.Parse(Console.ReadLine());

    if(numero < 0) {
      Console.WriteLine("O número é inválido");
    } else if(numero < 2) Console.WriteLine("O resultado é: 1");
      else{
        for(int f = numero; f > 1; f--){
          numero = numero * (f - 1);
        }

      Console.WriteLine("O resultado é: " + numero);
    }


    
  }
    
}