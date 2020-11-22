using ConexionDB.ADOModels;
using ConexionDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace WebAPI.Controllers
{
    
    public class UsuarioController : ApiController
    {
        ADOUsuario dataAccess = new ADOUsuario();


        
        [HttpGet]
        // GET: api/Usuario/5
        [ActionName("UsuarioLogueado")]
        public Usuario UsuarioLogueado(string usuario, string contrasenia)
        {
            Usuario user = new Usuario();
            user = dataAccess.ObtenerUsuario(usuario,contrasenia);
            return user;
        }


        [HttpPost]
        [ActionName("GuardarUsuario")]
        [ResponseType(typeof(bool))]
        public bool GuardarUsuario(Usuario usuarioG)
        {
            bool resultado = false;

            resultado = dataAccess.GuardarUsuario(usuarioG);
            return resultado;
        }

        [HttpPost]
        [ActionName("ModificarUsuario")]
        public bool ModificarUsuario(Usuario usuarioM)
        {
            bool resultado = false;

            resultado = dataAccess.ModificarUsuario(usuarioM);
            return resultado;
        }


        [HttpPost]
        [ActionName("PruebaUsuario")]
        public bool PruebaUsuario([FromBody] int prueba)
        {
            bool resultado = false;
            prueba += 1;
            return resultado;
        }
    }
}
