using CapaModelo;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaControlador
{
    public class conEnlaceVentas
    {
        clsSentencias sn = new clsSentencias();
        public OdbcDataReader llenarcbxTipoPoliza()
        {
            string sql = "SELECT descripcion FROM tipoPoliza;";
            return sn.llenarcbxTipoPoliza(sql);
        }

        public OdbcDataReader llenarcbxCuenta()
        {
            string sql = "SELECT nombre FROM cuenta;";
            return sn.llenarcbxCuenta(sql);
        }

        public OdbcDataReader llenarcbxTipoOperacion()
        {
            string sql = "SELECT nombre FROM tipoOperacion;";
            return sn.llenarcbxTipoOperacion(sql);
        }

        public string consultaTipoPoliza(string nombre)
        {
            string id = sn.consultaTipoPoliza(nombre);
            return id;
        }

        public string consultaCuenta(string nombre)
        {
            string id = sn.consultaCuenta(nombre);
            return id;
        }

        public string consultaTipoOperacion(string nombre)
        {
            string id = sn.consultaTipoOperacion(nombre);
            return id;
        }

        //Insertando enabezado
        public void insertarEncabezado(string Id, string fecha, string idPoliza, string concepto)
        {
            sn.funInsertarEncabezado(Id, fecha, idPoliza, concepto);
        }

        //Insertando detalle
        public void insertarDetalle(string IdPoliza, string idEncabezado, string idCuenta, string saldo, string idTipoOperacion)
        {
            sn.funInsertarDetalle(IdPoliza, idEncabezado, idCuenta, saldo, idTipoOperacion);
        }
    }
}
