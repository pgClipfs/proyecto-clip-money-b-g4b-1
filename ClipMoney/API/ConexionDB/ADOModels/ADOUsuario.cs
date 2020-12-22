using ConexionDB.DataAccess;
using ConexionDB.Helpers;
using ConexionDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionDB.ADOModels
{
   public class ADOUsuario : ICRUD<Usuario>
    {
        public bool Eliminar(string filtro)
        {
            throw new NotImplementedException();
        }

        public bool GuardarElemento(Usuario elemento)
        {
            throw new NotImplementedException();
        }

        public bool ModificarElemento(Usuario elemento)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> ObtenerLista(string filtro)
        {
            throw new NotImplementedException();
        }

        public Usuario ObtenerUsuario(string usuario, string contrasenia)
        {
            Usuario user = new Usuario();
            contrasenia = Security.Encrypt(contrasenia);
            string sql = $"SELECT * FROM USUARIOS WHERE usuario = '{usuario}' and contrasenia = '{contrasenia}';";
            user = GestorBD.GetObject<Usuario>(sql);
            if (user != null) { 
                string sql2 = $"SELECT * FROM BARRIOS WHERE id_barrio = '{user.id_barrio}';";
                user.barrio = GestorBD.GetObject<Barrio>(sql2);  

                user.contrasenia = Security.Decrypt(user.contrasenia);
            }

            return user;
        }


        public bool GuardarUsuario(Usuario usuario) {
            bool resultado = false;
            usuario.id_barrio = usuario.barrio.id_barrio;
            usuario.contrasenia = Security.Encrypt(usuario.contrasenia);
            string sql = @"INSERT INTO USUARIOS (usuario, nombre_titular, apellido_titular, contrasenia, telefono, mail,fecha_nacimiento,DNI,calle_direccion,numero_direccion,id_barrio)
                            OUTPUT Inserted.id_usuario
                            VALUES(@usuario, @nombre_titular, @apellido_titular, @contrasenia, @telefono, @mail,@fecha_nacimiento,@DNI,@calle_direccion,@numero_direccion, @id_barrio);";

            int cantidad = GestorBD.SaveData(sql, usuario);
            resultado = cantidad > 0 ? true : false;
            if (resultado) {
                var words = new[] { "apple", "mango", "papaya", "banana", "guava", "pineapple" };
                words = words.OrderBy(i => Guid.NewGuid()).ToArray();

                DateTime localDate = DateTime.Now;
                Cuenta cuenta = new Cuenta(0,0,"Cuenta pesos CM",1,true, localDate, localDate, usuario.usuario,words[0]+"."+ words[3] + "."+words[1],0);
                string sqlCuentas = @"INSERT INTO Cuentas (balance, descripcion, id_tipo_cuenta, estado, fecha_creacion, fecha_baja, usuario, alias, total_giro_descubierto)
                                    OUTPUT Inserted.CVU
                                    VALUES(@balance, @descripcion, @id_tipo_cuenta, @estado, @fecha_creacion, @fecha_baja, @usuario, @alias, @total_giro_descubierto)";
                cantidad = GestorBD.SaveData(sqlCuentas, cuenta);
                resultado = cantidad > 0 ? true : false;
            }

            return resultado;
        }


        public bool ModificarUsuario(Usuario usuario)
        {
            bool resultado = false;
            string sql = @"UPDATE USUARIOS 
                        SET mail = @mail,
                            telefono = @telefono,
                            calle_direccion = @calle_direccion,
                            numero_direccion = @numero_direccion
                        WHERE usuario = @usuario;";

            int cantidad = GestorBD.SaveData(sql, usuario);
            resultado = cantidad > 0 ? true : false;
            return resultado;
        }


        /*
        /// <summary>
        /// verifica si el mail y la contraseña son correctos y devuelve el usuario
        /// </summary>
        /// <param name="mail">Es el mail del usuario</param>
        /// <param name="password">Es la contraseña del usuario</param>
        /// <returns></returnsUsuario>
        public static  ObtenerUsuario(string usuario, string contrasenia)
        {
            Usuario usuario = new Usuario();
            string sql = $"SELECT * FROM USUARIOS WHERE MailUsuario = '{mail}' and PasswordUsuario = '{password}'";
            usuario = GestorBD.GetObject<Usuario>(sql);
            return usuario;
        }

        public static int GuardarUsuario(Usuarios usuario)
        {
            string sql = @"INSERT INTO USUARIOS (NombreUsuario, TelefonoUsuario, MailUsuario, NotificarUsuario, PasswordUsuario, imagenUsuario) 
                        OUTPUT Inserted.IdUsuario 
                        VALUES(@NombreUsuario, @TelefonoUsuario, @MailUsuario, @NotificarUsuario, @PasswordUsuario, @imagenUsuario)";
            return GestorDB.SaveData(sql, usuario);
        }

        public static int GuardarUsuario(Usuarios usuario)
        {
            string sql = @"UPDATE USUARIOS SET  NombreUsuario = @NombreUsuario, TelefonoUsuario = @TelefonoUsuario, 
                        MailUsuario = @MailUsuario, NotificarUsuario = @NotificarUsuario, PasswordUsuario = @PasswordUsuario, imagenUsuario = @imagenUsuario
                        WHERE IdUsuario = @IdUsuario";
            return GestorDB.SaveData(sql, usuario);
        }*/
    }
}
