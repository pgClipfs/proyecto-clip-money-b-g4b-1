using ConexionDB.DataAccess;
using ConexionDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionDB.ADOModels
{
    public class ADOServicio : ICRUD<Servicio>
    {
        public bool Eliminar(string filtro)
        {
            throw new NotImplementedException();
        }

        public bool GuardarElemento(Servicio elemento)
        {
            throw new NotImplementedException();
        }

        public bool ModificarElemento(Servicio elemento)
        {
            throw new NotImplementedException();
        }

        public List<Servicio> ObtenerLista(string filtro)
        {
            throw new NotImplementedException();
        }
    }
}
