using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastCarTravel.Entities
{
    public class Corrida
    {
        public string EnderecoOrigem { get; set; }
        public string EnderecoDestino { get; set; }

        public float ValorCorrida { get; set; }

        public Passageiro Passageiro { get; set; }
        public Motorista Motorista { get; set; }

        public Corrida(string enderecoOrigem, string enderecoDestino, float valorCorrida, Passageiro passageiro, Motorista motorista)
        {
            EnderecoOrigem = enderecoOrigem;
            EnderecoDestino = enderecoDestino;
            ValorCorrida = valorCorrida;
            Passageiro = passageiro;
            Motorista = motorista;
        }

        public void PagarMotorista()
        {
            Console.WriteLine("O motorista já recebeu os ganhos da viagem.");
        }
    }
}
