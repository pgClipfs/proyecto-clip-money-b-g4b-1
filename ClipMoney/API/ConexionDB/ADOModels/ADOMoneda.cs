using ConexionDB.DataAccess;
using ConexionDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionDB.ADOModels
{
   public class ADOMoneda : ICRUD<Moneda>
    {
        public bool Eliminar(string filtro)
        {
            throw new NotImplementedException();
        }

        public bool GuardarElemento(Moneda elemento)
        {
            throw new NotImplementedException();
        }

        public bool ModificarElemento(Moneda elemento)
        {
            throw new NotImplementedException();
        }

        public List<Moneda> ObtenerLista(string filtro)
        {
            throw new NotImplementedException();
        }
    }
}
