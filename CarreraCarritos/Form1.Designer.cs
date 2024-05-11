namespace CarreraCarritos
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
            this.components = new System.ComponentModel.Container();
            this.lblPrimerLugar = new System.Windows.Forms.Label();
            this.btnComenzar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.metaFinal = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPrimerLugar
            // 
            this.lblPrimerLugar.AutoSize = true;
            this.lblPrimerLugar.Location = new System.Drawing.Point(489, 9);
            this.lblPrimerLugar.Name = "lblPrimerLugar";
            this.lblPrimerLugar.Size = new System.Drawing.Size(0, 13);
            this.lblPrimerLugar.TabIndex = 1;
            // 
            // btnComenzar
            // 
            this.btnComenzar.Location = new System.Drawing.Point(423, 340);
            this.btnComenzar.Name = "btnComenzar";
            this.btnComenzar.Size = new System.Drawing.Size(156, 23);
            this.btnComenzar.TabIndex = 2;
            this.btnComenzar.Text = "Comenzar carrera";
            this.btnComenzar.UseVisualStyleBackColor = true;
            this.btnComenzar.Click += new System.EventHandler(this.btnComenzar_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            // 
            // metaFinal
            // 
            this.metaFinal.BackColor = System.Drawing.Color.Red;
            this.metaFinal.Font = new System.Drawing.Font("Microsoft YaHei", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metaFinal.Location = new System.Drawing.Point(881, -15);
            this.metaFinal.Name = "metaFinal";
            this.metaFinal.Size = new System.Drawing.Size(173, 552);
            this.metaFinal.TabIndex = 5;
            this.metaFinal.Text = "META";
            this.metaFinal.UseVisualStyleBackColor = false;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(464, 400);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 6;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Location = new System.Drawing.Point(464, 459);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(75, 23);
            this.btnReiniciar.TabIndex = 7;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 505);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.metaFinal);
            this.Controls.Add(this.btnComenzar);
            this.Controls.Add(this.lblPrimerLugar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrimerLugar;
        private System.Windows.Forms.Button btnComenzar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button metaFinal;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnReiniciar;
    }
}

