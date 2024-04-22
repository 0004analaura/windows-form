namespace combustible
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
            this.textdistancia = new System.Windows.Forms.TextBox();
            this.textrendimiento = new System.Windows.Forms.TextBox();
            this.textotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textdistancia
            // 
            this.textdistancia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.textdistancia.Cursor = System.Windows.Forms.Cursors.Cross;
            this.textdistancia.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textdistancia.Location = new System.Drawing.Point(249, 62);
            this.textdistancia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textdistancia.Name = "textdistancia";
            this.textdistancia.Size = new System.Drawing.Size(253, 24);
            this.textdistancia.TabIndex = 0;
            // 
            // textrendimiento
            // 
            this.textrendimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.textrendimiento.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.textrendimiento.Location = new System.Drawing.Point(249, 115);
            this.textrendimiento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textrendimiento.Name = "textrendimiento";
            this.textrendimiento.Size = new System.Drawing.Size(253, 25);
            this.textrendimiento.TabIndex = 1;
            // 
            // textotal
            // 
            this.textotal.Location = new System.Drawing.Point(258, 294);
            this.textotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textotal.Name = "textotal";
            this.textotal.Size = new System.Drawing.Size(253, 25);
            this.textotal.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, -1);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(573, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "Consumo de Combustible";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonCalcular.Location = new System.Drawing.Point(297, 180);
            this.buttonCalcular.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(168, 75);
            this.buttonCalcular.TabIndex = 4;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = false;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 534);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textotal);
            this.Controls.Add(this.textrendimiento);
            this.Controls.Add(this.textdistancia);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Consumo combustible";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textdistancia;
        private System.Windows.Forms.TextBox textrendimiento;
        private System.Windows.Forms.TextBox textotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCalcular;
    }
}

