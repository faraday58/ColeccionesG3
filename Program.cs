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
            coleccionDulces.Add(25.5);
            foreach(string dulce in coleccionDulces )
            {
                Console.WriteLine("Dulce:{0} ", dulce);
            }
            coleccionDulces.Clear();
            Console.WriteLine("Capacidad: {0}", coleccionDulces.Capacity);
            Console.WriteLine("Contar elementos: {0}", coleccionDulces.Count);

        }
    }
}
