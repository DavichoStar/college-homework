namespace Administrador_de_Encuestas
{
    partial class FormBuscar
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
            this.BBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TbId = new System.Windows.Forms.TextBox();
            this.LId = new System.Windows.Forms.Label();
            this.LFecha = new System.Windows.Forms.Label();
            this.LPregunta = new System.Windows.Forms.Label();
            this.TbPregunta = new System.Windows.Forms.TextBox();
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPreguntas)).BeginInit();
            this.SuspendLayout();
            // 
            // LTitle
            // 
            this.LTitle.AutoSize = true;
            this.LTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitle.ForeColor = System.Drawing.Color.Gold;
            this.LTitle.Location = new System.Drawing.Point(196, 46);
            this.LTitle.Name = "LTitle";
            this.LTitle.Size = new System.Drawing.Size(285, 29);
            this.LTitle.TabIndex = 0;
            this.LTitle.Text = "Buscador de Preguntas";
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
            this.panel2.Controls.Add(this.BRegresar);
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
            this.BRegresar.Location = new System.Drawing.Point(514, 11);
            this.BRegresar.Name = "BRegresar";
            this.BRegresar.Size = new System.Drawing.Size(157, 40);
            this.BRegresar.TabIndex = 5;
            this.BRegresar.Text = "Regresar";
            this.BRegresar.UseVisualStyleBackColor = false;
            this.BRegresar.Click += new System.EventHandler(this.BRegresar_Click);
            // 
            // DgvPreguntas
            // 
            this.DgvPreguntas.AllowUserToAddRows = false;
            this.DgvPreguntas.AllowUserToDeleteRows = false;
            this.DgvPreguntas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvPreguntas.BackgroundColor = System.Drawing.Color.White;
            this.DgvPreguntas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPreguntas.Location = new System.Drawing.Point(62, 217);
            this.DgvPreguntas.Name = "DgvPreguntas";
            this.DgvPreguntas.ReadOnly = true;
            this.DgvPreguntas.RowHeadersWidth = 51;
            this.DgvPreguntas.RowTemplate.Height = 24;
            this.DgvPreguntas.Size = new System.Drawing.Size(547, 369);
            this.DgvPreguntas.TabIndex = 14;
            // 
            // BBuscar
            // 
            this.BBuscar.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown;
            this.BBuscar.BackColor = System.Drawing.Color.Gold;
            this.BBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBuscar.Location = new System.Drawing.Point(452, 157);
            this.BBuscar.Name = "BBuscar";
            this.BBuscar.Size = new System.Drawing.Size(157, 40);
            this.BBuscar.TabIndex = 15;
            this.BBuscar.Text = "Buscar";
            this.BBuscar.UseVisualStyleBackColor = false;
            this.BBuscar.Click += new System.EventHandler(this.BBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Buscar Pregunta por:";
            // 
            // TbId
            // 
            this.TbId.Location = new System.Drawing.Point(89, 157);
            this.TbId.Name = "TbId";
            this.TbId.Size = new System.Drawing.Size(93, 22);
            this.TbId.TabIndex = 17;
            // 
            // LId
            // 
            this.LId.AutoSize = true;
            this.LId.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LId.Location = new System.Drawing.Point(59, 159);
            this.LId.Name = "LId";
            this.LId.Size = new System.Drawing.Size(26, 17);
            this.LId.TabIndex = 18;
            this.LId.Text = "Id:";
            // 
            // LFecha
            // 
            this.LFecha.AutoSize = true;
            this.LFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFecha.Location = new System.Drawing.Point(207, 159);
            this.LFecha.Name = "LFecha";
            this.LFecha.Size = new System.Drawing.Size(57, 17);
            this.LFecha.TabIndex = 19;
            this.LFecha.Text = "Fecha:";
            // 
            // LPregunta
            // 
            this.LPregunta.AutoSize = true;
            this.LPregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPregunta.Location = new System.Drawing.Point(59, 188);
            this.LPregunta.Name = "LPregunta";
            this.LPregunta.Size = new System.Drawing.Size(132, 17);
            this.LPregunta.TabIndex = 20;
            this.LPregunta.Text = "Pregunta Exacta:";
            // 
            // TbPregunta
            // 
            this.TbPregunta.Location = new System.Drawing.Point(197, 185);
            this.TbPregunta.Name = "TbPregunta";
            this.TbPregunta.Size = new System.Drawing.Size(208, 22);
            this.TbPregunta.TabIndex = 21;
            // 
            // DtpFecha
            // 
            this.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFecha.Location = new System.Drawing.Point(286, 159);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(119, 22);
            this.DtpFecha.TabIndex = 22;
            this.DtpFecha.ValueChanged += new System.EventHandler(this.DtpFecha_ValueChanged);
            // 
            // FormBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 686);
            this.Controls.Add(this.DtpFecha);
            this.Controls.Add(this.TbPregunta);
            this.Controls.Add(this.LPregunta);
            this.Controls.Add(this.LFecha);
            this.Controls.Add(this.LId);
            this.Controls.Add(this.TbId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BBuscar);
            this.Controls.Add(this.DgvPreguntas);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FormBuscar";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvPreguntas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BRegresar;
        private System.Windows.Forms.DataGridView DgvPreguntas;
        private System.Windows.Forms.Button BBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbId;
        private System.Windows.Forms.Label LId;
        private System.Windows.Forms.Label LFecha;
        private System.Windows.Forms.Label LPregunta;
        private System.Windows.Forms.TextBox TbPregunta;
        private System.Windows.Forms.DateTimePicker DtpFecha;
    }
}