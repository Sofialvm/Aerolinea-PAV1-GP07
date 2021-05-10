﻿namespace TrabajoPrácticoPAV.Formularios.Tipo_Asientos
{
    partial class Frm_AltaTipoAsiento
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Nombre = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.btn_Registrar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.btn_Cancelar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.msktxt_Costo = new TrabajoPrácticoPAV.Clase.MaskedTextBox_Aerolinea();
            this.BarraSuperior = new System.Windows.Forms.Panel();
            this.Titulo = new System.Windows.Forms.Label();
            this.BarraSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(88, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(102, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Costo";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(185, 78);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Pp_EsPk = false;
            this.txt_Nombre.Pp_MensajeError = "Por favor, introduzca nombre.";
            this.txt_Nombre.Pp_NombreCampo = "nombre";
            this.txt_Nombre.Pp_NombreTabla = "Tipo_Asiento";
            this.txt_Nombre.Size = new System.Drawing.Size(100, 22);
            this.txt_Nombre.TabIndex = 2;
            // 
            // btn_Registrar
            // 
            this.btn_Registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_Registrar.Location = new System.Drawing.Point(272, 230);
            this.btn_Registrar.Name = "btn_Registrar";
            this.btn_Registrar.Pp_Presionado = false;
            this.btn_Registrar.Size = new System.Drawing.Size(99, 34);
            this.btn_Registrar.TabIndex = 4;
            this.btn_Registrar.Text = "Registrar";
            this.btn_Registrar.UseVisualStyleBackColor = true;
            this.btn_Registrar.Click += new System.EventHandler(this.btn_Registrar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_Cancelar.Location = new System.Drawing.Point(479, 230);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Pp_Presionado = false;
            this.btn_Cancelar.Size = new System.Drawing.Size(99, 34);
            this.btn_Cancelar.TabIndex = 5;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // msktxt_Costo
            // 
            this.msktxt_Costo.Location = new System.Drawing.Point(185, 117);
            this.msktxt_Costo.Mask = "00000";
            this.msktxt_Costo.Name = "msktxt_Costo";
            this.msktxt_Costo.Pp_EsPk = false;
            this.msktxt_Costo.Pp_MensajeError = "Por favor, introduzca costo";
            this.msktxt_Costo.Pp_NombreCampo = "costo";
            this.msktxt_Costo.Pp_NombreTabla = "Tipo_Asiento";
            this.msktxt_Costo.Size = new System.Drawing.Size(100, 22);
            this.msktxt_Costo.TabIndex = 6;
            // 
            // BarraSuperior
            // 
            this.BarraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.BarraSuperior.Controls.Add(this.Titulo);
            this.BarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.BarraSuperior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BarraSuperior.Name = "BarraSuperior";
            this.BarraSuperior.Size = new System.Drawing.Size(855, 39);
            this.BarraSuperior.TabIndex = 48;
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Titulo.ForeColor = System.Drawing.Color.White;
            this.Titulo.Location = new System.Drawing.Point(12, 7);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(359, 27);
            this.Titulo.TabIndex = 4;
            this.Titulo.Text = "REGISTRAR NUEVO TIPO ASIENTO";
            // 
            // Frm_AltaTipoAsiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(227)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(855, 366);
            this.Controls.Add(this.BarraSuperior);
            this.Controls.Add(this.msktxt_Costo);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Registrar);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_AltaTipoAsiento";
            this.Text = "Frm_AltaTipoAsiento";
            this.Load += new System.EventHandler(this.Frm_AltaTipoAsiento_Load);
            this.BarraSuperior.ResumeLayout(false);
            this.BarraSuperior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Clase.TextBox_Aerolinea txt_Nombre;
        private Clase.Button_Aerolinea btn_Registrar;
        private Clase.Button_Aerolinea btn_Cancelar;
        private Clase.MaskedTextBox_Aerolinea msktxt_Costo;
        private System.Windows.Forms.Panel BarraSuperior;
        private System.Windows.Forms.Label Titulo;
    }
}