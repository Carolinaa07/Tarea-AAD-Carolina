namespace Presentacion
{
    partial class Mascotas
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
            this.dgvlistarmascotas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistarmascotas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvlistarmascotas
            // 
            this.dgvlistarmascotas.AllowUserToAddRows = false;
            this.dgvlistarmascotas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvlistarmascotas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvlistarmascotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlistarmascotas.Location = new System.Drawing.Point(21, 12);
            this.dgvlistarmascotas.Name = "dgvlistarmascotas";
            this.dgvlistarmascotas.RowHeadersVisible = false;
            this.dgvlistarmascotas.Size = new System.Drawing.Size(514, 325);
            this.dgvlistarmascotas.TabIndex = 2;
            // 
            // Mascotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 361);
            this.Controls.Add(this.dgvlistarmascotas);
            this.Name = "Mascotas";
            this.Text = "Mascotas";
            this.Load += new System.EventHandler(this.Mascotas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistarmascotas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvlistarmascotas;
    }
}