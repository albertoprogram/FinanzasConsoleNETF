using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

            try
            {
            inicio:
                Console.WriteLine("Ingrese el documento de identificación");

                idCliente = Console.ReadLine();

                Console.WriteLine("Ingrese el nombre completo");

                nombreCompleto = Console.ReadLine();

                string sqlInsert = "INSERT INTO Clientes (Id,NombreCompleto) VALUES " +
                    "('" + idCliente + "','" + nombreCompleto + "')";

                using (SqlConnection sqlConnection = new SqlConnection(Program.conexionDb))
                {
                    using (SqlCommand sqlCommand = new SqlCommand())
                    {
                        sqlCommand.CommandType = CommandType.Text;
                        sqlCommand.CommandText = sqlInsert;
                        sqlCommand.Connection = sqlConnection;

                        sqlConnection.Open();

                        sqlCommand.ExecuteNonQuery();

                        Console.WriteLine("El registro fue insertado con éxito.");
                    }
                }

                Console.WriteLine("El documento de identificación ingresado fue: {0}\n" +
                    "El nombre ingresado fue: {1}", idCliente, nombreCompleto);

                string continuar;

                Console.WriteLine("\n¿Desea ingresar otro registro? Y/N\n");

                continuar = Console.ReadLine();

                if (continuar.ToUpper() == "Y") goto inicio;

            }

            catch (Exception exception)
            {
                Console.WriteLine(exception.Message + " - Detalle: " + exception.ToString());
            }

            Console.ReadKey();
        }
    }
}
