using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_Enlazadas
{
    class Estructura
    {
        //List<ClaseBase> vector = new List<ClaseBase>();

        ClaseBase inicio = null,final = null;

        public void agregar(ClaseBase nuevo)
        {
            if(inicio==null)
            {
                inicio = nuevo;
            }
            else
            {
                //ClaseBase t = inicio;
                //while (t.Siguiente != null)
                //    t = t.Siguiente;
                //t.Siguiente = nuevo;
                agregar(nuevo, inicio);
            }
        }

        private void agregar(ClaseBase nuevo,ClaseBase quien)
        {
            if (quien.Siguiente != null)
                agregar(nuevo, quien.Siguiente);
            else
            {
                quien.Siguiente = nuevo;
                final = quien.Siguiente;
            }
        }

        public ClaseBase buscar(ClaseBase nuevo)
        {
            return null;
        }

        public void eliminar()
        {
            if(inicio!=null)
            {
                inicio = inicio.Siguiente;
            }
        }
  
        
        public void eliminarUltimo()
        {
            ClaseBase te = inicio;
            ClaseBase t=null;
            while(te.Siguiente !=null)
            {
                t = te;
                te = te.Siguiente;
            }
            t.Siguiente = null;
        }

        public string listarInverso()
        {
            string output = "";
            ClaseBase t = inicio;

            while (t != null)
            {
                output = t.ToString() + "\r\n" + output;
                t = t.Siguiente;
            }
            return output;
        }

        public string listar()
        {
            string res = "";
            ClaseBase t=inicio;
            while (t != null)
            {
                res += t.ToString()+"\r\n";
                t = t.Siguiente;
            }
            return res;
        }
        
        public void invertirlista()
        {
            ClaseBase t=inicio;
            ClaseBase temp=null,vali=null;
            while (t != null)
            {
                temp = t.Siguiente;
                t.Siguiente = vali;
                vali = t;
                t = temp;
            }
            inicio = vali;
        }
    }
}
