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

        //public void agregar(ClaseBase nuevo)
        //{
        //    if(inicio==null)
        //    {
        //        inicio = nuevo;
        //    }
        //    else
        //    {
        //        //ClaseBase t = inicio;
        //        //while (t.Siguiente != null)
        //        //    t = t.Siguiente;
        //        //t.Siguiente = nuevo;
        //        agregar(nuevo, inicio);
        //    }
        //}

        //private void agregar(ClaseBase nuevo,ClaseBase quien)
        //{
        //    if (quien.Siguiente != null)
        //        agregar(nuevo, quien.Siguiente);
        //    else
        //    {
        //        quien.Siguiente = nuevo;
        //        final = quien.Siguiente;
        //    }
        //}
        /*public void eliminar()
        {
            if(inicio!=null)
            {
                inicio = inicio.Siguiente;
            }
        }*/

            //agregar ordenado en doble
            //terminar los programas
        public void agregar(ClaseBase nuevo)
        {
            if (inicio == null)
                inicio = nuevo;
            else if (nuevo.Dato<inicio.Dato)
            {
                inicio.Anterior = nuevo;
                nuevo.Siguiente = inicio;
                inicio = nuevo;
            }
            else
            {
                ClaseBase temp = inicio;
                while (temp.Dato < nuevo.Dato && temp.Siguiente!=null)
                    temp = temp.Siguiente;
                if (temp.Dato > nuevo.Dato)
                {
                    nuevo.Siguiente = temp;
                    nuevo.Anterior = temp.Anterior;
                    temp.Anterior.Siguiente = nuevo;
                    temp.Anterior = nuevo;
                }
                else
                {
                    temp.Siguiente = nuevo;
                    nuevo.Anterior = temp;
                }
            }

        }


        public int buscar(int dato)
        {
            ClaseBase temp = inicio;
            while(temp.Siguiente !=null)
            {
                if(temp.Dato==dato)
                {
                    return temp.Dato;
                }
                temp = temp.Siguiente;
            }
            return 0;
        }

        public void Elimi(int numero)
        {
            ClaseBase temp = inicio;
            while(true)
            {
                if(temp.Dato == numero)
                {
                    if(temp.Siguiente !=null && temp.Anterior !=null)
                    {
                        temp.Anterior.Siguiente = temp.Siguiente;
                        temp.Siguiente.Anterior = temp.Anterior;
                        break;
                    }
                    else if(temp.Anterior != null)
                    {
                        temp.Anterior.Siguiente = null;
                        break;
                    }
                    else if(temp.Siguiente != null)
                    {
                        inicio = inicio.Siguiente;
                        break;
                    }
                }
                temp = temp.Siguiente;
            }
        }

        public void eliminarInicio()
        {
            if (inicio != null)
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
