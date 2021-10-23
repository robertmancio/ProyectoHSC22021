﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace CMcompras
{
    class clsconexion
    {
        public OdbcConnection conexion()
        {
            Console.WriteLine("Ingreso a clase conexion");
            //creacion de la conexion via ODBC
            OdbcConnection conn = new OdbcConnection("Dsn=ConexionHSC");
            try
            {
                conn.Open();
            }
            catch (OdbcException)
            {
                Console.WriteLine("No Conectó");
            }
            return conn;
        }

        //metodo para cerrar la conexion
        public void desconexion(OdbcConnection conn)
        {
            try
            {
                conn.Close();
            }
            catch (OdbcException)
            {
                Console.WriteLine("No Conectó");
            }
        }
    }
}
