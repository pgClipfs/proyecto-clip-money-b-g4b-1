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

            if (cta != null)
            {
                string sql2 = $"SELECT * FROM CUENTATIPO WHERE id_tipo_cuenta = '{cta.id_tipo_cuenta}';";
                cta.cuentaTipo = GestorBD.GetObject<CuentaTipo>(sql2);
                if (cta.cuentaTipo != null) {
                    string sqlMoneda = $"SELECT * FROM Monedas WHERE id_moneda = '{cta.cuentaTipo.id_moneda}';";
                    cta.cuentaTipo.moneda = GestorBD.GetObject<Moneda>(sqlMoneda);
                }
                string sql3 = $"SELECT * FROM USUARIOS WHERE usuario = '{cta.usuario}';";
                cta.user = GestorBD.GetObject<Usuario>(sql3);
            }
            return cta;
        }

        public Cuenta ObtenerCuentaFiltro(string filtro)
        {
            Cuenta cta = new Cuenta();
            string sql = $"SELECT TOP 1 * FROM CUENTAS WHERE usuario = '{filtro}' OR alias = '{filtro}'";
            int filtroCVU;
            bool success = Int32.TryParse(filtro, out filtroCVU);
            if (success)
            {
                sql += $"OR CVU = {filtroCVU}";
            }
            cta = GestorBD.GetObject<Cuenta>(sql);
            if (cta != null)
            {
                string sql2 = $"SELECT * FROM CUENTATIPO WHERE id_tipo_cuenta = '{cta.id_tipo_cuenta}';";
                cta.cuentaTipo = GestorBD.GetObject<CuentaTipo>(sql2);
                string sql3 = $"SELECT * FROM USUARIOS WHERE usuario = '{cta.usuario}';";
                cta.user = GestorBD.GetObject<Usuario>(sql3);
            }
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
