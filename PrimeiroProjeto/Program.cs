string boaVindas = "Boas vindas";

void ExibirMensagemBoasVindas()
{
    Console.WriteLine("🆂🅲🆁🅴🅴🅽 🆂🅾🆄🅽🅳\n");
    Console.WriteLine(boaVindas);
}

void ExibirMenu()
{
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
        case 2: Console.WriteLine("Opção escolhida : " + opcaoNumerica);
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
    Console.WriteLine("Registro de bandas");
    Console.Write("Digite o nome da banda : ");//nao pila linha 
    string nomeDaBanda = Console.ReadLine()!;// ! indica q nao quer valor nulo
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso"); // interpolacao de string 




}

ExibirMensagemBoasVindas();
ExibirMenu();
