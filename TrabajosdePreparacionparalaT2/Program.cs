using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajosdePreparacionparalaT2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = Pantallas.pantallaPrincial();

            do { 
                switch (opcion)
                {   
                    case 0:
                        opcion = Pantallas.pantallaPrincial();
                        break;
                    case 1:
                        opcion = Pantallas.registrarVentademPhone3000();
                        break;
                    case 2:
                        opcion = Pantallas.registrarVentademPad3500();
                        break;
                    case 3:
                        opcion = Pantallas.registrarVentadeMAPBrook3800();
                        break;
                    case 4:
                        opcion = Pantallas.registrarVentademWatch8000();
                        break;
                   
                    
                    
                }
            } while (opcion !=5);
            Pantallas.pantallaFinal();

        }
    }
}
