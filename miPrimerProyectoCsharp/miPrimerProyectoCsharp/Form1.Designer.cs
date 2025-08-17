namespace miPrimerProyectoCsharp
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSueldo = new System.Windows.Forms.Label();
            this.lblIsss = new System.Windows.Forms.Label();
            this.lblAfp = new System.Windows.Forms.Label();
            this.lblIsr = new System.Windows.Forms.Label();
            this.lblTotalDeducciones = new System.Windows.Forms.Label();
            this.lblSueldoNeto = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSueldo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblSueldo.Location = new System.Drawing.Point(100, 44);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(104, 24);
            this.lblSueldo.TabIndex = 0;
            this.lblSueldo.Text = "SUELDO: ";
            // 
            // lblIsss
            // 
            this.lblIsss.AutoSize = true;
            this.lblIsss.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsss.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblIsss.Location = new System.Drawing.Point(23, 79);
            this.lblIsss.Name = "lblIsss";
            this.lblIsss.Size = new System.Drawing.Size(66, 24);
            this.lblIsss.TabIndex = 1;
            this.lblIsss.Text = "ISSS: ";
            // 
            // lblAfp
            // 
            this.lblAfp.AutoSize = true;
            this.lblAfp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAfp.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblAfp.Location = new System.Drawing.Point(157, 79);
            this.lblAfp.Name = "lblAfp";
            this.lblAfp.Size = new System.Drawing.Size(62, 24);
            this.lblAfp.TabIndex = 2;
            this.lblAfp.Text = "AFP: ";
            // 
            // lblIsr
            // 
            this.lblIsr.AutoSize = true;
            this.lblIsr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsr.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblIsr.Location = new System.Drawing.Point(288, 79);
            this.lblIsr.Name = "lblIsr";
            this.lblIsr.Size = new System.Drawing.Size(54, 24);
            this.lblIsr.TabIndex = 3;
            this.lblIsr.Text = "ISR: ";
            // 
            // lblTotalDeducciones
            // 
            this.lblTotalDeducciones.AutoSize = true;
            this.lblTotalDeducciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDeducciones.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTotalDeducciones.Location = new System.Drawing.Point(23, 135);
            this.lblTotalDeducciones.Name = "lblTotalDeducciones";
            this.lblTotalDeducciones.Size = new System.Drawing.Size(197, 24);
            this.lblTotalDeducciones.TabIndex = 4;
            this.lblTotalDeducciones.Text = "Total Deducciones: ";
            // 
            // lblSueldoNeto
            // 
            this.lblSueldoNeto.AutoSize = true;
            this.lblSueldoNeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSueldoNeto.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblSueldoNeto.Location = new System.Drawing.Point(23, 188);
            this.lblSueldoNeto.Name = "lblSueldoNeto";
            this.lblSueldoNeto.Size = new System.Drawing.Size(138, 24);
            this.lblSueldoNeto.TabIndex = 5;
            this.lblSueldoNeto.Text = "Sueldo Neto: ";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCalcular.Location = new System.Drawing.Point(172, 224);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(117, 36);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(210, 48);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(105, 20);
            this.txtSueldo.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 307);
            this.Controls.Add(this.txtSueldo);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblSueldoNeto);
            this.Controls.Add(this.lblTotalDeducciones);
            this.Controls.Add(this.lblIsr);
            this.Controls.Add(this.lblAfp);
            this.Controls.Add(this.lblIsss);
            this.Controls.Add(this.lblSueldo);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.Label lblIsss;
        private System.Windows.Forms.Label lblAfp;
        private System.Windows.Forms.Label lblIsr;
        private System.Windows.Forms.Label lblTotalDeducciones;
        private System.Windows.Forms.Label lblSueldoNeto;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtSueldo;
    }
}

