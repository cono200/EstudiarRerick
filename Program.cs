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

            intentoDeLista1.InsertarFinal(new persona("1", 78));
            intentoDeLista1.InsertarFinal(new persona("2", 40));
            intentoDeLista1.InsertarFinal(new persona("3", 1));

            //intentoDeLista1.OrdenarBurbuja();
            intentoDeLista1.ImprimirLista();

            intentoDeLista1.BuscarLineal(6262);
        }
    }
}