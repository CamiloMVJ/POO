﻿namespace pjBoletas
{
    partial class frmBoleta
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNumBoleta = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttRegistrar = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.ComboBox();
            this.lvEstadistica = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.label8 = new System.Windows.Forms.Label();
            this.lblImporte = new System.Windows.Forms.Label();
            this.buttEstadistica = new System.Windows.Forms.Button();
            this.buttLimpiar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumBoleta
            // 
            this.lblNumBoleta.AutoSize = true;
            this.lblNumBoleta.Location = new System.Drawing.Point(14, 43);
            this.lblNumBoleta.Name = "lblNumBoleta";
            this.lblNumBoleta.Size = new System.Drawing.Size(51, 21);
            this.lblNumBoleta.TabIndex = 0;
            this.lblNumBoleta.Text = "label1";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(14, 89);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(54, 21);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(291, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Control de venta de productos";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(83, 233);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(301, 29);
            this.txtNombre.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttRegistrar);
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblPrecio);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(72, 363);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 226);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del producto";
            // 
            // buttRegistrar
            // 
            this.buttRegistrar.AutoSize = true;
            this.buttRegistrar.Location = new System.Drawing.Point(28, 164);
            this.buttRegistrar.Name = "buttRegistrar";
            this.buttRegistrar.Size = new System.Drawing.Size(86, 31);
            this.buttRegistrar.TabIndex = 13;
            this.buttRegistrar.Text = "Registrar";
            this.buttRegistrar.UseVisualStyleBackColor = true;
            this.buttRegistrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(210, 112);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(75, 29);
            this.txtCantidad.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(210, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 21);
            this.label7.TabIndex = 2;
            this.label7.Text = "Cantidad";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(26, 112);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(56, 21);
            this.lblPrecio.TabIndex = 1;
            this.lblPrecio.Text = "Precio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Precio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Direccion";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(83, 301);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(301, 29);
            this.txtDireccion.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(432, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "DNI";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(432, 233);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(216, 29);
            this.txtDNI.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(432, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Producto";
            // 
            // txtProducto
            // 
            this.txtProducto.FormattingEnabled = true;
            this.txtProducto.Items.AddRange(new object[] {
            "PS5+ 1 MANDO DS5",
            "PS4 (1TB) + 1 MANDO DS4",
            "MANDO PS5/DS5",
            "MANDO PS4/DS4"});
            this.txtProducto.Location = new System.Drawing.Point(432, 301);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(216, 29);
            this.txtProducto.TabIndex = 12;
            this.txtProducto.Text = "Seleccione un producto";
            this.txtProducto.TextChanged += new System.EventHandler(this.txtProducto_TextChanged);
            // 
            // lvEstadistica
            // 
            this.lvEstadistica.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvEstadistica.GridLines = true;
            this.lvEstadistica.Location = new System.Drawing.Point(72, 644);
            this.lvEstadistica.Name = "lvEstadistica";
            this.lvEstadistica.Size = new System.Drawing.Size(826, 215);
            this.lvEstadistica.TabIndex = 13;
            this.lvEstadistica.UseCompatibleStateImageBehavior = false;
            this.lvEstadistica.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Codigo de la boleta";
            this.columnHeader1.Width = 160;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Fecha de registro";
            this.columnHeader2.Width = 180;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Total de productos comprados";
            this.columnHeader3.Width = 260;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Monto total";
            this.columnHeader4.Width = 120;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(415, 439);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 21);
            this.label8.TabIndex = 14;
            this.label8.Text = "Importe";
            // 
            // lblImporte
            // 
            this.lblImporte.AutoSize = true;
            this.lblImporte.Location = new System.Drawing.Point(415, 476);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(70, 21);
            this.lblImporte.TabIndex = 15;
            this.lblImporte.Text = "Importe";
            // 
            // buttEstadistica
            // 
            this.buttEstadistica.AutoSize = true;
            this.buttEstadistica.Location = new System.Drawing.Point(802, 607);
            this.buttEstadistica.Name = "buttEstadistica";
            this.buttEstadistica.Size = new System.Drawing.Size(96, 31);
            this.buttEstadistica.TabIndex = 17;
            this.buttEstadistica.Text = "Estadistica";
            this.buttEstadistica.UseVisualStyleBackColor = true;
            this.buttEstadistica.Click += new System.EventHandler(this.buttEstadistica_Click);
            // 
            // buttLimpiar
            // 
            this.buttLimpiar.AutoSize = true;
            this.buttLimpiar.Location = new System.Drawing.Point(415, 558);
            this.buttLimpiar.Name = "buttLimpiar";
            this.buttLimpiar.Size = new System.Drawing.Size(86, 31);
            this.buttLimpiar.TabIndex = 14;
            this.buttLimpiar.Text = "Limpiar";
            this.buttLimpiar.UseVisualStyleBackColor = true;
            this.buttLimpiar.Click += new System.EventHandler(this.buttLimpiar_Click);
            // 
            // frmBoleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(967, 910);
            this.Controls.Add(this.buttLimpiar);
            this.Controls.Add(this.buttEstadistica);
            this.Controls.Add(this.lblImporte);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lvEstadistica);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblNumBoleta);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmBoleta";
            this.Text = "Control de venta de productos";
            this.Load += new System.EventHandler(this.frmBoleta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNumBoleta;
        private Label lblFecha;
        private Label label1;
        private TextBox txtNombre;
        private GroupBox groupBox1;
        private Label label2;
        private Label label3;
        private TextBox txtDireccion;
        private Label label4;
        private TextBox txtDNI;
        private Label label5;
        private Label lblPrecio;
        private Label label6;
        private TextBox txtCantidad;
        private Label label7;
        private ComboBox txtProducto;
        private Label lblImporte;
        private Label label8;
        private Button buttRegistrar;
        private ListView lvEstadistica;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button buttEstadistica;
        private Button buttLimpiar;
    }
}