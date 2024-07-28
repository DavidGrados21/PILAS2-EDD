namespace PILAS.EJERCICIO_P2
{
    partial class P2
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
            this.btnabrir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFrase = new System.Windows.Forms.TextBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.lstTexto = new System.Windows.Forms.ListBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnabrir
            // 
            this.btnabrir.Location = new System.Drawing.Point(10, 26);
            this.btnabrir.Name = "btnabrir";
            this.btnabrir.Size = new System.Drawing.Size(103, 28);
            this.btnabrir.TabIndex = 11;
            this.btnabrir.Text = "Abrir";
            this.btnabrir.UseVisualStyleBackColor = true;
            this.btnabrir.Click += new System.EventHandler(this.btnabrir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(123, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ingresa la frase";
            // 
            // txtFrase
            // 
            this.txtFrase.Location = new System.Drawing.Point(127, 31);
            this.txtFrase.Name = "txtFrase";
            this.txtFrase.Size = new System.Drawing.Size(361, 20);
            this.txtFrase.TabIndex = 9;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(494, 26);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(103, 28);
            this.btnInsertar.TabIndex = 8;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // lstTexto
            // 
            this.lstTexto.BackColor = System.Drawing.Color.MediumPurple;
            this.lstTexto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lstTexto.FormattingEnabled = true;
            this.lstTexto.Location = new System.Drawing.Point(10, 62);
            this.lstTexto.Name = "lstTexto";
            this.lstTexto.Size = new System.Drawing.Size(696, 212);
            this.lstTexto.TabIndex = 7;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(603, 26);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(103, 28);
            this.btnGenerar.TabIndex = 6;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // P2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlueViolet;
            this.ClientSize = new System.Drawing.Size(717, 279);
            this.Controls.Add(this.btnabrir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFrase);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.lstTexto);
            this.Controls.Add(this.btnGenerar);
            this.Name = "P2";
            this.Text = "P2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnabrir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFrase;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.ListBox lstTexto;
        private System.Windows.Forms.Button btnGenerar;
    }
}