namespace Presentacion
{
    partial class Mantenimiento
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
            this.tbPeso = new System.Windows.Forms.TextBox();
            this.tbTamanio = new System.Windows.Forms.TextBox();
            this.tbDueno = new System.Windows.Forms.TextBox();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.dgvMantenimiento = new System.Windows.Forms.DataGridView();
            this.bnAgregar = new System.Windows.Forms.Button();
            this.bnModificar = new System.Windows.Forms.Button();
            this.bnEliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMantenimiento)).BeginInit();
            this.SuspendLayout();
            // 
            // tbPeso
            // 
            this.tbPeso.Location = new System.Drawing.Point(525, 100);
            this.tbPeso.Name = "tbPeso";
            this.tbPeso.Size = new System.Drawing.Size(197, 20);
            this.tbPeso.TabIndex = 20;
            // 
            // tbTamanio
            // 
            this.tbTamanio.Location = new System.Drawing.Point(189, 147);
            this.tbTamanio.Name = "tbTamanio";
            this.tbTamanio.Size = new System.Drawing.Size(197, 20);
            this.tbTamanio.TabIndex = 22;
            // 
            // tbDueno
            // 
            this.tbDueno.Location = new System.Drawing.Point(189, 103);
            this.tbDueno.Name = "tbDueno";
            this.tbDueno.Size = new System.Drawing.Size(197, 20);
            this.tbDueno.TabIndex = 23;
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(337, 51);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(197, 20);
            this.tbCodigo.TabIndex = 24;
            // 
            // dgvMantenimiento
            // 
            this.dgvMantenimiento.AllowUserToAddRows = false;
            this.dgvMantenimiento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMantenimiento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMantenimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMantenimiento.Location = new System.Drawing.Point(41, 272);
            this.dgvMantenimiento.Name = "dgvMantenimiento";
            this.dgvMantenimiento.RowHeadersVisible = false;
            this.dgvMantenimiento.Size = new System.Drawing.Size(723, 211);
            this.dgvMantenimiento.TabIndex = 17;
            this.dgvMantenimiento.SelectionChanged += new System.EventHandler(this.dgvMantenimiento_SelectionChanged);
            // 
            // bnAgregar
            // 
            this.bnAgregar.Location = new System.Drawing.Point(93, 218);
            this.bnAgregar.Name = "bnAgregar";
            this.bnAgregar.Size = new System.Drawing.Size(178, 36);
            this.bnAgregar.TabIndex = 14;
            this.bnAgregar.Text = "Agregar";
            this.bnAgregar.UseVisualStyleBackColor = true;
            this.bnAgregar.Click += new System.EventHandler(this.bnAgregar_Click);
            // 
            // bnModificar
            // 
            this.bnModificar.Location = new System.Drawing.Point(314, 218);
            this.bnModificar.Name = "bnModificar";
            this.bnModificar.Size = new System.Drawing.Size(178, 36);
            this.bnModificar.TabIndex = 15;
            this.bnModificar.Text = "Modificar";
            this.bnModificar.UseVisualStyleBackColor = true;
            this.bnModificar.Click += new System.EventHandler(this.bnModificar_Click);
            // 
            // bnEliminar
            // 
            this.bnEliminar.Location = new System.Drawing.Point(527, 218);
            this.bnEliminar.Name = "bnEliminar";
            this.bnEliminar.Size = new System.Drawing.Size(178, 36);
            this.bnEliminar.TabIndex = 16;
            this.bnEliminar.Text = "Eliminar";
            this.bnEliminar.UseVisualStyleBackColor = true;
            this.bnEliminar.Click += new System.EventHandler(this.bnEliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Datos del Dueño:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Tamaño de la mascota:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(413, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Peso de la mascota:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(413, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Fecha de Nacimiento:";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(526, 147);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaNacimiento.TabIndex = 26;
            // 
            // Mantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 518);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPeso);
            this.Controls.Add(this.tbTamanio);
            this.Controls.Add(this.tbDueno);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.dgvMantenimiento);
            this.Controls.Add(this.bnAgregar);
            this.Controls.Add(this.bnModificar);
            this.Controls.Add(this.bnEliminar);
            this.Name = "Mantenimiento";
            this.Text = "Mantenimiento";
            this.Load += new System.EventHandler(this.Mantenimiento_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMantenimiento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbPeso;
        private System.Windows.Forms.TextBox tbTamanio;
        private System.Windows.Forms.TextBox tbDueno;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.DataGridView dgvMantenimiento;
        private System.Windows.Forms.Button bnAgregar;
        private System.Windows.Forms.Button bnModificar;
        private System.Windows.Forms.Button bnEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
    }
}