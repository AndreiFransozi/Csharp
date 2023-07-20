class Conclusao
{
  static void Main()
  {
    bool opcao = true;
    Console.WriteLine("Ola, irei realizar a soma de numeros que você deseja até você desejar parar");
    
    Console.WriteLine("Digite o Valor inicial");
    float.TryParse(Console.ReadLine(), out float inicial);

    while(opcao == true)
    {
      Console.WriteLine("Digite o número que deseja somar ao número inicial");
      float.TryParse(console.ReadLine(), outFloat n1);
      inicial = inicial + n1;
        Console.WriteLine("A soma até o momento é {0}", inicial);
        Console.WriteLine("Deseja sair do programa? 1 - sim 2 - não");
        int.TryParse(Console.ReadLine(), out int saida);
      switch (saida)
      {
        case 1:
          Console.WriteLine("Saindo do programa.");
          opcao = false;
          break;
        case 2:
          Console.WriteLine("continua a soma.");
            break;
        default:
          Console.WriteLine("Opção Inválida. Retornando para soma.")
            break;
      }
    }
  }
}
