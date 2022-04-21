using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanzasConsoleNETF
{
    class Clientes
    {
        public void InsertarCliente()
        {
            string idCliente;
            string nombreCompleto;

            Console.WriteLine("Ingrese el documento de identificación");

            idCliente = Console.ReadLine();

            Console.WriteLine("Ingrese el nombre completo");

            nombreCompleto = Console.ReadLine();

            Console.WriteLine("El documento de identificación ingresado es: {0}\n" +
                "El nombre ingresado es: {1}", idCliente, nombreCompleto);

            Console.ReadKey();
        }
    }
}
