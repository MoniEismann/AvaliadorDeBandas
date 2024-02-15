string mensagemDeBoasVindas = "\nBem vindo ao Screen Sound!";
Dictionary<string,List<int>> bandasRegistradas = new Dictionary<string,List<int>>();
bandasRegistradas.Add("Maroon 5", new List<int> { 10, 9, 8 });
bandasRegistradas.Add("Nickelback", new List<int> ());


void ExibirLogo () { 
    Console.WriteLine ( @"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir média de uma banda");
    Console.WriteLine("Digite 0 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch(opcaoEscolhidaNumerica)
    {
        case 1: RegistrarBanda ();
            break;
        case 2:MostrarBandasRegistradas ();
            break;
        case 3: AvaliarUmaBanda ();
            break;
        case 4: ExibirMediaDaBanda ();
            break;
        case 0: Console.WriteLine("Tchau, Tchau :D");
            break;
        default: Console.WriteLine("Opção invalida");
            break;
    }
}

void RegistrarBanda ()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro de Bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear() ;
    ExibirMenu();
}

void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibindo todas as bandas registradas");
    foreach (string Banda in bandasRegistradas.Keys) 
    {
        Console.WriteLine($"Banda:{Banda}");
    }
    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirMenu();
}

void AvaliarUmaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Avaliar Banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual nota que a banda {nomeDaBanda} merece? ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} para a banda {nomeDaBanda} foi registrada com sucesso");
        Thread.Sleep(4000);
        Console.Clear();
        ExibirMenu();
    } 
    else
    {
        Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirMenu();

    }
}

void ExibirMediaDaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Nota média da banda");
    Console.Write("Digite o nome da banda que deseja ver a nota: ");
    string nomeBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeBanda))
    {
        List<int> notasDaBanda = bandasRegistradas[nomeBanda];
        Console.WriteLine ($"\nA média da nota da banda {nomeBanda} é {notasDaBanda.Average()}");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirMenu();
    }
    else
    {
        Console.WriteLine($"A banda {nomeBanda} não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirMenu();

    }
}
void ExibirTituloDaOpcao(string titulo)
{
    int QuantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(QuantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

ExibirMenu();




















//int input = 0;
//
//Random random = new Random();
//int numero = random.Next(1, 100);
//
//int numeroAleatorio = numero;
//
//while (input != numeroAleatorio) {
//    Console.WriteLine("Digite um numero entre 1 e 100: ");
//    input = int.Parse(Console.ReadLine()!);
//
//    if (input < 1 || input > 100)
//    {
//        Console.WriteLine("Seu número não está entre 1 e 100");
//        continue;
//    }
//
//    if (input < numeroAleatorio)
//    {
//       Console.WriteLine("O número é maior");
//    } else if (input > numeroAleatorio)
//    {
//        Console.WriteLine("O número é menor");
//    }
//    else
//   {
//       Console.WriteLine("Você Acertou!");
//    }
//}






//float total = 0;

//for (int i = 0; i < 4; i++)
//{
//    Console.WriteLine("Digite sua nota:");
//    string input = Console.ReadLine();
//    float numero = float.Parse(input);
//    total += numero;
//}
//float calculoMedia = total / 4;
//double media = Math.Round(calculoMedia, 2);
//Console.WriteLine($"Sua média é {media}");


