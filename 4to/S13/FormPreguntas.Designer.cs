namespace Administrador_de_Encuestas
{
    partial class FormPreguntas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BRegresar = new System.Windows.Forms.Button();
            this.DgvPreguntas = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPreguntas)).BeginInit();
            this.SuspendLayout();
            // 
            // LTitle
            // 
            this.LTitle.AutoSize = true;
            this.LTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitle.ForeColor = System.Drawing.Color.Gold;
            this.LTitle.Location = new System.Drawing.Point(190, 47);
            this.LTitle.Name = "LTitle";
            this.LTitle.Size = new System.Drawing.Size(353, 29);
            this.LTitle.TabIndex = 0;
            this.LTitle.Text = "Administrador de Encuenstas";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.LTitle);
            this.panel1.Location = new System.Drawing.Point(-4, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 118);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(-3, 623);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(756, 75);
            this.panel2.TabIndex = 13;
            // 
            // BRegresar
            // 
            this.BRegresar.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown;
            this.BRegresar.BackColor = System.Drawing.Color.Gold;
            this.BRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BRegresar.Location = new System.Drawing.Point(561, 635);
            this.BRegresar.Name = "BRegresar";
            this.BRegresar.Size = new System.Drawing.Size(157, 40);
            this.BRegresar.TabIndex = 5;
            this.BRegresar.Text = "Nueva Pregunta";
            this.BRegresar.UseVisualStyleBackColor = false;
            this.BRegresar.Click += new System.EventHandler(this.BRegresar_Click);
            // 
            // DgvPreguntas
            // 
            this.DgvPreguntas.AllowUserToAddRows = false;
            this.DgvPreguntas.AllowUserToDeleteRows = false;
            this.DgvPreguntas.AllowUserToOrderColumns = true;
            this.DgvPreguntas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvPreguntas.BackgroundColor = System.Drawing.Color.White;
            this.DgvPreguntas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPreguntas.Location = new System.Drawing.Point(0, 114);
            this.DgvPreguntas.Name = "DgvPreguntas";
            this.DgvPreguntas.ReadOnly = true;
            this.DgvPreguntas.RowHeadersWidth = 51;
            this.DgvPreguntas.RowTemplate.Height = 24;
            this.DgvPreguntas.Size = new System.Drawing.Size(733, 515);
            this.DgvPreguntas.TabIndex = 14;
            // 
            // FormPreguntas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 686);
            this.Controls.Add(this.DgvPreguntas);
            this.Controls.Add(this.BRegresar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FormPreguntas";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPreguntas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BRegresar;
        private System.Windows.Forms.DataGridView DgvPreguntas;
    }
}