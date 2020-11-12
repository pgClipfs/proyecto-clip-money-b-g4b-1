using ConexionDB.DataAccess;
using ConexionDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionDB.ADOModels
{
    public class ADOOperacion : ICRUD<Operacion>
    {
        public bool Eliminar(string filtro)
        {
            throw new NotImplementedException();
        }

        public bool GuardarElemento(Operacion elemento)
        {
            throw new NotImplementedException();
        }

        public bool ModificarElemento(Operacion elemento)
        {
            throw new NotImplementedException();
        }

        public List<Operacion> ObtenerLista(string filtro)
        {
            throw new NotImplementedException();
        }
    }
}
