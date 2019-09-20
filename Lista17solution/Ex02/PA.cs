using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02
{
    class PA : ISequencia
    {
        private int PrimeiroElemento;
        private int razao;

        public void SetPrimeiroElemento(int p) {PrimeiroElemento = p; }
        public int GetPrimeiroElemento() { return PrimeiroElemento; }

        public void Setrazao(int d) { razao = d; }
        public int Getrazao() { return razao; }


        public void Iniciar()
        {

        }

        public int Proximo()
        {

        }
    }
}
