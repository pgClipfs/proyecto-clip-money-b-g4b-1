﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionDB.Models
{
    public class Cuenta
    {
        /// <summary>
        /// Es el identificador de Cuenta
        /// </summary>
        public int CVU { get; set; }
        /// <summary>
        /// Es el balance de la Cuenta
        /// </summary>
        public double balance { get; set; }
        /// <summary>
        /// Es la descripcion de la Cuenta
        /// </summary>
        public string descripcion { get; set; }
        /// <summary>
        /// Es el objeto CuentaTipo de Cuenta
        /// </summary>
        public CuentaTipo cuentaTipo { get; set; }
        /// <summary>
        /// Es el id del tipo de cuenta de Cuenta
        /// </summary>
        public int id_tipo_cuenta { get; set; }
        /// <summary>
        /// Es el estado de la Cuenta
        /// </summary>
        public bool estado { get; set; }
        /// <summary>
        /// Es la fecha de la creacion de la Cuenta
        /// </summary>
        public DateTime fecha_creacion { get; set; }
        /// <summary>
        /// Es la fecha de baja de la Cuenta
        /// </summary>
        public DateTime? fecha_baja { get; set; }
        /// <summary>
        /// Es el objeto Usuario de la Cuenta
        /// </summary>
        public Usuario user { get; set; }
        /// <summary>
        /// Referencia de usuario en Cuenta
        /// </summary>
        public string usuario { get; set; }
        /// <summary>
        /// Es el alias de la Cuenta
        /// </summary>
        public string alias { get; set; }
        /// <summary>
        /// Es el total del giro al descubierto de la Cuenta
        /// </summary>
        public double total_giro_descubierto { get; set; }


        public Cuenta(int cvu, double balance, string descripcion, int id_tipo_cuenta,bool estado, 
            DateTime fecha_creacion, DateTime fecha_baja, string usuario, string alias, double total_giro_descubierto)
        {
            this.CVU = cvu;
            this.balance = balance;
            this.descripcion = descripcion;
            this.id_tipo_cuenta = id_tipo_cuenta;
            this.estado = estado;
            this.fecha_creacion = fecha_creacion;
            this.fecha_baja = fecha_baja;
            this.usuario = usuario;
            this.alias = alias;
            this.total_giro_descubierto = total_giro_descubierto;

        }
        public Cuenta()
        {

        }
    }
}
