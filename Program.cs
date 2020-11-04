using System;
using System.Collections;

namespace ColeccionesG3
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList coleccionDulces = new ArrayList(3);

            coleccionDulces.Add("Borrachitos");
            coleccionDulces.Add("Bubbulubu");
            coleccionDulces.Add("Picafresa");
            coleccionDulces.Insert(1, "Rocaleta");
            coleccionDulces.Insert(3, "Duvalín");
            coleccionDulces.Add("Totis");
            coleccionDulces.Insert(4, "Borrachitos");
            int indice = coleccionDulces.IndexOf("Totis");
            indice = coleccionDulces.IndexOf("Bubbulubu");

            indice = coleccionDulces.IndexOf("Picafresa");
            coleccionDulces.Insert(indice, "Bubulubu");
            coleccionDulces.Remove("Borrachitos");

            coleccionDulces.RemoveAt(indice);

            coleccionDulces.Add(25.5);
            /*
            foreach (string dulce in coleccionDulces )
            {
                Console.WriteLine("Dulce:{0} ", dulce);
            }
            */

            for (int i=0; i < coleccionDulces.Count; i++)
            {
                if (i < coleccionDulces.Count - 1)
                {
                    Console.WriteLine("Dulce:{0}", (string)coleccionDulces[i]);
                }
                else if(i == coleccionDulces.Count-1)
                {
                    Console.WriteLine("Precio:{0}", (double)coleccionDulces[i]);
                }

            }


            //coleccionDulces.Clear();
            Console.WriteLine("Capacidad: {0}", coleccionDulces.Capacity);
            Console.WriteLine("Contar elementos: {0}", coleccionDulces.Count);            
            Console.WriteLine("Los totis están en la posición {0}", indice);
            




        }
    }
}
