using System.Data;
using System.Diagnostics;
using SistemaEstacionamento.Models;


Estacionamento sistema = new Estacionamento();
sistema.precoInicial = 5.00m;
sistema.precoPorHora = 2.00m;

bool exibirMenu = true;

while(exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Bem-vindo ao sistema de estacionamento!");
    Console.WriteLine("================================");
    Console.WriteLine("Escolha uma opção:");
    Console.WriteLine("1. Cadastrar Veículo");
    Console.WriteLine("2. Remover Veículo");
    Console.WriteLine("3. Listar Veículos");
    Console.WriteLine("4. Sair");
    Console.WriteLine("================================");

    switch (Console.ReadLine())
    {
        case "1":   
            Console.Clear();
            sistema.CadastrarVeiculo();
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            break;
           

        case "2":
            Console.Clear();
            sistema.RemoverVeiculo();
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            break;

        case "3":
            Console.Clear();
            sistema.listarVeiculos();
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            break;

        case "4":
            Console.WriteLine("Encerrando o programa...");
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida. Por favor, tente novamente.");
            break;
    }
}