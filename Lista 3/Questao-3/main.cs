using System;

class Program {
  public static void Main (string[] args) {
    int divi3e9 = 0, divi2 = 0, divi5 = 0;
    Console.WriteLine ("Digite a sequência de 10 números que deseja, na mesma linha e separados por espaço: ");

    
    //Leitura dos valores e separação em um array
    string numeros = Console.ReadLine();
    string[] numerosSeparados = numeros.Split(' ');

    
    //Calculo das possibilidades
    for(int f = 0; f < numerosSeparados.Length; f++){
      int ndiv = 0;
      int numero = int.Parse(numerosSeparados[f]);
      if(numero % 3 == 0 && numero % 9 == 0) divi3e9++; else ndiv++;
      if(numero % 2 == 0) divi2++; else ndiv++;
      if(numero % 5 == 0) divi5++; else ndiv++;
      if(ndiv == 3) Console.WriteLine("O número " + numero + " não é divisível pelos valores");
    }

    //Quantidade de números divisíveis pelos valores
    Console.WriteLine("Quantidade de números que são divisíveis por 2: " + divi2);
    Console.WriteLine("Quantidade de números que são divisíveis por 3 e 9: " + divi3e9);
    Console.WriteLine("Quantidade de números que são divisíveis por 5: " + divi5);
    
    
  }
    
}