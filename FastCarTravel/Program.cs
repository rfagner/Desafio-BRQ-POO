using FastCarTravel.Entities;
using System;
using System.Collections.Generic;

namespace FastCarTravel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instanciação e cadastro do passageiro no sistema            
            Passageiro passageiro1 = new Passageiro("(11) 64789-1235", "Carlos Eduardo", "calos123@email.com", "123456", "123.456.789-10");
            Console.WriteLine(passageiro1.RegistrarUsuario());          

            Console.WriteLine("");
            // Instanciação e cadastro do motorista no sistema
            Motorista motorista1 = new Motorista("(11) 67845-2269", "Pedro Paulo Soares", "pedro.paulo@email.com", "brasil123", "456.987.258-12", "Fiat Argo", "Branco", "2022", "APB-5G42");
            Console.WriteLine(motorista1.RegistrarUsuario());


            Console.WriteLine();
            // Passageiro chamando a corrida e passando os endereços de origem e destino
            passageiro1.AcoesPassageiros = Enums.EAcoesPassageiros.ChamarCorrida;
            passageiro1.ChamarCorrida();
            Corrida corrida1 = new Corrida("Rua Abrantes, 15 - São Paulo - SP", "Rua Tomé de Souza, 500 - São Paulo - SP", 42.50f, passageiro1, motorista1);
            // Passageiro paga a corrida
            passageiro1.MetodoPagamento = Enums.EMetodoPagamento.PagamentoViaCartaoCredito;
            Console.WriteLine(passageiro1.PagarCorrida(corrida1.ValorCorrida));
            // Motorista aceita a corrida
            motorista1.AcoesMotorista = Enums.EAcoesMotorista.AceitarCorrida;
            motorista1.AceitarCorrida();

            // Dados da viagem
            Console.WriteLine();
            Console.WriteLine($"Sua viagem para: {corrida1.EnderecoDestino}");
            Console.WriteLine($"Motorista: {corrida1.Motorista.Nome = corrida1.Motorista.Nome}");
            Console.WriteLine($"Carro: {corrida1.Motorista.NomeVeiculo = corrida1.Motorista.NomeVeiculo}");
            Console.WriteLine($"Cor: {corrida1.Motorista.CorVeiculo = corrida1.Motorista.CorVeiculo}");
            Console.WriteLine($"Placa: {corrida1.Motorista.PlacaVeiculo = corrida1.Motorista.PlacaVeiculo}");
            Console.WriteLine($"Valor da corrida: R$ {corrida1.ValorCorrida}");

            // Saldo final do passageiro pra verificar se a viagem foi descontada
            //Console.WriteLine(passageiro1.Saldo);

            // MOtorista finaliza a corrida
            motorista1.FinalizarCorrida();

            // O sistema realiza o pagamento do motorista através da classe corrida
            corrida1.PagarMotorista();
            
        }
    }
}
