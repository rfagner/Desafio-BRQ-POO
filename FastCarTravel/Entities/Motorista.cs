using FastCarTravel.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastCarTravel.Entities
{
    public class Motorista : Usuario
    {
        public float Ganhos { get; set; }
        public string NomeVeiculo { get; set; }
        public string CorVeiculo { get; set; }
        public string AnoVeiculo { get; set; }
        public string PlacaVeiculo { get; set; }
        public EAcoesMotorista AcoesMotorista { get; set; }
        public Motorista(string telefone, string nome, string email, string senha, string cPF, string nomeVeiculo, string corVeiculo, string anoVeiculo, string placaVeiculo) : base(telefone, nome, email, senha, cPF)
        {
            NomeVeiculo = nomeVeiculo;
            CorVeiculo = corVeiculo;
            AnoVeiculo = anoVeiculo;
            PlacaVeiculo = placaVeiculo;
        }
        public void AceitarCorrida()
        {
            Console.WriteLine("Motorista aceitou a corrida.");
        }
        public void CancelarCorrida()
        {
            Console.WriteLine("Corrida cancelada.");
        }
        public void IniciarCorrida()
        {
            Console.WriteLine("Corrida iniciada.");
        }
        public void FinalizarCorrida()
        {
            Console.WriteLine("Corrida finalizada! O passageiro chegou ao destino.");     
            
        }

        
        public override string RegistrarUsuario()
        {
            return $"Olá {Nome}. \nSeu cadastro para motorista foi realizado com sucesso!";
        }
                
    }
}
