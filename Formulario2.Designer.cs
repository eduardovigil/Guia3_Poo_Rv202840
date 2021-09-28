namespace Guia_3_POO_RV202840
{
    partial class Formulario2
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
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.BtnRellenar = new System.Windows.Forms.Button();
            this.dgvRecibir = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecibir)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Location = new System.Drawing.Point(208, 230);
            this.txtbusqueda.Margin = new System.Windows.Forms.Padding(2);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(202, 20);
            this.txtbusqueda.TabIndex = 5;
            // 
            // BtnRellenar
            // 
            this.BtnRellenar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnRellenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRellenar.Location = new System.Drawing.Point(57, 268);
            this.BtnRellenar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnRellenar.Name = "BtnRellenar";
            this.BtnRellenar.Size = new System.Drawing.Size(84, 54);
            this.BtnRellenar.TabIndex = 4;
            this.BtnRellenar.Text = "Rellenar";
            this.BtnRellenar.UseVisualStyleBackColor = false;
            this.BtnRellenar.Click += new System.EventHandler(this.BtnRellenar_Click);
            // 
            // dgvRecibir
            // 
            this.dgvRecibir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecibir.Location = new System.Drawing.Point(57, 11);
            this.dgvRecibir.Margin = new System.Windows.Forms.Padding(2);
            this.dgvRecibir.Name = "dgvRecibir";
            this.dgvRecibir.RowHeadersWidth = 51;
            this.dgvRecibir.RowTemplate.Height = 24;
            this.dgvRecibir.Size = new System.Drawing.Size(536, 190);
            this.dgvRecibir.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(509, 268);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 54);
            this.button1.TabIndex = 6;
            this.button1.Text = "Menu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Formulario2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 333);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtbusqueda);
            this.Controls.Add(this.BtnRellenar);
            this.Controls.Add(this.dgvRecibir);
            this.Name = "Formulario2";
            this.Text = "Formulario2";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecibir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.Button BtnRellenar;
        private System.Windows.Forms.DataGridView dgvRecibir;
        private System.Windows.Forms.Button button1;
    }
}