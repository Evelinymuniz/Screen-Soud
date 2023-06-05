
string boaVindas = "\nBoas vindas ao Screen Soud";
//List<string> ListaDasBandas = new List<string>();// Lista de bandas () no final indica que vc vai buscar bandas cadastrdas {} vai definis as bandas
//List<string> ListaDasBandas = new List<string> { "U2", "THE BEATS", "CALYPSO" };

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();// estrutura com chave valor
bandasRegistradas.Add("Linkin Park", new List<int> { 10,8,6});// iniciando uma banda com keys e velue
bandasRegistradas.Add("the Beatles", new List<int>());// iniciando se valor

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
        case 1:
            RegistrarBanda();
            break;
        case 2:
            ListarBandas();
            break;
        case 3:
            AvaliarBanda();
            break;
        case 4:
            Console.WriteLine("Opção escolhida : " + opcaoNumerica);
            break;
        case 0:
            Console.WriteLine("Opção escolhida : " + opcaoNumerica);
            break;
        default:
            Console.WriteLine("Opção invalida");
            break;
    }

}

void RegistrarBanda()
{
    Console.Clear();// limpar o console 
    ExibirTituloDaOpcao(" Registro de bandas ");
    Console.Write("Digite o nome da banda : ");//nao pula linha 

    string nomeDaBanda = Console.ReadLine()!;// ! indica q nao quer valor nulo

    bandasRegistradas.Add(nomeDaBanda, new List<int>());//o dicionario de bandas conm seu
                                                        //nome e valor o nome e conhecido 
                                                        //foi adquirido no input o valor ainda 
                                                        // vai ser registrado e anotado nessa nova lista

    //ListaDasBandas.Add(nomeDaBanda);

    Console.WriteLine($"\nA banda {nomeDaBanda} foi registrada com sucesso"); // interpolacao de string 
    Thread.Sleep(2000);// esperar 2000 milisegundos
    Console.Clear();
    ExibirMenu();
}

void ListarBandas()
{
    Console.Clear();
    ExibirTituloDaOpcao(" Listando bandas registradas ");

    /*for (int i = 0; i < ListaDasBandas.Count; i++)
    {
        Console.WriteLine($"Banda : {ListaDasBandas[i]}");
    }*/ // ESTRUTURA FOR

    /*foreach (string banda in ListaDasBandas)// para cada banda na minha lista de bandas faca isso
    {
        Console.WriteLine($"Banda : {banda}");
    }*///utilizado com a lista 

    foreach (string banda in bandasRegistradas.Keys)//pega somento o nome da banda
    {
        Console.WriteLine($"Banda : {banda}");
    }
    //utilizado com a lista 


    Console.WriteLine("\ndigite qualquer tecla para ir pro Menu");
    Console.ReadKey();// reconhece qq tecla para seguir
    Console.Clear();
    ExibirMenu();

}

void AvaliarBanda()
{
    // passo a passo -> digite qual banda deseja avaliar
    // -> verificar se a banda esta cadastrada
    // -> atribuir uma nota
    // -> banda inesistente vota ao menu

    Console.Clear();
    ExibirTituloDaOpcao("Avalie a banda");
    Console.Write("Digite o nome da banda de deseja avaliar : ");
    string nomeDaBanda = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(nomeDaBanda!))// verifica se o nome da banda escolhida esta no dicionario
    {
        Console.Write($"\nQual a nota que a banda merece {nomeDaBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);// temos q transformar pq as informacoes adquiridas do console
                                                  // sao no formato de string e queremos um int.
        bandasRegistradas[nomeDaBanda].Add(nota); // [] quando faco isso eu acesso os valores
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso");
        Thread.Sleep(5000);
        Console.Clear();
        ExibirMenu();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} nao esta cadastrada");
        Console.WriteLine("\ndigite qualquer tecla para ir pro Menu");
        Console.ReadKey();// reconhece qq tecla para seguir
        Thread.Sleep(1000);
        Console.Clear();
        ExibirMenu();
    }

 
}
void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;// ja vai dizer a quanti de letras do titulo
    //estamos quuerendo fazer uma linha com a quantidade de asteriscos do titulo
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');//esta pegando uma string
    //vazia com o Empty e o padleft esta verificando a quantidado e o tipo de caracter
    //q vc quer repetir a esquerda.
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
    

}

ExibirMenu();
