namespace PingPong
{
    partial class frmMenu
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
            this.buttonFacil = new System.Windows.Forms.Button();
            this.buttonMedio = new System.Windows.Forms.Button();
            this.buttonDificil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonFacil
            // 
            this.buttonFacil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFacil.Location = new System.Drawing.Point(114, 90);
            this.buttonFacil.Name = "buttonFacil";
            this.buttonFacil.Size = new System.Drawing.Size(199, 55);
            this.buttonFacil.TabIndex = 0;
            this.buttonFacil.Text = "Fácil";
            this.buttonFacil.UseVisualStyleBackColor = true;
            this.buttonFacil.Click += new System.EventHandler(this.buttonFacil_Click);
            // 
            // buttonMedio
            // 
            this.buttonMedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMedio.Location = new System.Drawing.Point(114, 151);
            this.buttonMedio.Name = "buttonMedio";
            this.buttonMedio.Size = new System.Drawing.Size(199, 55);
            this.buttonMedio.TabIndex = 1;
            this.buttonMedio.Text = "Médio";
            this.buttonMedio.UseVisualStyleBackColor = true;
            this.buttonMedio.Click += new System.EventHandler(this.buttonMedio_Click);
            // 
            // buttonDificil
            // 
            this.buttonDificil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDificil.Location = new System.Drawing.Point(114, 212);
            this.buttonDificil.Name = "buttonDificil";
            this.buttonDificil.Size = new System.Drawing.Size(199, 55);
            this.buttonDificil.TabIndex = 2;
            this.buttonDificil.Text = "Dificil";
            this.buttonDificil.UseVisualStyleBackColor = true;
            this.buttonDificil.Click += new System.EventHandler(this.buttonDificil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Escolha a dificuldade do jogo:";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 301);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDificil);
            this.Controls.Add(this.buttonMedio);
            this.Controls.Add(this.buttonFacil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFacil;
        private System.Windows.Forms.Button buttonMedio;
        private System.Windows.Forms.Button buttonDificil;
        private System.Windows.Forms.Label label1;
    }
}