﻿namespace TrabajoPrácticoPAV.Formularios.Listados.Pasajeros
{
    partial class Frm_ReporteFamiliareXPasajero
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_consultar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TrabajoPrácticoPAV.Formularios.Listados.Pasajeros.Frm_ReporteFamiliareXPasajero.r" +
    "dlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 157);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(776, 281);
            this.reportViewer1.TabIndex = 0;
            // 
            // btn_consultar
            // 
            this.btn_consultar.Location = new System.Drawing.Point(678, 104);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Pp_Presionado = false;
            this.btn_consultar.Size = new System.Drawing.Size(75, 23);
            this.btn_consultar.TabIndex = 1;
            this.btn_consultar.Text = "Concultar";
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // Frm_ReporteFamiliareXPasajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_consultar);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_ReporteFamiliareXPasajero";
            this.Text = "Frm_ReporteFamiliareXPasajero";
            this.Load += new System.EventHandler(this.Frm_ReporteFamiliareXPasajero_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Clase.Button_Aerolinea btn_consultar;
    }
}