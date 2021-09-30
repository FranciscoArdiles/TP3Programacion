
namespace TP3Programacion
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
            this.lblPrimerN = new System.Windows.Forms.Label();
            this.lblSegundoN = new System.Windows.Forms.Label();
            this.lblTercerN = new System.Windows.Forms.Label();
            this.lblCalculadora = new System.Windows.Forms.Label();
            this.btCalcular = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.numPriN = new System.Windows.Forms.NumericUpDown();
            this.numSegN = new System.Windows.Forms.NumericUpDown();
            this.numTerN = new System.Windows.Forms.NumericUpDown();
            this.lblerror = new System.Windows.Forms.Label();
            this.lblPunto = new System.Windows.Forms.Label();
            this.lblCargando = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numPriN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSegN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTerN)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrimerN
            // 
            this.lblPrimerN.AutoSize = true;
            this.lblPrimerN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimerN.Location = new System.Drawing.Point(39, 74);
            this.lblPrimerN.Name = "lblPrimerN";
            this.lblPrimerN.Size = new System.Drawing.Size(172, 20);
            this.lblPrimerN.TabIndex = 0;
            this.lblPrimerN.Text = "Ingrese Primer Numero";
            // 
            // lblSegundoN
            // 
            this.lblSegundoN.AutoSize = true;
            this.lblSegundoN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundoN.Location = new System.Drawing.Point(241, 74);
            this.lblSegundoN.Name = "lblSegundoN";
            this.lblSegundoN.Size = new System.Drawing.Size(192, 20);
            this.lblSegundoN.TabIndex = 1;
            this.lblSegundoN.Text = "Ingrese Segundo Numero";
            // 
            // lblTercerN
            // 
            this.lblTercerN.AutoSize = true;
            this.lblTercerN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTercerN.Location = new System.Drawing.Point(446, 74);
            this.lblTercerN.Name = "lblTercerN";
            this.lblTercerN.Size = new System.Drawing.Size(172, 20);
            this.lblTercerN.TabIndex = 2;
            this.lblTercerN.Text = "Ingrese Tercer Numero";
            // 
            // lblCalculadora
            // 
            this.lblCalculadora.AutoSize = true;
            this.lblCalculadora.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblCalculadora.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalculadora.Location = new System.Drawing.Point(168, 24);
            this.lblCalculadora.Name = "lblCalculadora";
            this.lblCalculadora.Size = new System.Drawing.Size(307, 25);
            this.lblCalculadora.TabIndex = 6;
            this.lblCalculadora.Text = "CALCULADORA DE PROMEDIO";
            // 
            // btCalcular
            // 
            this.btCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalcular.Location = new System.Drawing.Point(272, 175);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(146, 26);
            this.btCalcular.TabIndex = 7;
            this.btCalcular.Text = "CALCULAR";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(37, 258);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(145, 31);
            this.lblResultado.TabIndex = 8;
            this.lblResultado.Text = "Resultado:";
            this.lblResultado.Visible = false;
            // 
            // numPriN
            // 
            this.numPriN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPriN.Location = new System.Drawing.Point(62, 118);
            this.numPriN.Name = "numPriN";
            this.numPriN.Size = new System.Drawing.Size(120, 27);
            this.numPriN.TabIndex = 9;
            // 
            // numSegN
            // 
            this.numSegN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSegN.Location = new System.Drawing.Point(281, 118);
            this.numSegN.Name = "numSegN";
            this.numSegN.Size = new System.Drawing.Size(120, 27);
            this.numSegN.TabIndex = 10;
            // 
            // numTerN
            // 
            this.numTerN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTerN.Location = new System.Drawing.Point(476, 118);
            this.numTerN.Name = "numTerN";
            this.numTerN.Size = new System.Drawing.Size(120, 27);
            this.numTerN.TabIndex = 11;
            // 
            // lblerror
            // 
            this.lblerror.AutoSize = true;
            this.lblerror.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerror.ForeColor = System.Drawing.Color.Red;
            this.lblerror.Location = new System.Drawing.Point(221, 289);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(254, 25);
            this.lblerror.TabIndex = 12;
            this.lblerror.Text = "Ingrese al menos 1 numero!";
            this.lblerror.Visible = false;
            // 
            // lblPunto
            // 
            this.lblPunto.AutoSize = true;
            this.lblPunto.BackColor = System.Drawing.Color.Lime;
            this.lblPunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPunto.Location = new System.Drawing.Point(40, 225);
            this.lblPunto.Name = "lblPunto";
            this.lblPunto.Size = new System.Drawing.Size(25, 22);
            this.lblPunto.TabIndex = 13;
            this.lblPunto.Text = "   ";
            this.lblPunto.Visible = false;
            // 
            // lblCargando
            // 
            this.lblCargando.AutoSize = true;
            this.lblCargando.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargando.ForeColor = System.Drawing.Color.Red;
            this.lblCargando.Location = new System.Drawing.Point(276, 258);
            this.lblCargando.Name = "lblCargando";
            this.lblCargando.Size = new System.Drawing.Size(142, 25);
            this.lblCargando.TabIndex = 14;
            this.lblCargando.Text = "CARGANDO...";
            this.lblCargando.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCargando);
            this.Controls.Add(this.lblPunto);
            this.Controls.Add(this.lblerror);
            this.Controls.Add(this.numTerN);
            this.Controls.Add(this.numSegN);
            this.Controls.Add(this.numPriN);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.lblCalculadora);
            this.Controls.Add(this.lblTercerN);
            this.Controls.Add(this.lblSegundoN);
            this.Controls.Add(this.lblPrimerN);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numPriN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSegN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTerN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrimerN;
        private System.Windows.Forms.Label lblSegundoN;
        private System.Windows.Forms.Label lblTercerN;
        private System.Windows.Forms.Label lblCalculadora;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.NumericUpDown numPriN;
        private System.Windows.Forms.NumericUpDown numSegN;
        private System.Windows.Forms.NumericUpDown numTerN;
        private System.Windows.Forms.Label lblerror;
        private System.Windows.Forms.Label lblPunto;
        private System.Windows.Forms.Label lblCargando;
    }
}

