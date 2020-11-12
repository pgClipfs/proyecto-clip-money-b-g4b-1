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
    }
}
