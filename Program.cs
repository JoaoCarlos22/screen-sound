using System.Runtime.CompilerServices;
using ScreenSound.Models;

// Screen Sound
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound!";
//List<Banda> bandas = new();
Dictionary<string, Banda> bandas = new();

void ExibirMensagemBoasVindas() {
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirMenu()
{
    ExibirMensagemBoasVindas();
    Console.WriteLine("\n1 - registrar uma banda");
    Console.WriteLine("2 - listar bandas");
    Console.WriteLine("3 - avaliar uma banda");
    Console.WriteLine("4 - exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1: RegistrarBanda();
            break;
        case 2:
            ListarBandas();
            break;
        case 3:
            AvaliarBanda();
            break;
        case 4:
            ExibirMediaBanda();
            break;
        case -1:
            Console.WriteLine("Tchau tchau :)");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}

void RegistrarBanda()
{
    Console.Clear();
    Console.WriteLine("REGISTRO DE BANDAS");
    Console.Write("Digite o nome da banda: ");
    string nomeBanda = Console.ReadLine()!;
    Banda banda = new(nomeBanda);

    Console.WriteLine($"A banda {banda.Nome} foi registrada com sucesso!");
    bandas.Add(banda.Nome, banda);
    Thread.Sleep(2000);
    Console.Clear();
    ExibirMenu();
}

void ListarBandas()
{
    Console.Clear();
    Console.WriteLine("LISTA DE BANDAS\n");
    foreach (var banda in bandas)
    {
        string nome = banda.Value.Nome;
        List<Avaliacao> notas = banda.Value.Notas;
        Console.WriteLine("Banda: {0}, Notas: {1}", nome, string.Join(", ", notas.Select(n => n.Nota)));
    }
    Console.WriteLine("");
    VoltarMenu();
}

void AvaliarBanda()
{
    Console.Clear();
    Console.WriteLine("AVALIAÇÃO DE UMA BANDA");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeBanda = Console.ReadLine()!;

    Banda? banda;
    if (bandas.TryGetValue(nomeBanda, out banda))
    {
        Console.Write($"\nInforme a sua nota para a banda {nomeBanda}: ");
        int nota = int.Parse(Console.ReadLine()!);
        Avaliacao avaliacao = new(nota);
        banda.AdicionarNota(avaliacao);

        if (nota < 0 || nota > 10)
        {
            Console.WriteLine("\nA nota deve ser entre 0 e 10!");
        } else
        {
            Console.WriteLine("\nAvaliação adicionada com sucesso!");
        }
        VoltarMenu();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeBanda} não foi encontrada!");
        VoltarMenu();
    }
}

void ExibirMediaBanda()
{
    Console.Clear();
    Console.WriteLine("MÉDIA DE AVALIAÇÃO DE UMA BANDA");
    Console.Write("Digite o nome da banda que deseja buscar: ");
    string nomeBanda = Console.ReadLine()!;

    Banda? banda;
    if (bandas.TryGetValue(nomeBanda, out banda))
    {
        double media = banda.Media;
        Console.Write($"\nA banda {nomeBanda} tem uma média de avaliação de: {media}\n");
        VoltarMenu();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeBanda} não foi encontrada!");
        VoltarMenu();
    }
}

void VoltarMenu()
{
    Console.WriteLine("Digite alguma tecla para voltar ao menu.");
    Console.ReadKey();
    Console.Clear();
    ExibirMenu();
}

ExibirMenu();