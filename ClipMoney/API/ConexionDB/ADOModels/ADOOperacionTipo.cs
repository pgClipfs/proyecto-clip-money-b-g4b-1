using ConexionDB.DataAccess;
using ConexionDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionDB.ADOModels
{
    public class ADOOperacionTipo : ICRUD<OperacionTipo>
    {
        public bool Eliminar(string filtro)
        {
            throw new NotImplementedException();
        }

        public bool GuardarElemento(OperacionTipo elemento)
        {
            throw new NotImplementedException();
        }

        public bool ModificarElemento(OperacionTipo elemento)
        {
            throw new NotImplementedException();
        }

        public List<OperacionTipo> ObtenerLista(string filtro)
        {
            throw new NotImplementedException();
        }
    }
}
