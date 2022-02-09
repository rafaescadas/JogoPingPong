namespace PingPong
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picBola = new System.Windows.Forms.PictureBox();
            this.picRaquete = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.admistradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userRegisterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseDataSet = new PingPong.DatabaseDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new PingPong.DatabaseDataSetTableAdapters.usersTableAdapter();
            this.tableAdapterManager = new PingPong.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBola)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRaquete)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picBola
            // 
            this.picBola.Image = global::PingPong.Properties.Resources.bola1;
            this.picBola.Location = new System.Drawing.Point(391, 94);
            this.picBola.Name = "picBola";
            this.picBola.Size = new System.Drawing.Size(29, 30);
            this.picBola.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBola.TabIndex = 0;
            this.picBola.TabStop = false;
            // 
            // picRaquete
            // 
            this.picRaquete.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.picRaquete.Location = new System.Drawing.Point(778, 54);
            this.picRaquete.Name = "picRaquete";
            this.picRaquete.Size = new System.Drawing.Size(23, 359);
            this.picRaquete.TabIndex = 1;
            this.picRaquete.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logToolStripMenuItem,
            this.admistradorToolStripMenuItem,
            this.userToolStripMenuItem,
            this.resultadoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(821, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // logToolStripMenuItem
            // 
            this.logToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.outToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.logToolStripMenuItem.Name = "logToolStripMenuItem";
            this.logToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.logToolStripMenuItem.Text = "Log";
            // 
            // outToolStripMenuItem
            // 
            this.outToolStripMenuItem.Name = "outToolStripMenuItem";
            this.outToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.outToolStripMenuItem.Text = "Out";
            this.outToolStripMenuItem.Click += new System.EventHandler(this.outToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // admistradorToolStripMenuItem
            // 
            this.admistradorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userRegisterToolStripMenuItem});
            this.admistradorToolStripMenuItem.Name = "admistradorToolStripMenuItem";
            this.admistradorToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.admistradorToolStripMenuItem.Text = "Admistrador";
            // 
            // userRegisterToolStripMenuItem
            // 
            this.userRegisterToolStripMenuItem.Name = "userRegisterToolStripMenuItem";
            this.userRegisterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.userRegisterToolStripMenuItem.Text = "User Register";
            this.userRegisterToolStripMenuItem.Click += new System.EventHandler(this.userRegisterToolStripMenuItem_Click);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.userToolStripMenuItem.Text = "User:";
            // 
            // resultadoToolStripMenuItem
            // 
            this.resultadoToolStripMenuItem.Name = "resultadoToolStripMenuItem";
            this.resultadoToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.resultadoToolStripMenuItem.Text = "Score:";
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.databaseDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = PingPong.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = this.usersTableAdapter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(219, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.picRaquete);
            this.Controls.Add(this.picBola);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ping Pong";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.picBola)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRaquete)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBola;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picRaquete;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem resultadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem admistradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userRegisterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private DatabaseDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox textBox1;
    }
}

