namespace Calculadora_de_viajes
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
            this.textorigen = new System.Windows.Forms.TextBox();
            this.textdestino = new System.Windows.Forms.TextBox();
            this.textvelocidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textorigen
            // 
            this.textorigen.Location = new System.Drawing.Point(254, 80);
            this.textorigen.Name = "textorigen";
            this.textorigen.Size = new System.Drawing.Size(251, 22);
            this.textorigen.TabIndex = 0;
            // 
            // textdestino
            // 
            this.textdestino.Location = new System.Drawing.Point(254, 134);
            this.textdestino.Name = "textdestino";
            this.textdestino.Size = new System.Drawing.Size(251, 22);
            this.textdestino.TabIndex = 1;
            // 
            // textvelocidad
            // 
            this.textvelocidad.Location = new System.Drawing.Point(254, 195);
            this.textvelocidad.Name = "textvelocidad";
            this.textvelocidad.Size = new System.Drawing.Size(251, 22);
            this.textvelocidad.TabIndex = 2;
            this.textvelocidad.TextChanged += new System.EventHandler(this.textvelocidad_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "Calculadora de Viajes";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(254, 320);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(251, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // calcular
            // 
            this.calcular.Location = new System.Drawing.Point(310, 236);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(140, 60);
            this.calcular.TabIndex = 5;
            this.calcular.Text = "Calcular";
            this.calcular.UseVisualStyleBackColor = true;
            this.calcular.Click += new System.EventHandler(this.calcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.calcular);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textvelocidad);
            this.Controls.Add(this.textdestino);
            this.Controls.Add(this.textorigen);
            this.Name = "Form1";
            this.Text = "Calculadora de Viajes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textorigen;
        private System.Windows.Forms.TextBox textdestino;
        private System.Windows.Forms.TextBox textvelocidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button calcular;
    }
}

