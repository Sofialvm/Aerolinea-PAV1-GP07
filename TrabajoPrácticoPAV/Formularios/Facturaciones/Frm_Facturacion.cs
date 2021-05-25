﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPrácticoPAV.Clase;
using TrabajoPrácticoPAV.Clase.Modelos;
using TrabajoPrácticoPAV.Formularios.Reservas;
using TrabajoPrácticoPAV.NE_Usuarios;
using static TrabajoPrácticoPAV.Clase.Tratamientos_Especiales;


namespace TrabajoPrácticoPAV.Formularios.Facturaciones
{
    public partial class Frm_Facturacion : Form
    {
        NE_Facturacion facturacion = new NE_Facturacion();
        DataTable tabla = new DataTable();
        public Frm_Facturacion()
        {
            InitializeComponent();
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Facturacion_Load(object sender, EventArgs e)
        {
            grid_vuelo.Formatear();
        }

        private void btn_buscarPasajero_Click(object sender, EventArgs e)
        {
            tabla = facturacion.RecuperarPasajero(txt_numeroReserva.ToString());
            if (tabla.Rows.Count != 0)
            {
                txt_numeroDoc.Text = tabla.Rows[0][0].ToString();
                txt_tipoDoc.Text = tabla.Rows[0][1].ToString();
                txt_nombre.Text = tabla.Rows[0][2].ToString();
                txt_apellido.Text = tabla.Rows[0][3].ToString();

            }
            else
            {
                MessageBox.Show("No se ha encontrado una reserva con el número de reserva ingresado.");
            }

        }
    }
}
