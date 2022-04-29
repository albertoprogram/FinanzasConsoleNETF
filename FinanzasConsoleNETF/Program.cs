using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanzasConsoleNETF
{
    class Program
    {
        public const string conexionDb =
            @"Server=.\;Database=Finanzas;User Id=desarrollo;Password=desarrollo;Pooling=false;";

        static void Main(string[] args)
        {
            Clientes cliente = new Clientes();

            cliente.InsertarCliente();
        }
    }
}
