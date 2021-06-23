﻿using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPrácticoPAV.Clase;
using TrabajoPrácticoPAV.NE_Usuarios;
using TrabajoPrácticoPAV.Formularios;

namespace TrabajoPrácticoPAV.Formularios.Estadisticas.TripulacionXcargo
{
    public partial class Frm_TripulacionXcargo : Form
    {
        Tratamientos_Especiales tratamientos = new Tratamientos_Especiales();
        NE_Tripulacion tripulacion = new NE_Tripulacion();
        DataTable tabla = new DataTable();

        public Frm_TripulacionXcargo()
        {
            InitializeComponent();
        }

        private void Frm_TripulacionXcargo_Load(object sender, EventArgs e)
        {
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);
            Rbutodos.Checked = true;
            //cmb_Modelo.CargarCombo();
            //this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();

        }
        private void button_Aerolinea1_Click(object sender, EventArgs e)
        {
            if (Rbutodos.Checked == true)
            {
                tabla = tripulacion.Reporte_EstadisticarecuperarTodos();
                if (tabla.Rows.Count != 0)
                    ArmarEstadisticaTripulacionXcargo();
                else
                {
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.RefreshReport();
                    MessageBox.Show("No se encontraron resultados para la búsqueda");
                }
            }
            //else if (rbu01.Checked == true)
            //{
            //    if (Txt_nombres.Text != "")
            //    {
            //        tabla = aeropuerto.Reporte_recuperarXNonmbre(Txt_nombres.Text);
            //        if (tabla.Rows.Count != 0)
            //            ArmarReporteAeropuertos();
            //        else
            //        {
            //            reportViewer1.LocalReport.DataSources.Clear();
            //            reportViewer1.RefreshReport();
            //            MessageBox.Show("No se encontraron resultados para la búsqueda");
            //        }
            //    }
            //    else
            //        MessageBox.Show("Por favor ingrese un nombre para realizar la búsqueda");

            //}
            //else if (rbu02.Checked == true)
            //{
            //    string desde = "";
            //    string hasta = "";
            //    if (txt_codigodesde.Text == "")
            //        desde = "a";
            //    else
            //        desde = txt_codigodesde.Text;
            //    if (txt_codigohasta.Text == "")
            //        hasta = "Z";
            //    else
            //        hasta = txt_codigohasta.Text;

            //    tabla = aeropuerto.Reporte_recuperarXCodigoRango(desde, hasta);
            //    if (tabla.Rows.Count != 0)
            //        ArmarReporteAeropuertos();
            //    else
            //    {
            //        reportViewer1.LocalReport.DataSources.Clear();
            //        reportViewer1.RefreshReport();
            //        MessageBox.Show("No se encontraron resultados para la búsqueda");
            //    }
            //}

            //else if (rbu03.Checked == true)
            //{
            //    if (cmb_pais.SelectedIndex != -1)
            //    {
            //        tabla = aeropuerto.Reporte_recuperarXpais(cmb_pais.SelectedValue.ToString());
            //        if (tabla.Rows.Count != 0)
            //            ArmarReporteAeropuertos();
            //        else
            //        {
            //            reportViewer1.LocalReport.DataSources.Clear();
            //            reportViewer1.RefreshReport();
            //            MessageBox.Show("No se encontraron resultados para la búsqueda");
            //        }
            //    }
            //}
            else
            {
                Tratamientos_Especiales Tratamiento = new Tratamientos_Especiales();
                if (Tratamiento.Validar(this.Controls) == Tratamientos_Especiales.Resultado.error)
                    MessageBox.Show("No realizo selección para la búsqueda");
            }
        }
        

        
        public void ArmarEstadisticaTripulacionXcargo()
        {
            ReportDataSource datos = new ReportDataSource("DataSet1", tabla);
            reportViewer1.LocalReport.ReportEmbeddedResource = "TrabajoPrácticoPAV.Formularios.Estadisticas.TripulacionXcargo.Reporte_TripulacionPorVuelo.rdlc";
            //ReportParameter[] parametros = new ReportParameter[1];
            //parametros[0] = new ReportParameter("Rp01", "Hola aca va parametro");
            //reportViewer1.LocalReport.SetParameters(parametros);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(datos);
            reportViewer1.RefreshReport();

        }


    }
}
