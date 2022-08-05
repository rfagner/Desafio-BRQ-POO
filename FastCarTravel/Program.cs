using FastCarTravel.Entities;
using System;
using System.Collections.Generic;
using System.Threading;

namespace FastCarTravel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Apresentação do sistema
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("         Fast Car Travel - O seu App de viagens");
            Console.WriteLine("----------------------------------------------------------\n");
            
            // Instanciação e cadastro do passageiro no sistema            
            Passageiro passageiro1 = new Passageiro("(11) 64789-1235", "Carlos Eduardo", "calos123@email.com", "123456", "123.456.789-10");
            Console.WriteLine(passageiro1.RegistrarUsuario());
            Console.WriteLine("");
            Thread.Sleep(2000);

            // Instanciação e cadastro do motorista no sistema
            Motorista motorista1 = new Motorista("(11) 67845-2269", "Pedro Paulo Soares", "pedro.paulo@email.com", "brasil123", "456.987.258-12", "Fiat Argo", "Branco", "2022", "APB-5G42");
            Console.WriteLine(motorista1.RegistrarUsuario());
            Console.WriteLine();

            // Passageiro chamando a corrida e passando os endereços de origem e destino
            passageiro1.AcoesPassageiros = Enums.EAcoesPassageiros.ChamarCorrida;
            Thread.Sleep(2000);
            passageiro1.ChamarCorrida();
            Thread.Sleep(2000);
            Console.WriteLine("");

            // Sistema pergunta o endereço
            Console.Write("Digite o endereço de origem: ");
            string endereçoOrigem = Console.ReadLine();
            Console.Write("Digite o endereço de destino: ");
            string endereçoDestino = Console.ReadLine();
            Corrida corrida1 = new Corrida(endereçoOrigem, endereçoDestino, 42.50f, passageiro1, motorista1);
            Console.WriteLine("");

            // Passageiro paga a corrida
            Console.WriteLine("Selecione a forma de pagamento");
            Console.WriteLine("1 - Cartão de crédito");
            Console.WriteLine("2 - Pix");
            Console.WriteLine("3 - Dinheiro");
            Console.WriteLine("----------------------------------------------------------");
            Console.Write("Selecione uma opção: ");
            short opcao = short.Parse(Console.ReadLine());            
            switch (opcao)
            {
                case 1: Console.WriteLine("Cartão de cédito selecionado"); break;
                case 2: Console.WriteLine("Pix selecionado"); break;
                case 3: Console.WriteLine("Dinheiro selecionado"); break;
            }
            Console.WriteLine("");
            passageiro1.MetodoPagamento = Enums.EMetodoPagamento.PagamentoViaCartaoCredito;
            Thread.Sleep(2000);
            Console.WriteLine("");
            Console.WriteLine("Dados da corrida");
            Console.WriteLine($"Endereço de destino: {corrida1.EnderecoDestino}");         
            Console.WriteLine($"Valor da corrida: R$ {corrida1.ValorCorrida}");
            Console.WriteLine("----------------------------------------------------------");
            

            Console.Write("Deseja confirmar? S/N ");
            string resposta = Console.ReadLine();
            do
            {
                if (resposta.ToUpper() == "S")
                {
                    Console.WriteLine(passageiro1.PagarCorrida(corrida1.ValorCorrida));
                    Thread.Sleep(2000);
                    // Motorista aceita a corrida
                    passageiro1.ChamarCorrida();
                    Console.WriteLine("");
                    Thread.Sleep(2000);
                    Console.WriteLine("Aguarde, estamos procurando um motorista parceiro!\n");
                    Thread.Sleep(2000);
                    motorista1.AceitarCorrida();
                    Thread.Sleep(2000);
                    motorista1.AcoesMotorista = Enums.EAcoesMotorista.AceitarCorrida;
                    // Dados da viagem
                    Console.WriteLine();
                    Console.WriteLine($"Sua viagem para: {corrida1.EnderecoDestino}");
                    Console.WriteLine($"Motorista: {corrida1.Motorista.Nome = corrida1.Motorista.Nome}");
                    Console.WriteLine($"Carro: {corrida1.Motorista.NomeVeiculo = corrida1.Motorista.NomeVeiculo}");
                    Console.WriteLine($"Cor: {corrida1.Motorista.CorVeiculo = corrida1.Motorista.CorVeiculo}");
                    Console.WriteLine($"Placa: {corrida1.Motorista.PlacaVeiculo = corrida1.Motorista.PlacaVeiculo}");
                    Console.WriteLine($"Valor da corrida: R$ {corrida1.ValorCorrida}");
                    Console.WriteLine("----------------------------------------------------------\n");

                    // Motorista inicia a corrida
                    motorista1.IniciarCorrida();
                    Thread.Sleep(2000);
                    Console.WriteLine("");
                    // MOtorista finaliza a corrida
                    motorista1.FinalizarCorrida();
                    Thread.Sleep(2000);
                    Console.WriteLine("");
                    // O sistema realiza o pagamento do motorista através da classe corrida
                    corrida1.PagarMotorista();
                    Console.WriteLine("----------------------------------------------------------\n");
                }
                else if (resposta.ToUpper() == "N")
                {
                    passageiro1.CancelarCorrida();

                    break;
                }
                else
                {
                    Console.WriteLine("Dados inválidos!");
                    Console.Write("Deseja confirmar? S/N ");
                    resposta = Console.ReadLine();

                }
            } while (resposta.ToUpper() != "S");


        }
    }
}
