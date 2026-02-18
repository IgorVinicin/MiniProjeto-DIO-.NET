using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaEstacionamento.Models
{
    public class Estacionamento
    {
        public decimal precoInicial { get; set; }
        public decimal precoPorHora { get; set; }

        public List<string> veiculos = new List<string>();




        public void CadastrarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();
            veiculos.Add(placa);
            Console.WriteLine($"O veículo com placa {placa} foi cadastrado.");
        }



        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();
            if (!veiculos.Contains(placa))
            {
                Console.WriteLine("Veículo não encontrado.");
                return;
            }
            else
            {
                veiculos.Remove(placa);
            }
            Console.WriteLine("Digite a quantidade de horas que o veículo ficou estacionado:");
            int horasEstacionado = Convert.ToInt32(Console.ReadLine());
            decimal valorTotal = precoInicial + (precoPorHora * horasEstacionado);
            Console.WriteLine($"O veículo com placa {placa} foi removido. O valor total a ser pago é: R$ {valorTotal}");
        }



        public void listarVeiculos()
        {

            if (veiculos.Count == 0)
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
            else
            {
                Console.WriteLine("Veículos estacionados:");
                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
        }

       
    }
}