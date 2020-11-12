using ConexionDB.DataAccess;
using ConexionDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionDB.ADOModels
{
    public class ADOCuentaTipo : ICRUD<CuentaTipo>
    {
        public bool Eliminar(string filtro)
        {
            throw new NotImplementedException();
        }

        public bool GuardarElemento(CuentaTipo elemento)
        {
            throw new NotImplementedException();
        }

        public bool ModificarElemento(CuentaTipo elemento)
        {
            throw new NotImplementedException();
        }

        public List<CuentaTipo> ObtenerLista(string filtro)
        {
            throw new NotImplementedException();
        }
    }
}
