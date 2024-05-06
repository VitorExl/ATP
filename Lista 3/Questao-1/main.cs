using System;

class Program {
  public static void Main (string[] args) {
    int positivo = 0, negativo = 0, zero = 0;
    Console.WriteLine ("Digite a sequência de números que deseja");

    //A seguinte parte lê os valores e os separa em um array
    string numeros = Console.ReadLine();
    string[] numerosSeparados = numeros.Split(' ');
    
    //A seguinte parte verifica se o número é positivo, negativo ou zero
    for(int f = 0; f < numerosSeparados.Length; f++){
      int numeroAtual = int.Parse(numerosSeparados[f]);
      if(numeroAtual > 0) positivo++;
      else if(numeroAtual == 0) zero++;
      else negativo++;
    }


    Console.WriteLine("Quantidade de Números Negativos: " + negativo);
    Console.WriteLine("Quantidade de Números Positivos: " + positivo);
    Console.WriteLine("Quantidade de Números Zeros: " + zero);
    
    
  }
}