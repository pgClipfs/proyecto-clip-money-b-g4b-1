using ConexionDB.ADOModels;
using ConexionDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.Controllers
{
    public class UsuarioController : ApiController
    {
        ADOUsuario dataAccess = new ADOUsuario();


        
        [HttpGet]
        // GET: api/Usuario/5
        public Usuario UsuarioLogueado(string usuario, string contrasenia)
        {
            Usuario user = new Usuario();
            user = dataAccess.ObtenerUsuario(usuario,contrasenia);
            return user;
        }


        [HttpPost]
        public bool GuardarUsuario(Usuario usuarioG)
        {
            bool resultado = false;

            resultado = dataAccess.GuardarUsuario(usuarioG);
            return resultado;
        }

       

    }
}
