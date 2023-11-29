using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rEric
{
    public class IntentoDeLista
    {
        //Nodo primerNodo;
        //Nodo ultimoNodo;

        ////INICALIZAR LA LISTA
        //public IntentoDeLista()
        //{
        //    primerNodo = null;
        //    ultimoNodo = null;
        //}
        ////METODO PARA SABER SI ESTA VACIO O NO
        //public bool ListaVacia()
        //{
        //    return (primerNodo == null);
        //}

        ////Insertar AL FINAL

        //public void InsertarFinal(persona persona)
        //{
        //    Nodo nuevoNodo = new Nodo(persona);

        //    if (ListaVacia())
        //    {
        //        primerNodo = nuevoNodo;
        //        ultimoNodo = nuevoNodo;
        //    }
        //    else
        //    {
        //        ultimoNodo.Siguiente = nuevoNodo;
        //        ultimoNodo = nuevoNodo;
        //    }
        //}

        ////METODO IMPRIMIR

        //public void ImprimirLista()
        //{
        //    Nodo actual = primerNodo;

        //    if (ListaVacia())
        //    {
        //        Console.WriteLine("La lista esta vacia");
        //    }
        //    else
        //    {
        //        while (actual != null)
        //        {
        //            Console.WriteLine($"Su nombre es { actual.Valor._nombre } y  su edad es {actual.Valor._edad}");
        //            actual = actual.Siguiente;
        //        }
        //    }
        //}


        Nodo primerNodo;
        Nodo ultimoNodo;


        public IntentoDeLista()
        {
            primerNodo = null;
            ultimoNodo = null;
        }


        //METODO PARA SABER SI ESTA VACIA LA LISTA

        public bool ListaVacia()
        {
            return (primerNodo == null);
        }


        //INSERTAR AL INICIO
        public void InsertarInicio(persona persona)
        {
            Nodo nuevoNodo = new Nodo(persona);
            if (ListaVacia())
            {
                ultimoNodo = nuevoNodo;
                primerNodo = nuevoNodo;
            }
            else
            {
                nuevoNodo.Siguiente = primerNodo;
                primerNodo = nuevoNodo;
            }  
        }

        public void InsertarFinal(persona persona)
        {
            Nodo nuevoNodo = new Nodo(persona);
            if (ListaVacia())
            {
                primerNodo = nuevoNodo;
                ultimoNodo = nuevoNodo;
            }
            else
            {
                ultimoNodo.Siguiente = nuevoNodo;
                ultimoNodo = nuevoNodo;
            }
        }

        //IMPRIMIR

        public void ImprimirLista()
        {
            if (ListaVacia())
            {
                Console.WriteLine("La lista esta vacia");
            }
            else
            {
                Nodo actual = primerNodo;

                while (actual != null)
                {
                    Console.WriteLine("Nombre es " + actual.Valor._nombre);
                    Console.WriteLine("Edad es " + actual.Valor._edad);

                    actual = actual.Siguiente;
                }
            }
        }
        public void OrdenarBurbuja()
        {
            //ES COMO LOS DOS IFS QUE UTILIZABAMOS
            //I Y J
            Nodo actual = primerNodo;
            Nodo siguiente;

            // Recorremos la lista de principio a fin
            while (actual != null)
            {
                // Inicializamos el siguiente nodo al siguiente de actual
                siguiente = actual.Siguiente;

                // Mientras el siguiente nodo no sea null
                while (siguiente != null)
                {
                    // Si el valor actual es mayor que el valor del siguiente
                    if (actual.Valor._edad > siguiente.Valor._edad)
                    {
                        // Intercambiamos los valores de los dos nodos
                        int temp = actual.Valor._edad;
                        actual.Valor._edad = siguiente.Valor._edad;
                        siguiente.Valor._edad = temp;
                    }

                    // Avanzamos al siguiente nodo
                    siguiente = siguiente.Siguiente;
                }

                // Avanzamos al siguiente nodo
                actual = actual.Siguiente;
            }
        }

        //BUSQUEDA 
        public void BuscarLineal(int edad)
        {
            bool existe=false;
            Nodo actual = primerNodo;
            int contador = 0;

            // Recorremos la lista de principio a fin
            while (actual != null)
            {
                // Si el valor actual es igual al valor buscado
                if (actual.Valor._edad == edad)
                {
                    // Devolvemos la posición del elemento en la lista
                    Console.WriteLine("El numero esta en la posicion " + contador);
                    existe = true;
                    break;
                }
                

                // Avanzamos al siguiente nodo
                actual = actual.Siguiente;
                contador++;
            }
            if (existe == false)
            {
                Console.WriteLine("Ese numero no existe");
            }
            

            
            
        }

        



    }
}
