using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiceagaSánchezLiliana_Ejercicio12_G2_2024_1
{
    internal class Laptop : Marca , IEncender , IApagar
    {
        internal Laptop()
        {
            MarcaName = "APPLE";
            Console.WriteLine("-- LAPTOP --");
        }
        void IEncender.Encender()
        {
            Console.WriteLine("Encendiendo . . .");
            Console.WriteLine("{0} te da la bienvenida", MarcaName);
            LimpiarDisplay();
        }
        void IApagar.Apagar()
        {
            Console.WriteLine("Apagando . . .");
            Console.WriteLine("Gracias por utilizar la laptop.");
            LimpiarDisplay();
        }
    }
}
