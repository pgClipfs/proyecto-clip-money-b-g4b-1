using ConexionDB.DataAccess;
using ConexionDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionDB.ADOModels
{
   public class ADOLocalidad : ICRUD<Localidad>
    {
        public bool Eliminar(string filtro)
        {
            throw new NotImplementedException();
        }

        public bool GuardarElemento(Localidad elemento)
        {
            throw new NotImplementedException();
        }

        public bool ModificarElemento(Localidad elemento)
        {
            throw new NotImplementedException();
        }

        public List<Localidad> ObtenerLista(string filtro)
        {
            throw new NotImplementedException();
        }
    }
}
