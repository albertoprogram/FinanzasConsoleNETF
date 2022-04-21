using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanzasConsoleNETF
{
    class Program
    {
        static void Main(string[] args)
        {
            Clientes cliente = new Clientes();

            cliente.InsertarCliente();
        }
    }
}
