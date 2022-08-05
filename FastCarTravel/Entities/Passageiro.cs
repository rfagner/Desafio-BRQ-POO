using FastCarTravel.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastCarTravel.Entities
{
    public class Passageiro : Usuario
    {
        public float Saldo = 500;
        public string EnderecoOrigem { get; set; }
        public string EnderecoDestino { get; set; }

        public EAcoesPassageiros AcoesPassageiros { get; set; }
        public EMetodoPagamento MetodoPagamento { get; set; }

        public Passageiro(string telefone, string nome, string email, string senha, string cpf) : base (telefone, nome, email, senha, cpf)
        {
            Telefone = telefone;
            Nome = nome;
            Email = email;
            Senha = senha;
            CPF = cpf;
        }

        public void ChamarCorrida()
        {
            Console.WriteLine("Chamando corrida...");
        }

        public void CancelarCorrida()
        {
            Console.WriteLine("Corrida cancelada.");
            Console.WriteLine("Até mais.");
        }

        public void InformarEnderecoOrigem(string enderecoOrigem)
        {
            EnderecoOrigem = enderecoOrigem;
        }

        public void InformarEnderecoDestino(string enderecoDestino)
        {
            EnderecoDestino = enderecoDestino;
        }

        public string PagarCorrida(float valorCorrida)
        {
            Saldo -= valorCorrida;
            return "Pagamento efetuado com sucesso!";
        }

        public override string RegistrarUsuario()
        {
            return $"Olá {Nome}. \nSeu cadastro para passageiro foi realizado com sucesso!";
        }

    }
}
