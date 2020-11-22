
namespace WinAppJuego
{
    partial class FormJuego
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormJuego));
            this.buttonJugar = new System.Windows.Forms.Button();
            this.labelNumero1 = new System.Windows.Forms.Label();
            this.labelNumero2 = new System.Windows.Forms.Label();
            this.labelNumero3 = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.pictureBoxGanador = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGanador)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonJugar
            // 
            this.buttonJugar.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonJugar.Location = new System.Drawing.Point(321, 354);
            this.buttonJugar.Name = "buttonJugar";
            this.buttonJugar.Size = new System.Drawing.Size(195, 70);
            this.buttonJugar.TabIndex = 0;
            this.buttonJugar.Text = "JUGAR";
            this.buttonJugar.UseVisualStyleBackColor = true;
            this.buttonJugar.Click += new System.EventHandler(this.buttonJugar_Click);
            // 
            // labelNumero1
            // 
            this.labelNumero1.AutoSize = true;
            this.labelNumero1.Font = new System.Drawing.Font("Consolas", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumero1.Location = new System.Drawing.Point(68, 148);
            this.labelNumero1.Name = "labelNumero1";
            this.labelNumero1.Size = new System.Drawing.Size(126, 140);
            this.labelNumero1.TabIndex = 1;
            this.labelNumero1.Text = "#";
            // 
            // labelNumero2
            // 
            this.labelNumero2.AutoSize = true;
            this.labelNumero2.Font = new System.Drawing.Font("Consolas", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumero2.Location = new System.Drawing.Point(362, 148);
            this.labelNumero2.Name = "labelNumero2";
            this.labelNumero2.Size = new System.Drawing.Size(126, 140);
            this.labelNumero2.TabIndex = 2;
            this.labelNumero2.Text = "#";
            // 
            // labelNumero3
            // 
            this.labelNumero3.AutoSize = true;
            this.labelNumero3.Font = new System.Drawing.Font("Consolas", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumero3.Location = new System.Drawing.Point(656, 148);
            this.labelNumero3.Name = "labelNumero3";
            this.labelNumero3.Size = new System.Drawing.Size(126, 140);
            this.labelNumero3.TabIndex = 3;
            this.labelNumero3.Text = "#";
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(12, 20);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(790, 47);
            this.labelTitulo.TabIndex = 7;
            this.labelTitulo.Text = "Consiga tres números iguales y gane";
            // 
            // pictureBoxGanador
            // 
            this.pictureBoxGanador.Image = global::WinAppJuego.Properties.Resources.ganador;
            this.pictureBoxGanador.Location = new System.Drawing.Point(81, 120);
            this.pictureBoxGanador.Name = "pictureBoxGanador";
            this.pictureBoxGanador.Size = new System.Drawing.Size(690, 304);
            this.pictureBoxGanador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGanador.TabIndex = 8;
            this.pictureBoxGanador.TabStop = false;
            // 
            // FormJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 450);
            this.Controls.Add(this.pictureBoxGanador);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.labelNumero3);
            this.Controls.Add(this.labelNumero2);
            this.Controls.Add(this.labelNumero1);
            this.Controls.Add(this.buttonJugar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormJuego";
            this.Text = "Juego";
            this.Load += new System.EventHandler(this.FormJuego_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGanador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonJugar;
        private System.Windows.Forms.Label labelNumero1;
        private System.Windows.Forms.Label labelNumero2;
        private System.Windows.Forms.Label labelNumero3;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.PictureBox pictureBoxGanador;
    }
}

