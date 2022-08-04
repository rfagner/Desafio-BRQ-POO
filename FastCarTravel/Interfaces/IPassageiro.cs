using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastCarTravel.Interfaces
{
    public interface IPassageiro
    {
        public void ChamarCorrida();
        public void InformarEnderecoOrigem();
        public void InformarEnderecoDestino();
        public string PagarCorrida();
    }
}
