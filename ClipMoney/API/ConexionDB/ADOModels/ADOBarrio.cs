using ConexionDB.DataAccess;
using ConexionDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionDB.ADOModels
{
    public class ADOBarrio : ICRUD<Barrio>
    {
        public bool Eliminar(string filtro)
        {
            throw new NotImplementedException();
        }

        public bool GuardarElemento(Barrio elemento)
        {
            throw new NotImplementedException();
        }

        public bool ModificarElemento(Barrio elemento)
        {
            throw new NotImplementedException();
        }

        public List<Barrio> ObtenerLista(string filtro)
        {
            throw new NotImplementedException();
        }

        public List<Barrio> ObtenerBarrios()
        {
            List<Barrio> barrios = new List<Barrio>();
            string sql = $"SELECT * FROM BARRIOS;";
            barrios = GestorBD.GetList<Barrio>(sql);
          


            return barrios;
        }

    }
}
