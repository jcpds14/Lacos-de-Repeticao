//FOR
//For tem 3 sintaxes básicas, declaração da (1)variável, (2)condição e (3)incremento

internal class Program
{
    private static void Main(string[] args)
    {
        //tabuada do 9
        int numero = 9;

        //        (1)           (2)             (3)
        for (int contador = 0; contador <= 10; contador++)
        {
            Console.WriteLine($"{numero} * {contador} = {numero * contador}");
        }

        //WHILE
        int whileNum = 5;
        int whileContador = 1;

        while (whileContador <= 10)//Vai verificar se a condição é True ou False
        {
            Console.WriteLine($"{whileNum} * {whileContador} = {whileNum * whileContador}");
            whileContador++;

            if (whileContador == 12)
            {
                break;//vai parar a execução evitando assim o loop infinito
            }
        }

        //DO WHILE
        int soma = 0, numero1 = 0;

        do
        {
            Console.WriteLine("Digite um número (0 para parar)");
            numero1 = Convert.ToInt32(Console.ReadLine());
            soma += numero1;
        } while (numero1 != 0);

        Console.WriteLine($"A soma dos números digitados é: {soma}");

        //menu simples com C#

        //Colocar no Operadores de repetição


        string opcao;
        bool exibirMenu = true;

        while (exibirMenu)
        {
            Console.Clear();
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Cadastrar cliente.");
            Console.WriteLine("2 - Buscar cliente.");
            Console.WriteLine("3 - Apagar cliente.");
            Console.WriteLine("4 - Encerrar.");
            opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.WriteLine("Cadastro de cliente");
                    break;
                case "2":
                    Console.WriteLine("Busca de cliente");
                    break;
                case "3":
                    Console.WriteLine("Apagar cliente");
                    break;
                case "4":
                        Console.WriteLine("Sistema encerrado");
                    exibirMenu = false;
                    //Environment.Exit() ENCERRA O PROGRAMA
                    break;

                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }

        Console.WriteLine("O progrma menu encerrou.");
        // Console.WriteLine("s(sim)/n(não)");
        // string exitMenu = Console.ReadLine();

        // switch (exitMenu)
        // {
        //     case "s":
        //         exibirMenu = true;
        //         return;
                
        //     case "n":
        //         Environment.Exit(0);
        //         break;
        //     default:
        //         Console.WriteLine("Digite apens 's' ou 'n'");
        //         break;
        // }
    }
}