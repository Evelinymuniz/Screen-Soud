# Screen Sound - Registro e Avaliação de Bandas
## Descrição
O Screen Sound é um programa de console que permite registrar bandas e avaliá-las com notas. Ele utiliza um dicionário para armazenar as bandas registradas, onde a chave é o nome da banda e o valor é uma lista de notas atribuídas à banda.

## O programa oferece as seguintes funcionalidades:

* Registrar uma banda: Permite ao usuário digitar o nome de uma banda para registrá-la no sistema.
* Mostrar todas as bandas registradas: Exibe uma lista com todas as bandas atualmente registradas no sistema.
* Avaliar uma banda: Permite ao usuário digitar o nome de uma banda e atribuir uma nota a ela.
* Exibir a média de uma banda: Solicita ao usuário o nome de uma banda e calcula a média das notas atribuídas a ela.
* Sair: Encerra a execução do programa.

## Funcionamento

1 - Ao iniciar o programa, é exibido um menu com as opções disponíveis. O usuário pode selecionar uma opção digitando o número correspondente. Após selecionar uma opção, o programa realiza a operação correspondente e retorna ao menu.

2 - Ao registrar uma banda, o usuário digita o nome da banda desejada, que é adicionada ao dicionário de bandas registradas com uma lista vazia de notas.

3 - Ao avaliar uma banda, o usuário digita o nome da banda a ser avaliada e a nota atribuída. Se a banda existir no dicionário, a nota é adicionada à lista de notas da banda. Caso contrário, uma mensagem de erro é exibida.

4 - Ao calcular a média de uma banda, o usuário seleciona a banda desejada e o programa calcula a média das notas atribuídas a ela, exibindo o resultado na tela. Se a banda não existir no dicionário, uma mensagem de erro é exibida.

### Instruções de Uso

Compile e execute o código em um ambiente de desenvolvimento compatível com C#.
Ao iniciar o programa, siga as instruções exibidas no menu para realizar as operações desejadas.
Para registrar uma banda, digite o nome da banda quando solicitado.
Para avaliar uma banda, digite o nome da banda e a nota quando solicitado.
Para calcular a média de uma banda, digite o nome da banda quando solicitado.
Ao finalizar uma operação, aguarde as mensagens e siga as instruções para retornar ao menu ou encerrar o programa.
