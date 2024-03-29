namespace RegistroDePersona
{
    partial class Form1
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
            this.nombre_insertar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.InsertarData = new System.Windows.Forms.Button();
            this.edad_insertar = new System.Windows.Forms.TextBox();
            this.celular_insertar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nombre_insertar
            // 
            this.nombre_insertar.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre_insertar.Location = new System.Drawing.Point(208, 117);
            this.nombre_insertar.Name = "nombre_insertar";
            this.nombre_insertar.Size = new System.Drawing.Size(479, 31);
            this.nombre_insertar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // InsertarData
            // 
            this.InsertarData.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertarData.Location = new System.Drawing.Point(208, 294);
            this.InsertarData.Name = "InsertarData";
            this.InsertarData.Size = new System.Drawing.Size(479, 40);
            this.InsertarData.TabIndex = 2;
            this.InsertarData.Text = "Enviar";
            this.InsertarData.UseVisualStyleBackColor = true;
            this.InsertarData.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // edad_insertar
            // 
            this.edad_insertar.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edad_insertar.Location = new System.Drawing.Point(208, 169);
            this.edad_insertar.Name = "edad_insertar";
            this.edad_insertar.Size = new System.Drawing.Size(479, 31);
            this.edad_insertar.TabIndex = 4;
            // 
            // celular_insertar
            // 
            this.celular_insertar.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.celular_insertar.Location = new System.Drawing.Point(208, 218);
            this.celular_insertar.Name = "celular_insertar";
            this.celular_insertar.Size = new System.Drawing.Size(479, 31);
            this.celular_insertar.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Edad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "Celular";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(477, 38);
            this.label4.TabIndex = 8;
            this.label4.Text = "Formulario registro de persona";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.celular_insertar);
            this.Controls.Add(this.edad_insertar);
            this.Controls.Add(this.InsertarData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nombre_insertar);
            this.Name = "Form1";
            this.Text = "Registro de persona";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nombre_insertar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button InsertarData;
        private System.Windows.Forms.TextBox edad_insertar;
        private System.Windows.Forms.TextBox celular_insertar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

