using ScreenSound.Menus;
using ScreenSound.Models;

// Screen Sound
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound!";
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
    Console.WriteLine("5 - exibir detalhes de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarBanda menu1 = new();
            menu1.Exibir(bandas);
            VoltarMenu();
            break;
        case 2:
            ListarBandas menu2 = new();
            menu2.Exibir(bandas);
            VoltarMenu();
            break;
        case 3:
            AvaliarBanda menu3 = new();
            menu3.Exibir(bandas);
            VoltarMenu();
            break;
        case 4:
            ExibirMediaBanda menu4 = new();
            menu4.Exibir(bandas);
            VoltarMenu();
            break;
        case 5:
            ExibirDetalhes menu5 = new();
            menu5.Exibir(bandas);
            VoltarMenu();
            break;
        case -1:
            Console.WriteLine("Tchau tchau :)");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
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