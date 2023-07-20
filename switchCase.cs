Console.WriteLine("Qual a nota você dara para o prato?" 0, 5 ou 10");
int.TryParse(Console.ReadLine(), out int nota);
  Switch (nota)
  {
    case 0:
        Console.WriteLine("Comida muito Ruim!.");
    break
    case 5:
    Console.WriteLine("Comida razóavel!.");
    break
    case 10:
    Console.WriteLine("Comida muito boa!.");
    break;
    default:
    Console.WriteLine("Nota inexistente");
  break;                
  }
