class Conclussao
{
  static void Main()
  {
    float media = 0;

    Console.WriteLine("Olá, bem vindo ao programa de cálculo de média!");

    Console.WriteLine("Irei auxiliar você e calcular a média do seu aluno!");

    Console.WriteLine("Digite a primeira nota: ");
    int.TryParse(Console.ReadLine(), out int nota1);
    Console.WriteLine("Digite a segunda nota: ");
    int.TryParse(Console.ReadLine(), out int nota2);
    Console.WriteLine("Digite a terceira nota: ");
    int.TryParse(Console.ReadLine(), out int nota3);
    media = (nota1 + nota2 + nota3) / 3;

    Console.WriteLine("A Média do aluno é: {}", media);
    if(media < 7)
    {
      Console.WriteLine("Aluno está em recuperação");
    }
    else
    {
      Console.WriteLine("Aluno aprovado");
    }
  }
