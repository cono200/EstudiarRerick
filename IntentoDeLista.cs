using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rEric
{
    public class IntentoDeLista
    {
        


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
        //LONGITUD LISTA
        public int LongitudLista()
        {
            if (ListaVacia())
            {
                return -1;
            }
            else
            {
                int contador = 0;
                Nodo actual = primerNodo;

                while (actual != null)
                {
                    contador++;

                    actual = actual.Siguiente;
                }
                return contador;
            }
        }

        //INSERTAR MEDIO
        public void InsertarMedioLista(persona persona)
        {
            // Comprueba si la lista está vacía. Si lo está, inserta el nuevo nodo en la primera posición.
            if (ListaVacia())
            {
                primerNodo = ultimoNodo = new Nodo(persona);
                
            }
            else
            {
                // Calcula la longitud de la lista.
                int longitud = LongitudLista();

                // Inicializa las variables de control.
                Nodo actual = primerNodo;
                int posicion = 1;

                // Itera por la lista hasta encontrar la posición media.
                while (actual.Siguiente != null && posicion < longitud / 2)
                {
                    posicion++;
                    actual = actual.Siguiente;
                }

                // Guarda la referencia al nodo anterior al nuevo nodo.
                Nodo anterior = actual;

                // Crea el nuevo nodo.
                Nodo nuevo = new Nodo(persona);

                // Asigna el siguiente nodo del nuevo nodo al siguiente nodo del nodo anterior.
                nuevo.Siguiente = actual.Siguiente;

                // Asigna el nuevo nodo como siguiente nodo del nodo anterior.
                anterior.Siguiente = nuevo;

                // Actualiza el valor de ultimoNodo si el nuevo nodo se inserta al final de la lista.
                if (actual == ultimoNodo)
                {
                    ultimoNodo = nuevo;
                }
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
        //BUSQUEDA BINARIA
        public void BusquedalinealPorEdad(int edadABuscar)
        {
            // Primero, asegúrate de que la lista esté ordenada por edad
            OrdenarBurbuja();

            Nodo actual = primerNodo;
            Nodo anterior = null;
            bool encontrado = false;
            int contador = 0;
            while (actual != null)
            {
                contador++;
                if (actual.Valor._edad == edadABuscar)
                {
                    Console.WriteLine("Se encontró una persona con la edad de " + edadABuscar + "Y esta en la posicion " + contador);
                    Console.WriteLine("Nombre: " + actual.Valor._nombre);
                    Console.WriteLine("Edad: " + actual.Valor._edad);
                    encontrado = true;
                    break;
                }
                anterior = actual;
                actual = actual.Siguiente;
            }

            if (!encontrado)
            {
                Console.WriteLine("No se encontró ninguna persona con la edad de " + edadABuscar);
            }
        }




        public void OrdenarBurbuja()
        {
            if (ListaVacia())
            {
                Console.WriteLine("No se puede ordenar nada por que esta vacia la lista");
            }
            else
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

        }

       


    }
    }
     
       
            


