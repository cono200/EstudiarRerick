namespace rEric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IntentoDeLista intentoDeLista1 = new IntentoDeLista();

            //intentoDeLista1.InsertarFinal(new persona("Juan", 19));

            //intentoDeLista1.InsertarInicio(new persona("1", 58));
            //intentoDeLista1.InsertarInicio(new persona("2", 58));
            //intentoDeLista1.InsertarInicio(new persona("3", 58));

            intentoDeLista1.InsertarInicio(new persona("Sebatian", 12));
            intentoDeLista1.InsertarFinal(new persona("aaaaa", 13));
           intentoDeLista1.InsertarMedioLista(new persona("MEDIO", 55));
           intentoDeLista1.InsertarMedioLista(new persona("MEDIO", 14));
           intentoDeLista1.InsertarMedioLista(new persona("MEDIO", 666));
           intentoDeLista1.InsertarMedioLista(new persona("MEDIO", 111));
           intentoDeLista1.BusquedaBinariaPorEdad(666);
          // intentoDeLista1.BusquedalinealPorEdad(90);
            //intentoDeLista1.OrdenarBurbuja();
            intentoDeLista1.ImprimirLista();
            
        }
    }
}