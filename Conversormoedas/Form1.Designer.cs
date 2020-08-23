namespace Conversormoedas
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbvalor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_realdolar = new System.Windows.Forms.Button();
            this.dolarparareal = new System.Windows.Forms.Button();
            this.Btn_realparaeuro = new System.Windows.Forms.Button();
            this.Btn_euroreal = new System.Windows.Forms.Button();
            this.btneuroparadolar = new System.Windows.Forms.Button();
            this.btndolarparaeuro = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite um valor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Resultado:";
            // 
            // tbvalor
            // 
            this.tbvalor.Location = new System.Drawing.Point(109, 43);
            this.tbvalor.Name = "tbvalor";
            this.tbvalor.Size = new System.Drawing.Size(120, 20);
            this.tbvalor.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 3;
            // 
            // btn_realdolar
            // 
            this.btn_realdolar.Location = new System.Drawing.Point(25, 72);
            this.btn_realdolar.Name = "btn_realdolar";
            this.btn_realdolar.Size = new System.Drawing.Size(104, 23);
            this.btn_realdolar.TabIndex = 4;
            this.btn_realdolar.Text = "Real para Dólar";
            this.btn_realdolar.UseVisualStyleBackColor = true;
            this.btn_realdolar.Click += new System.EventHandler(this.btn_realdolar_Click);
            // 
            // dolarparareal
            // 
            this.dolarparareal.Location = new System.Drawing.Point(135, 72);
            this.dolarparareal.Name = "dolarparareal";
            this.dolarparareal.Size = new System.Drawing.Size(94, 23);
            this.dolarparareal.TabIndex = 5;
            this.dolarparareal.Text = "Dólar para Real";
            this.dolarparareal.UseVisualStyleBackColor = true;
            this.dolarparareal.Click += new System.EventHandler(this.Dolarparareal_Click);
            // 
            // Btn_realparaeuro
            // 
            this.Btn_realparaeuro.Location = new System.Drawing.Point(25, 110);
            this.Btn_realparaeuro.Name = "Btn_realparaeuro";
            this.Btn_realparaeuro.Size = new System.Drawing.Size(104, 23);
            this.Btn_realparaeuro.TabIndex = 6;
            this.Btn_realparaeuro.Text = "Real para Euro";
            this.Btn_realparaeuro.UseVisualStyleBackColor = true;
            this.Btn_realparaeuro.Click += new System.EventHandler(this.Btn_realparaeuro_Click);
            // 
            // Btn_euroreal
            // 
            this.Btn_euroreal.Location = new System.Drawing.Point(135, 110);
            this.Btn_euroreal.Name = "Btn_euroreal";
            this.Btn_euroreal.Size = new System.Drawing.Size(94, 23);
            this.Btn_euroreal.TabIndex = 7;
            this.Btn_euroreal.Text = "Euro para Real";
            this.Btn_euroreal.UseVisualStyleBackColor = true;
            this.Btn_euroreal.Click += new System.EventHandler(this.Btn_euroreal_Click);
            // 
            // btneuroparadolar
            // 
            this.btneuroparadolar.Location = new System.Drawing.Point(25, 150);
            this.btneuroparadolar.Name = "btneuroparadolar";
            this.btneuroparadolar.Size = new System.Drawing.Size(104, 23);
            this.btneuroparadolar.TabIndex = 8;
            this.btneuroparadolar.Text = "Euro para Dólar";
            this.btneuroparadolar.UseVisualStyleBackColor = true;
            this.btneuroparadolar.Click += new System.EventHandler(this.btneuroparadolar_Click);
            // 
            // btndolarparaeuro
            // 
            this.btndolarparaeuro.Location = new System.Drawing.Point(135, 150);
            this.btndolarparaeuro.Name = "btndolarparaeuro";
            this.btndolarparaeuro.Size = new System.Drawing.Size(94, 23);
            this.btndolarparaeuro.TabIndex = 9;
            this.btndolarparaeuro.Text = "Dólar para Euro";
            this.btndolarparaeuro.UseVisualStyleBackColor = true;
            this.btndolarparaeuro.Click += new System.EventHandler(this.btndolarparaeuro_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(154, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 231);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btndolarparaeuro);
            this.Controls.Add(this.btneuroparadolar);
            this.Controls.Add(this.Btn_euroreal);
            this.Controls.Add(this.Btn_realparaeuro);
            this.Controls.Add(this.dolarparareal);
            this.Controls.Add(this.btn_realdolar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbvalor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Conversor de Moedas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbvalor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_realdolar;
        private System.Windows.Forms.Button dolarparareal;
        private System.Windows.Forms.Button Btn_realparaeuro;
        private System.Windows.Forms.Button Btn_euroreal;
        private System.Windows.Forms.Button btneuroparadolar;
        private System.Windows.Forms.Button btndolarparaeuro;
        private System.Windows.Forms.Button button1;
    }
}

