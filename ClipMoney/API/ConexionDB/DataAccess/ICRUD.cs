using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionDB.DataAccess
{
   public interface ICRUD<T>
    {
        List<T> ObtenerLista(string filtro);
        bool Eliminar(string filtro);
        bool GuardarElemento(T elemento);
        bool ModificarElemento(T elemento);

    }
}
