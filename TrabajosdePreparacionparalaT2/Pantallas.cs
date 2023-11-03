using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajosdePreparacionparalaT2
{
    public class Pantallas
    {
        public static int totaldemPhone3000 = 0;
        public static int totaldemPad3500 = 0;
        public static int totaldeMAPBrook3800 = 0;
        public static int totaldemWatch8000 = 0;
        public static int pantallaPrincial()
        {
            Console.Clear();
            Console.Write("================================\n" +
                "Productos de mPhone\n" +
                "================================\n" +
                "1: Ventas de mPhone 3000\n" +
                "2: Ventas de mPad 3500\n" +
                "3: Ventas de MAPBrook 3800\n" +
                "4: Ventas de mWatch 8000\n" +
                "5: Salir\n" +
                "================================\n");
            return piePantallaprincipal("Ingrese una opción: ");
            

        }

        public static int registrarVentademPhone3000()
        {
            int opcion = registrarVentadeee("mPhone 3000");
            if (opcion == 3) return 0;
            if (opcion == 1)
            {
                do
                {
                    opcion = registrarVenta10000("mPhone 3000");
                    totaldemPhone3000++;
                } while (opcion != 2);
                totaldemPhone3000--;
                return 1;
            }
            if (opcion == 2)
            {
                do
                {
                    opcion = registrarDevolucion10000("mPhone 3000");
                    totaldemPhone3000--;
                } while (opcion != 2);
                totaldemPhone3000++;
                return 1;
            }
            return opcion;
        }


        public static int registrarVentademPad3500()
        {
            int opcion = registrarVentadeee("mPad 3500");
            if (opcion == 3) return 0;
            if (opcion == 1)
            {
                do
                {
                    opcion = registrarVenta10000("mPad 3500");
                    totaldemPad3500++;
                } while (opcion != 2);
                totaldemPad3500--;
                return 1;
            }
            if (opcion == 2)
            {
                do
                {
                    opcion = registrarDevolucion10000("mPad 3500");
                    totaldemPad3500--;
                } while (opcion != 2);
                totaldemPad3500++;
                return 1;
            }
            return opcion;
        }


        public static int registrarVentadeMAPBrook3800()
        {
            int opcion = registrarVentadeee("MAPBrook 3800");
            if (opcion == 3) return 0;
            if (opcion == 1)
            {
                do
                {
                    opcion = registrarVenta10000("MAPBrook 3800");
                    totaldeMAPBrook3800++;
                } while (opcion != 2);
                totaldeMAPBrook3800--;
                return 1;
            }
            if (opcion == 2)
            {
                do
                {
                    opcion = registrarDevolucion10000("MAPBrook 3800");
                    totaldeMAPBrook3800--;
                } while (opcion != 2);
                totaldeMAPBrook3800++;
                return 1;
            }
            return opcion;
        }


        public static int registrarVentademWatch8000()
        {
            int opcion = registrarVentadeee("mWatch 8000");
            if (opcion == 3) return 0;
            if (opcion == 1)
            {
                do
                {
                    opcion = registrarVenta10000("mWatch 8000");
                    totaldemWatch8000++;
                } while (opcion != 2);
                totaldemWatch8000--;
                return 1;
            }
            if (opcion == 2)
            {
                do
                {
                    opcion = registrarDevolucion10000("mWatch 8000");
                    totaldemWatch8000--;
                } while (opcion != 2);
                totaldemWatch8000++;
                return 1;
            }
            return opcion;
        }




        public static int registrarVentadeee(string Texto)
        {
            Console.Clear();
            Console.Write("================================\n" +
                "Registrar Venta de " + Texto + "\n" +
                "================================\n" +
                "1: Registrar Venta\n" +
                "2: Registrar Devolución\n" +
                "3: Menu Principal\n" +
                "================================\n");
                return piePantallaprincipal("Ingrese una opción: ");
        }




        public static int registrarVenta10000(string Texto)
        {
            Console.Clear();
            Console.Write("================================\n" +
                "Registrar venta de:\n" +
                "================================\n" +
                "Se va a registrar la venta de\n" +
                "un " + Texto + " ¿Desea Continuar?\n" +
                "1: Sí\n" +
                "2: No\n" +
                "================================\n");
                return piePantallaprincipal("Ingrese una opción: ");
        }
            
        public static int registrarDevolucion10000(string Texto)
        {
            Console.Clear();
            Console.Write("================================\n" +
                "Registrar devolución de:\n" +
                "================================\n" +
                "Se va a registrar la devolución de\n" +
                "un " + Texto + " ¿Desea Continuar?\n" +
                "1: Sí\n" +
                "2: No\n" +
                "================================\n");
                return piePantallaprincipal("Ingrese una opción: ");
        }


        public static void pantallaFinal()
        {
            int total = totaldemPhone3000 + totaldemPad3500 + totaldeMAPBrook3800 + totaldemWatch8000;
            Console.Write("================================\n" +
                "Reporte Final\n" +
                "================================\n" +
                "Productos Vendidos | Cantidad\n" +
                "--------------------------------\n" +
                "mPhones        \t| "+ totaldemPhone3000 + "\n" +
                "mPads          \t| "+ totaldemPad3500+"\n" +
                "MAPBrooks      \t| "+ totaldeMAPBrook3800+"\n" +
                "mWatches       \t| "+ totaldemWatch8000 + "\n" +
                "--------------------------------\n" +
                "Total          \t| "+total+"\n" +
                "================================\n" +
                "\n"+
                "\n"+
                "\n"+
                "¡Hasta Luego!Diseñado Por: [Cristhian Jean Pierre Quiroz Bernaola]");

            Console.ReadKey();
        }



        private static int piePantallaprincipal(string Texto)
        {
            Console.Write(Texto);
            return int.Parse(Console.ReadLine());
        }


    }
}
