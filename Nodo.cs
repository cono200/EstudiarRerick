using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rEric
{
    public class Nodo
    {
        private persona _valor;
        private Nodo _siguiente;

        public persona Valor
        {
            set { _valor = value; }
            get { return _valor; }
        }


        public Nodo Siguiente
        {
            set { _siguiente = value; }
            get { return _siguiente; }
        }

          public Nodo(persona Valor, Nodo Siguiente)
        {
            this._valor= Valor;
            this._siguiente= Siguiente;
        }
        public Nodo(persona Valor)
        {
            _valor = Valor;
            _siguiente = null;
        }



    }
}
