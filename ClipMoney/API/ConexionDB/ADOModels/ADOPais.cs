using ConexionDB.DataAccess;
using ConexionDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionDB.ADOModels
{
    public class ADOPais : ICRUD<Pais>
    {
        public bool Eliminar(string filtro)
        {
            throw new NotImplementedException();
        }

        public bool GuardarElemento(Pais elemento)
        {
            throw new NotImplementedException();
        }

        public bool ModificarElemento(Pais elemento)
        {
            throw new NotImplementedException();
        }

        public List<Pais> ObtenerLista(string filtro)
        {
            throw new NotImplementedException();
        }
    }
}
