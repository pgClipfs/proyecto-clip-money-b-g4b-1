using ConexionDB.DataAccess;
using ConexionDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionDB.ADOModels
{
    public class ADOPlazoFijo : ICRUD<PlazoFijo>
    {
        public bool Eliminar(string filtro)
        {
            throw new NotImplementedException();
        }

        public bool GuardarElemento(PlazoFijo elemento)
        {
            throw new NotImplementedException();
        }

        public bool ModificarElemento(PlazoFijo elemento)
        {
            throw new NotImplementedException();
        }

        public List<PlazoFijo> ObtenerLista(string filtro)
        {
            throw new NotImplementedException();
        }
    }
}
