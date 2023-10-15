using System;
using System.Threading;

namespace LiceagaSánchezLiliana_Ejercicio12_G2_2024_1
{
    internal abstract class Marca
    {
        private string marcaName;

        public string MarcaName
        {
            get => marcaName;
            set => marcaName = value;
        }
        public void LimpiarDisplay()
        {
            Thread.Sleep(3000); //milisegundos
            Console.Clear();
        }
    }
}
