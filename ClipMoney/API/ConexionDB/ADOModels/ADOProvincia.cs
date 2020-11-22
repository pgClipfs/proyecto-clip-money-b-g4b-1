using ConexionDB.DataAccess;
using ConexionDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionDB.ADOModels
{
    public class ADOProvincia : ICRUD<Provincia>
    {
        public bool Eliminar(string filtro)
        {
            throw new NotImplementedException();
        }

        public bool GuardarElemento(Provincia elemento)
        {
            throw new NotImplementedException();
        }

        public bool ModificarElemento(Provincia elemento)
        {
            throw new NotImplementedException();
        }

        public List<Provincia> ObtenerLista(string filtro)
        {
            throw new NotImplementedException();
        }
    }
}
