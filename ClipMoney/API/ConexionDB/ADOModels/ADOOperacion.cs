using ConexionDB.DataAccess;
using ConexionDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionDB.ADOModels
{
    public class ADOOperacion : ICRUD<Operacion>
    {
        public bool Eliminar(string filtro)
        {
            throw new NotImplementedException();
        }

        public bool GuardarElemento(Operacion elemento)
        {
            throw new NotImplementedException();
        }

        public bool ModificarElemento(Operacion elemento)
        {
            throw new NotImplementedException();
        }

        public List<Operacion> ObtenerLista(string filtro)
        {
            throw new NotImplementedException();
        }

        public Operacion ObtenerOperacion(int id_operacion, int CVU_cuenta)
        {
            Operacion opc = new Operacion();
            string sql = $"SELECT * FROM OPERACIONES WHERE id_operacion = '{id_operacion}' AND CVU_cuenta = '{CVU_cuenta}';";
            opc = GestorBD.GetObject<Operacion>(sql);
            string sql2 = $"SELECT id_tipo_operacion, descripcion, nombre FROM OPERACIONESTIPO WHERE id_tipo_operacion = '{opc.id_tipo_operacion}';";
            opc.operacionTipo = GestorBD.GetObject<OperacionTipo>(sql2);
            string sql3 = $"SELECT id_moneda, nombre FROM MONEDAS WHERE id_moneda = '{opc.id_moneda}';";
            opc.moneda = GestorBD.GetObject<Moneda>(sql3);
            return opc;
        }

        public Operacion ObtenerOperaciones(int CVU_cuenta)
        {
            Operacion opc = new Operacion();
            string sql = $"SELECT * FROM OPERACIONES WHERE CVU_cuenta = '{CVU_cuenta}';";
            opc = GestorBD.GetObject<Operacion>(sql);
            string sql2 = $"SELECT id_tipo_operacion, descripcion, nombre FROM OPERACIONESTIPO WHERE id_tipo_operacion = '{opc.id_tipo_operacion}';";
            opc.operacionTipo = GestorBD.GetObject<OperacionTipo>(sql2);
            string sql3 = $"SELECT id_moneda, nombre FROM MONEDAS WHERE id_moneda = '{opc.id_moneda}';";
            opc.moneda = GestorBD.GetObject<Moneda>(sql3);
            return opc;
        }

      
        public bool NuevaOperacion(Operacion operacion, double balanceOrigen)
        {
            bool resultado = false;
            string sql = @"INSERT INTO OPERACIONES ( CVU_cuenta, CVU_cuenta_destino, CVU_cuenta_origen, verificacion_banco, descripcion, fecha_ocurrencia, monto_original, monto, id_tipo_operacion, verificacion_origen_destino, id_moneda)
                        OUTPUT Inserted.id_operacion
                        VALUES(@CVU_cuenta, @CVU_cuenta_destino, @CVU_cuenta_origen, @verificacion_banco, @descripcion, @fecha_ocurrencia, @monto_original, @monto, @id_tipo_operacion, @verificacion_origen_destino, @id_moneda);";

            int cantidad = GestorBD.SaveData(sql, operacion);
            if(cantidad > 0)
            {
                string sqlUpdate = $"UPDATE Cuentas SET balance = {balanceOrigen-operacion.monto} WHERE CVU = {operacion.CVU_cuenta_Origen}";
                GestorBD.SaveData(sqlUpdate, operacion);

                string sqlUpdateDest = $"  UPDATE Cuentas SET balance = (SELECT balance + {operacion.monto} FROM Cuentas WHERE CVU = {operacion.CVU_cuenta_destino}) WHERE CVU = {operacion.CVU_cuenta_destino}";
                GestorBD.SaveData(sqlUpdateDest, operacion);
                resultado = true;
            }
            

            return resultado;
        }
    }
}
