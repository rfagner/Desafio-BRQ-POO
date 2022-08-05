using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastCarTravel.Interfaces
{
    public interface IMotorista
    {
        public void AceitarCorrida();
        public void CancelarCorrida();
        public void IniciarCorrida();
        public void FinalizarCorrida();
    }
}
