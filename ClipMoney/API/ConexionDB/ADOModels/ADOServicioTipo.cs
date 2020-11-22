using ConexionDB.DataAccess;
using ConexionDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionDB.ADOModels
{
    public class ADOServicioTipo : ICRUD<ServicioTipo>
    {
        public bool Eliminar(string filtro)
        {
            throw new NotImplementedException();
        }

        public bool GuardarElemento(ServicioTipo elemento)
        {
            throw new NotImplementedException();
        }

        public bool ModificarElemento(ServicioTipo elemento)
        {
            throw new NotImplementedException();
        }

        public List<ServicioTipo> ObtenerLista(string filtro)
        {
            throw new NotImplementedException();
        }
    }
}
