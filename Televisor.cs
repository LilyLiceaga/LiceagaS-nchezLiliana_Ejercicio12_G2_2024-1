using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace LiceagaSánchezLiliana_Ejercicio12_G2_2024_1
{
    internal class Televisor : Marca , IEncender , IApagar
    {
        internal Televisor() 
        {
            MarcaName = "LG";
            Console.WriteLine("-- TELEVISOR --");
        }
        public void Encender() 
        {
            Console.WriteLine("Encendiendo . . .");
            Console.WriteLine("{0} te da la bienvenida", MarcaName);
            LimpiarDisplay();
        }
        public void Apagar() 
        {
            Console.WriteLine("Apagando . . .");
            Console.WriteLine("Gracias por utilizar.");
            LimpiarDisplay();
        }
    }
}
