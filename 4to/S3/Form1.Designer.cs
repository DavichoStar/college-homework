namespace WindowsForms1
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
            this.BEnviar = new System.Windows.Forms.Button();
            this.TbNombre = new System.Windows.Forms.TextBox();
            this.TbApellido = new System.Windows.Forms.TextBox();
            this.LTitulo = new System.Windows.Forms.Label();
            this.LNombre = new System.Windows.Forms.Label();
            this.LApellidos = new System.Windows.Forms.Label();
            this.LEdad = new System.Windows.Forms.Label();
            this.TbEdad = new System.Windows.Forms.TextBox();
            this.LTelefono = new System.Windows.Forms.Label();
            this.TbTelefono = new System.Windows.Forms.TextBox();
            this.LPin = new System.Windows.Forms.Label();
            this.TbPin = new System.Windows.Forms.TextBox();
            this.LTextInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BEnviar
            // 
            this.BEnviar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BEnviar.Location = new System.Drawing.Point(116, 345);
            this.BEnviar.Name = "BEnviar";
            this.BEnviar.Size = new System.Drawing.Size(75, 23);
            this.BEnviar.TabIndex = 0;
            this.BEnviar.Text = "Enviar";
            this.BEnviar.UseVisualStyleBackColor = false;
            this.BEnviar.Click += new System.EventHandler(this.BEnviar_Click);
            // 
            // TbNombre
            // 
            this.TbNombre.Location = new System.Drawing.Point(134, 96);
            this.TbNombre.Name = "TbNombre";
            this.TbNombre.Size = new System.Drawing.Size(137, 22);
            this.TbNombre.TabIndex = 1;
            // 
            // TbApellido
            // 
            this.TbApellido.Location = new System.Drawing.Point(134, 133);
            this.TbApellido.Name = "TbApellido";
            this.TbApellido.Size = new System.Drawing.Size(137, 22);
            this.TbApellido.TabIndex = 2;
            // 
            // LTitulo
            // 
            this.LTitulo.AutoSize = true;
            this.LTitulo.Location = new System.Drawing.Point(93, 30);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(120, 17);
            this.LTitulo.TabIndex = 3;
            this.LTitulo.Text = "App Básica en C#";
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Location = new System.Drawing.Point(12, 99);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(62, 17);
            this.LNombre.TabIndex = 4;
            this.LNombre.Text = "Nombre:";
            // 
            // LApellidos
            // 
            this.LApellidos.AutoSize = true;
            this.LApellidos.Location = new System.Drawing.Point(12, 136);
            this.LApellidos.Name = "LApellidos";
            this.LApellidos.Size = new System.Drawing.Size(69, 17);
            this.LApellidos.TabIndex = 5;
            this.LApellidos.Text = "Apellidos:";
            // 
            // LEdad
            // 
            this.LEdad.AutoSize = true;
            this.LEdad.Location = new System.Drawing.Point(10, 177);
            this.LEdad.Name = "LEdad";
            this.LEdad.Size = new System.Drawing.Size(45, 17);
            this.LEdad.TabIndex = 9;
            this.LEdad.Text = "Edad:";
            // 
            // TbEdad
            // 
            this.TbEdad.Location = new System.Drawing.Point(134, 174);
            this.TbEdad.Name = "TbEdad";
            this.TbEdad.Size = new System.Drawing.Size(137, 22);
            this.TbEdad.TabIndex = 8;
            // 
            // LTelefono
            // 
            this.LTelefono.AutoSize = true;
            this.LTelefono.Location = new System.Drawing.Point(10, 213);
            this.LTelefono.Name = "LTelefono";
            this.LTelefono.Size = new System.Drawing.Size(68, 17);
            this.LTelefono.TabIndex = 11;
            this.LTelefono.Text = "Teléfono:";
            // 
            // TbTelefono
            // 
            this.TbTelefono.Location = new System.Drawing.Point(134, 210);
            this.TbTelefono.Name = "TbTelefono";
            this.TbTelefono.Size = new System.Drawing.Size(137, 22);
            this.TbTelefono.TabIndex = 10;
            // 
            // LPin
            // 
            this.LPin.AutoSize = true;
            this.LPin.Location = new System.Drawing.Point(10, 251);
            this.LPin.Name = "LPin";
            this.LPin.Size = new System.Drawing.Size(34, 17);
            this.LPin.TabIndex = 13;
            this.LPin.Text = "PIN:";
            // 
            // TbPin
            // 
            this.TbPin.Location = new System.Drawing.Point(134, 248);
            this.TbPin.Name = "TbPin";
            this.TbPin.Size = new System.Drawing.Size(137, 22);
            this.TbPin.TabIndex = 12;
            // 
            // LTextInfo
            // 
            this.LTextInfo.AutoSize = true;
            this.LTextInfo.Location = new System.Drawing.Point(44, 300);
            this.LTextInfo.Name = "LTextInfo";
            this.LTextInfo.Size = new System.Drawing.Size(0, 17);
            this.LTextInfo.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(318, 416);
            this.Controls.Add(this.LTextInfo);
            this.Controls.Add(this.LPin);
            this.Controls.Add(this.TbPin);
            this.Controls.Add(this.LTelefono);
            this.Controls.Add(this.TbTelefono);
            this.Controls.Add(this.LEdad);
            this.Controls.Add(this.TbEdad);
            this.Controls.Add(this.LApellidos);
            this.Controls.Add(this.LNombre);
            this.Controls.Add(this.LTitulo);
            this.Controls.Add(this.TbApellido);
            this.Controls.Add(this.TbNombre);
            this.Controls.Add(this.BEnviar);
            this.Name = "Form1";
            this.Text = "Actividad1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BEnviar;
        private System.Windows.Forms.TextBox TbNombre;
        private System.Windows.Forms.TextBox TbApellido;
        private System.Windows.Forms.Label LTitulo;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.Label LApellidos;
        private System.Windows.Forms.Label LEdad;
        private System.Windows.Forms.TextBox TbEdad;
        private System.Windows.Forms.Label LTelefono;
        private System.Windows.Forms.TextBox TbTelefono;
        private System.Windows.Forms.Label LPin;
        private System.Windows.Forms.TextBox TbPin;
        private System.Windows.Forms.Label LTextInfo;
    }
}

