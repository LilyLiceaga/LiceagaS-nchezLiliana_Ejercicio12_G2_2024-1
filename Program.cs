using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiceagaSánchezLiliana_Ejercicio12_G2_2024_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Televisor miTelevisor = new Televisor();
            IEncender encender = miTelevisor;
            encender.Encender();
            IApagar apagar = miTelevisor;
            apagar.Apagar();

            Automovil miAutomovil = new Automovil();
            IEncender encender2 = miAutomovil;
            encender2.Encender();
            apagar.Apagar();

            Smartphone miSmartphone = new Smartphone();
            IEncender encender3 = miSmartphone;
            encender3.Encender();
            apagar.Apagar();

            Laptop miLaptop = new Laptop();
            IEncender encender4 = miSmartphone;
            encender4.Encender();
            apagar.Apagar();

            Plancha miPlancha = new Plancha();
            IEncender encender5 = miPlancha;
            encender5.Encender();
            IApagar apagar5 = miPlancha;
            apagar5.Apagar();

            Console.ReadLine();
        }
    }
}
