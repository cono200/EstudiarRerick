﻿using System;
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
            if (ListaVacia())
            {
                Console.WriteLine("La lista esta vacia"); 
                primerNodo = ultimoNodo = new Nodo(persona);
            }
            else
            {
                int logitud = LongitudLista();
                Nodo actual = primerNodo;
                //TIENE QUE SER IGUAL A 1, PARA QUE INICIE INICIALIZADO
                int contador = 1;
                //NODO (O VALOR) QUE GUARDA EL VALOR DE LA MITAD DE LA LISTA
                Nodo anterior = null;
                //MIENTRAS QUE EXISTA NUMEROS Y QUE EL CONTADOR TODAVIA NO LLEGUE A LA MITAD
                //ENTRE EN EL CICLO
                while (actual.Siguiente != null && contador < logitud / 2)
                {
                    //INCLEMENTAR EL CONTADOR
                    contador++;
                    //RECORRER AL SIGUIENTE NUMERO
                    actual = actual.Siguiente;

                }
                //GUARDAMOS EL VALOR DEL MEDIO
                anterior = actual;
                //SE TIENE QUE GUARDAR EL DATO DE PERSONA Y EL APUNTADOR AL SIGUIENTE
                Nodo nuevo = new Nodo(persona, actual.Siguiente);
               
                anterior.Siguiente = nuevo;

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

        public void BusquedaBinariaPorEdad(int edadABuscar)
        {
            // Asegúrate de que la lista esté ordenada por edad
            OrdenarBurbuja();

            int izquierda = 0;
            int derecha = LongitudLista() - 1;
            bool encontrado = false;

            while (izquierda <= derecha)
            {
                int medio = izquierda + (derecha - izquierda) / 2;

                int contador = 0;
                Nodo actual = primerNodo;

                // Iteramos hasta la posición media
                while (contador < medio && actual != null)
                {
                    actual = actual.Siguiente;
                    contador++;
                }

                // Si actual es null, la lista no tiene suficientes elementos
                //if (actual == null)
                //{
                //    break;
                //}

                // Si la edad del nodo en la posición media es igual a la edad buscada
                if (actual.Valor._edad == edadABuscar)
                {
                    Console.WriteLine("Se encontró una persona con la edad de " + edadABuscar + " en la posición " + medio);
                    encontrado = true;
                    break;
                }
                // Si la edad buscada es mayor, ignoramos la mitad izquierda
                else if (actual.Valor._edad < edadABuscar)
                {
                    izquierda = medio + 1;
                }
                // Si la edad buscada es menor, ignoramos la mitad derecha
                else
                {
                    derecha = medio - 1;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("No se encontró ninguna persona con la edad de " + edadABuscar);
            }
        }












        public void BusquedalinealPorEdad(int edadABuscar)
        {
            // Primero, asegúrate de que la lista esté ordenada por edad
           // OrdenarBurbuja();

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
     
       
            


