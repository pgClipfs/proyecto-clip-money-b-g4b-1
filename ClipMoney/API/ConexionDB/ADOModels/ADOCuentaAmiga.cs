using ConexionDB.DataAccess;
using ConexionDB.DTOModels;
using ConexionDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionDB.ADOModels
{
   public class ADOCuentaAmiga
    {
        public bool Eliminar(string filtro)
        {
            throw new NotImplementedException();
        }

        public bool GuardarElemento(CuentaAmiga elemento)
        {
            throw new NotImplementedException();
        }

        public bool ModificarElemento(CuentaAmiga elemento)
        {
            throw new NotImplementedException();
        }

        public List<CuentaAmiga> ObtenerLista(string filtro)
        {
            throw new NotImplementedException();
        }

        public List<DTOCuentaAmiga> ObtenerCuentasAmigas(int id_usuario)
        {
            List<DTOCuentaAmiga> cas = new List<DTOCuentaAmiga>();
            string sql = $"SELECT ca.CVU, u.nombre_titular, u.apellido_titular " +
                $" FROM CuentasAmigas ca " +
                $" JOIN Usuarios u " +
                $" ON ca.id_usuario = u.id_usuario " +
                $" JOIN Cuentas c " +
                $" ON ca.CVU = c.CVU " +
                $" WHERE u.id_usuario = '{id_usuario}';";
            cas = GestorBD.GetList<DTOCuentaAmiga>(sql);

            return cas;
        }

        public CuentaAmiga ObtenerCuentaAmiga(int id_cuenta_amiga)
        {
            CuentaAmiga ca = new CuentaAmiga();
            string sql = $"SELECT * FROM CuentasAmigas WHERE id_cuenta_amiga = '{id_cuenta_amiga}';";
            ca = GestorBD.GetObject<CuentaAmiga>(sql);
            
            return ca;
        }

    }
}
