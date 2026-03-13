namespace HolaMundo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Contraseña = new System.Windows.Forms.TextBox();
            this.Confirmar = new System.Windows.Forms.TextBox();
            this.Validar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Contraseña
            // 
            this.Contraseña.BackColor = System.Drawing.Color.LavenderBlush;
            this.Contraseña.Location = new System.Drawing.Point(231, 31);
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.Size = new System.Drawing.Size(173, 20);
            this.Contraseña.TabIndex = 0;
            this.Contraseña.TextChanged += new System.EventHandler(this.Contraseña_TextChanged);
            // 
            // Confirmar
            // 
            this.Confirmar.BackColor = System.Drawing.Color.LavenderBlush;
            this.Confirmar.Location = new System.Drawing.Point(231, 94);
            this.Confirmar.Name = "Confirmar";
            this.Confirmar.Size = new System.Drawing.Size(173, 20);
            this.Confirmar.TabIndex = 1;
            this.Confirmar.TextChanged += new System.EventHandler(this.Confirmar_TextChanged);
            // 
            // Validar
            // 
            this.Validar.Location = new System.Drawing.Point(231, 163);
            this.Validar.Name = "Validar";
            this.Validar.Size = new System.Drawing.Size(173, 47);
            this.Validar.TabIndex = 2;
            this.Validar.Text = "Validar";
            this.Validar.UseVisualStyleBackColor = true;
            this.Validar.Click += new System.EventHandler(this.Validar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(30, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 179);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(451, 241);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Validar);
            this.Controls.Add(this.Confirmar);
            this.Controls.Add(this.Contraseña);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Contraseña;
        private System.Windows.Forms.TextBox Confirmar;
        private System.Windows.Forms.Button Validar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

