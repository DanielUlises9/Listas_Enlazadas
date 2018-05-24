using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_Enlazadas
{
    class ClaseBase
    {

        private int _dato;
        public int Dato
        {
            get { return _dato; }
            set { _dato = value; }
        }

        private ClaseBase _siguiente;
        public ClaseBase Siguiente
        {
            get { return _siguiente; }
            set { _siguiente = value; }
        }

        public ClaseBase(int dato)
        {
            _dato = dato;
        }

        public override string ToString()
        {
            return "dato " + _dato; 
        }
    }
}
