namespace Tarea1
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
            this.LId = new System.Windows.Forms.Label();
            this.TbID = new System.Windows.Forms.TextBox();
            this.TbNombre = new System.Windows.Forms.TextBox();
            this.TbParcial1 = new System.Windows.Forms.TextBox();
            this.TbParcial2 = new System.Windows.Forms.TextBox();
            this.TbParcial3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LResultado = new System.Windows.Forms.Label();
            this.BCalcular = new System.Windows.Forms.Button();
            this.BClear = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LId
            // 
            this.LId.AutoSize = true;
            this.LId.Location = new System.Drawing.Point(115, 111);
            this.LId.Name = "LId";
            this.LId.Size = new System.Drawing.Size(25, 17);
            this.LId.TabIndex = 0;
            this.LId.Text = "ID:";
            // 
            // TbID
            // 
            this.TbID.Location = new System.Drawing.Point(147, 111);
            this.TbID.MaxLength = 8;
            this.TbID.Name = "TbID";
            this.TbID.Size = new System.Drawing.Size(100, 22);
            this.TbID.TabIndex = 1;
            // 
            // TbNombre
            // 
            this.TbNombre.Location = new System.Drawing.Point(147, 151);
            this.TbNombre.MaxLength = 30;
            this.TbNombre.Name = "TbNombre";
            this.TbNombre.Size = new System.Drawing.Size(100, 22);
            this.TbNombre.TabIndex = 2;
            // 
            // TbParcial1
            // 
            this.TbParcial1.Location = new System.Drawing.Point(371, 139);
            this.TbParcial1.MaxLength = 2;
            this.TbParcial1.Name = "TbParcial1";
            this.TbParcial1.Size = new System.Drawing.Size(100, 22);
            this.TbParcial1.TabIndex = 3;
            // 
            // TbParcial2
            // 
            this.TbParcial2.Location = new System.Drawing.Point(371, 185);
            this.TbParcial2.MaxLength = 2;
            this.TbParcial2.Name = "TbParcial2";
            this.TbParcial2.Size = new System.Drawing.Size(100, 22);
            this.TbParcial2.TabIndex = 4;
            // 
            // TbParcial3
            // 
            this.TbParcial3.Location = new System.Drawing.Point(371, 230);
            this.TbParcial3.MaxLength = 2;
            this.TbParcial3.Name = "TbParcial3";
            this.TbParcial3.Size = new System.Drawing.Size(100, 22);
            this.TbParcial3.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Parcial 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Parcial 2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(289, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Parcial 3:";
            // 
            // LResultado
            // 
            this.LResultado.AutoSize = true;
            this.LResultado.Location = new System.Drawing.Point(46, 297);
            this.LResultado.Name = "LResultado";
            this.LResultado.Size = new System.Drawing.Size(0, 17);
            this.LResultado.TabIndex = 10;
            // 
            // BCalcular
            // 
            this.BCalcular.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BCalcular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BCalcular.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BCalcular.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BCalcular.Location = new System.Drawing.Point(49, 211);
            this.BCalcular.Name = "BCalcular";
            this.BCalcular.Size = new System.Drawing.Size(91, 47);
            this.BCalcular.TabIndex = 11;
            this.BCalcular.Text = "Calcular Promedio";
            this.BCalcular.UseVisualStyleBackColor = false;
            this.BCalcular.Click += new System.EventHandler(this.BCalcular_Click);
            // 
            // BClear
            // 
            this.BClear.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BClear.ForeColor = System.Drawing.SystemColors.Control;
            this.BClear.Location = new System.Drawing.Point(166, 211);
            this.BClear.Name = "BClear";
            this.BClear.Size = new System.Drawing.Size(91, 48);
            this.BClear.TabIndex = 12;
            this.BClear.Text = "Nuevo Registro";
            this.BClear.UseVisualStyleBackColor = false;
            this.BClear.Click += new System.EventHandler(this.BClear_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(23, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(464, 36);
            this.label6.TabIndex = 13;
            this.label6.Text = "Sistema de Calificaciones UNID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(325, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Calificaciones ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(520, 362);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BClear);
            this.Controls.Add(this.BCalcular);
            this.Controls.Add(this.LResultado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbParcial3);
            this.Controls.Add(this.TbParcial2);
            this.Controls.Add(this.TbParcial1);
            this.Controls.Add(this.TbNombre);
            this.Controls.Add(this.TbID);
            this.Controls.Add(this.LId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calificaciones UNID";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LId;
        private System.Windows.Forms.TextBox TbID;
        private System.Windows.Forms.TextBox TbNombre;
        private System.Windows.Forms.TextBox TbParcial1;
        private System.Windows.Forms.TextBox TbParcial2;
        private System.Windows.Forms.TextBox TbParcial3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LResultado;
        private System.Windows.Forms.Button BCalcular;
        private System.Windows.Forms.Button BClear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

