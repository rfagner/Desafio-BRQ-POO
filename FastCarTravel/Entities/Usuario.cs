using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastCarTravel.Entities
{
    public abstract class Usuario
    {
        public string Telefone { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string CPF { get; set; }

        protected Usuario(string telefone, string nome, string email, string senha, string cPF)
        {
            Telefone = telefone;
            Nome = nome;
            Email = email;
            Senha = senha;
            CPF = cPF;
        }

        public virtual string RegistrarUsuario()
        {
            return "Seu cadastro foi realizado com sucesso!";
        }
    }
}
