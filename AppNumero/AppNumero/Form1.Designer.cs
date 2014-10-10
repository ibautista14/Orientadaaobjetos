namespace AppNumero
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNumeroMenor = new System.Windows.Forms.Label();
            this.lblNumeroMayor = new System.Windows.Forms.Label();
            this.txtNumeroMenor = new System.Windows.Forms.TextBox();
            this.txtNumeroMayor = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.rbtMostrarRango = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblNumeroMenor
            // 
            this.lblNumeroMenor.AutoSize = true;
            this.lblNumeroMenor.Location = new System.Drawing.Point(76, 34);
            this.lblNumeroMenor.Name = "lblNumeroMenor";
            this.lblNumeroMenor.Size = new System.Drawing.Size(83, 13);
            this.lblNumeroMenor.TabIndex = 0;
            this.lblNumeroMenor.Text = "Numero Menor :";
            // 
            // lblNumeroMayor
            // 
            this.lblNumeroMayor.AutoSize = true;
            this.lblNumeroMayor.Location = new System.Drawing.Point(76, 111);
            this.lblNumeroMayor.Name = "lblNumeroMayor";
            this.lblNumeroMayor.Size = new System.Drawing.Size(82, 13);
            this.lblNumeroMayor.TabIndex = 1;
            this.lblNumeroMayor.Text = "Numero Mayor :";
            // 
            // txtNumeroMenor
            // 
            this.txtNumeroMenor.Location = new System.Drawing.Point(180, 34);
            this.txtNumeroMenor.Name = "txtNumeroMenor";
            this.txtNumeroMenor.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroMenor.TabIndex = 2;
            // 
            // txtNumeroMayor
            // 
            this.txtNumeroMayor.Location = new System.Drawing.Point(180, 108);
            this.txtNumeroMayor.Name = "txtNumeroMayor";
            this.txtNumeroMayor.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroMayor.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(180, 277);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // rbtMostrarRango
            // 
            this.rbtMostrarRango.Location = new System.Drawing.Point(94, 154);
            this.rbtMostrarRango.Name = "rbtMostrarRango";
            this.rbtMostrarRango.Size = new System.Drawing.Size(227, 96);
            this.rbtMostrarRango.TabIndex = 5;
            this.rbtMostrarRango.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 375);
            this.Controls.Add(this.rbtMostrarRango);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtNumeroMayor);
            this.Controls.Add(this.txtNumeroMenor);
            this.Controls.Add(this.lblNumeroMayor);
            this.Controls.Add(this.lblNumeroMenor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumeroMenor;
        private System.Windows.Forms.Label lblNumeroMayor;
        private System.Windows.Forms.TextBox txtNumeroMenor;
        private System.Windows.Forms.TextBox txtNumeroMayor;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.RichTextBox rbtMostrarRango;
    }
}

