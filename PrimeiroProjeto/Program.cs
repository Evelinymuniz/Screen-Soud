string boaVindas = "\nBoas vindas ao Screen Soud";
//List<string> ListaDasBandas = new List<string>();// Lista de bandas () no final indica que vc vai buscar bandas cadastrdas {} vai definis as bandas
List<string> ListaDasBandas = new List<string> { "U2", "THE BEATS", "CALIPSO"};
void ExibirLogo()
{
    Console.WriteLine("\r\n░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗██████╗░\r\n██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║██╔══██╗\r\n╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██║░░██║\r\n░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║░░██║\r\n██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██████╔╝\r\n╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═════╝░");
    Console.WriteLine(boaVindas);
}

void ExibirMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a media uma banda");
    Console.WriteLine("Digite 0 para sair uma banda");

    Console.Write("\nDigite sua opção :  ");
    string opcao = Console.ReadLine()!;
    int opcaoNumerica = int.Parse(opcao);//fazer uma conversao de opaco string para int


    switch (opcaoNumerica)
    {
        case 1: RegistrarBanda();
            break; 
        case 2: ListarBandas();
            break;
        case 3: Console.WriteLine("Opção escolhida : " + opcaoNumerica);
            break;
        case 4: Console.WriteLine("Opção escolhida : " + opcaoNumerica);
            break;
        case 0: Console.WriteLine("Opção escolhida : " + opcaoNumerica);
            break;
        default: Console.WriteLine("Opção invalida");
            break;
    }

}

void RegistrarBanda() 
{
    Console.Clear();// limpar o console 
    Console.WriteLine("********************************");
    Console.WriteLine(" Registro de bandas ");
    Console.WriteLine("********************************\n");
    Console.Write("Digite o nome da banda : ");//nao pila linha 
    string nomeDaBanda = Console.ReadLine()!;// ! indica q nao quer valor nulo
    ListaDasBandas.Add(nomeDaBanda);
    Console.WriteLine($"\nA banda {nomeDaBanda} foi registrada com sucesso"); // interpolacao de string 
    Thread.Sleep(2000);// esperar 2000 milisegundos
    Console.Clear();
    ExibirMenu();
}

void ListarBandas()
{
    Console.Clear();
    Console.WriteLine("********************************");
    Console.WriteLine(" Listando bandas registradas ");
    Console.WriteLine("********************************\n");

    for (int i = 0; i < ListaDasBandas.Count; i++) 
    {
        Console.WriteLine($"Banda : {ListaDasBandas[i]}");
    }

    Console.WriteLine("\ndigite qualquer tecla para ir pro Menu");
    Console.ReadKey();// reconhece qq tecla para seguir
    Console.Clear();
    ExibirMenu();



}

ExibirMenu();
