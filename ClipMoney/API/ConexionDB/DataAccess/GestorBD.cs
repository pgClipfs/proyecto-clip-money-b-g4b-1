using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionDB.DataAccess
{
    public class GestorBD
    {
        public static string GetConnectionString(string connectionName = "Billetera_Electronica")
        {

            return ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;
        }
        /// <summary>
        /// Obtengo un listado del tipo T
        /// </summary>
        /// <typeparam name="T">Tipo de tabla</typeparam>
        /// <param name="sql">Consulta select a ejecutar</param>
        /// <returns></returns>
        public static List<T> GetList<T>(string sql)
        {

            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {

                return cnn.Query<T>(sql).ToList();
            }
        }
        /// <summary>
        /// Obtengo un objecto a traves de una consulta select
        /// </summary>
        /// <typeparam name="T">Tipo de objeto</typeparam>
        /// <param name="sql">Consulta a ejecutar</param>
        /// <returns></returns>
        public static T GetObject<T>(string sql)
        {

            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {

                return cnn.Query<T>(sql).FirstOrDefault();
            }
        }


        /// <summary>
        /// Obtengo la cantidad de las filas afectadas por la sentencia
        /// </summary>
        /// <typeparam name="T">Tipo de tabla</typeparam>
        /// <param name="sql">Sentencia Insert,Update o Delete</param>
        /// <param name="data">Objecto a ser operado</param>
        /// <returns></returns>
        public static int SaveData<T>(string sql, T data)
        {

            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                int cantidad = 0;
                try
                {
                    cantidad = cnn.ExecuteScalar<int>(sql, data);
                }
                catch (Exception ex) 
                {
                    Console.WriteLine(ex.Message);
                   
                }
                return cantidad;
            }
        }

        /// <summary>
        /// Obtengo la cantidad de las filas afectadas por la sentencia
        /// </summary>
        /// <typeparam name="T">Tipo de tabla</typeparam>
        /// <param name="sql">Sentencia Insert,Update o Delete</param>
        /// <param name="data">Listado de objectos a ser operados</param>
        /// <returns></returns>
        public static int SaveListData<T>(string sql, List<T> data)
        {

            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {

                return cnn.Execute(sql, data.ToArray());
            }
        }

    }
}
