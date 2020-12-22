using ConexionDB.DataAccess;
using ConexionDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionDB.ADOModels
{
    public class ADOCuenta : ICRUD<Cuenta>
    {
        public bool Eliminar(string filtro)
        {
            throw new NotImplementedException();
        }

        public bool GuardarElemento(Cuenta elemento)
        {
            throw new NotImplementedException();
        }

        public bool ModificarElemento(Cuenta elemento)
        {
            throw new NotImplementedException();
        }

        public List<Cuenta> ObtenerLista(string filtro)
        {
            throw new NotImplementedException();
        }

        public Cuenta ObtenerCuenta(string usuario)
        {
            Cuenta cta = new Cuenta();
            string sql = $"SELECT * FROM CUENTAS WHERE usuario = '{usuario}';";
            cta = GestorBD.GetObject<Cuenta>(sql);
            string sql2 = $"SELECT id_tipo_cuenta, nombre, descripcion FROM CUENTATIPO WHERE id_tipo_cuenta = '{cta.id_tipo_cuenta}';";
            cta.cuentaTipo = GestorBD.GetObject<CuentaTipo>(sql2);
            string sql3 = $"SELECT usuario, nombre_titular, apellido_titular FROM USUARIOS WHERE usuario = '{cta.usuario}';";
            cta.user = GestorBD.GetObject<Usuario>(sql3);
            return cta;
        }

     
        public bool NuevaCuenta(Cuenta cuenta)
        {
            bool resultado = false;
            string sql = @"INSERT INTO CUENTAS (cvu, balance, descripcion, id_tipo_cuenta, estado, fecha_creacion, fecha_baja, usuario, alias, total_giro_descubierto)
                        VALUES(@cvu, @balance, @descripcion, @id_tipo_cuenta, @estado, @fecha_creacion, @fecha_baja, @usuario, @alias, @total_giro_descubierto);";

            int cantidad = GestorBD.SaveData(sql, cuenta);
            resultado = cantidad > 0 ? true : false;

            return resultado;
        }

    }
}
