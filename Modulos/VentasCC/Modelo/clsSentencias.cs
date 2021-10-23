using CapaModeloMVentasCC;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    public class clsSentencias
    {
        Conexion cn = new Conexion();

        //Llenando cbxTipoPoliza
        public OdbcDataReader llenarcbxTipoPoliza(string sql)
        {
            try
            {
                OdbcCommand datos = new OdbcCommand(sql, cn.conexion());
                OdbcDataReader leer = datos.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        //Llenando cbxCuenta
        public OdbcDataReader llenarcbxCuenta(string sql)
        {
            try
            {
                OdbcCommand datos = new OdbcCommand(sql, cn.conexion());
                OdbcDataReader leer = datos.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        //Llenando cbxTipoOperacion
        public OdbcDataReader llenarcbxTipoOperacion(string sql)
        {
            try
            {
                OdbcCommand datos = new OdbcCommand(sql, cn.conexion());
                OdbcDataReader leer = datos.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        //Obteniendo id del tipo de poliza
        public string consultaTipoPoliza(string nombre)
        {

            string id = "";
            string Query = "select * from tipoPoliza where descripcion='" + nombre + "';";

            OdbcCommand consulta = new OdbcCommand(Query, cn.conexion());
            consulta.ExecuteNonQuery();

            OdbcDataReader busqueda;
            busqueda = consulta.ExecuteReader();

            if (busqueda.Read())
            {

                id = busqueda["idTipoPoliza"].ToString();

            }


            return id;
        }

        //Obteniendo id de la cuenta
        public string consultaCuenta(string nombre)
        {

            string id = "";
            string Query = "select * from cuenta where nombre='" + nombre + "';";

            OdbcCommand consulta = new OdbcCommand(Query, cn.conexion());
            consulta.ExecuteNonQuery();

            OdbcDataReader busqueda;
            busqueda = consulta.ExecuteReader();

            if (busqueda.Read())
            {

                id = busqueda["idCuenta"].ToString();

            }


            return id;
        }

        //Obteniendo id de Tipo Operacion
        public string consultaTipoOperacion(string nombre)
        {

            string id = "";
            string Query = "select * from tipoOperacion where nombre='" + nombre + "';";

            OdbcCommand consulta = new OdbcCommand(Query, cn.conexion());
            consulta.ExecuteNonQuery();

            OdbcDataReader busqueda;
            busqueda = consulta.ExecuteReader();

            if (busqueda.Read())
            {

                id = busqueda["idTipoOperacion"].ToString();

            }


            return id;
        }

        //Insertando encabezado
        public void funInsertarEncabezado(string Id, string fecha, string idPoliza, string concepto)
        {
            string cadena = "INSERT INTO" +
            " polizaEncabezado VALUES (" + "'" + Id + "', '" + fecha + "' , '" + idPoliza + "' , '" + concepto + "');";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }


        //Insertando detalle
        public void funInsertarDetalle(string IdPoliza, string idEncabezado, string idCuenta, string saldo, string idTipoOperacion)
        {
            string cadena = "INSERT INTO" +
            " polizaDetalle VALUES (" + "'" + IdPoliza + "', '" + idEncabezado + "' , '" + idCuenta + "' , " + saldo + " , '" + idTipoOperacion +  "');";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }

    }
}
