using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong
{
    public partial class Form1 : Form
    {
        public Form1(int value)
        {
            InitializeComponent();
            if (value == 0)
            {
                value = 100;
            }
            else
            {
                picRaquete.Height = value;
            }
        }

        int velocidade = 25;
        int resultado;
        bool topo, esquerda;

        private void Form1_Load(object sender, EventArgs e)
        {            
            // TODO: This line of code loads data into the 'databaseDataSet.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.databaseDataSet.users);
            Random rand = new Random();
            picBola.Location = new Point(0, rand.Next(this.Height));
            topo = esquerda = true;
            timer1.Enabled = true;
            userToolStripMenuItem.Text = "User: " + FormLogin.user;
            if (FormLogin.user == "admin")
            {
                userRegisterToolStripMenuItem.Enabled = true;               
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (picBola.Left > picRaquete.Left)
            {
                timer1.Enabled = false; MessageBox.Show("Você perdeu. Sua pontuação foi: " + resultado.ToString());
                resultado = 0;
            }
            if (picBola.Left + picBola.Width >= picRaquete.Left && picBola.Left + picBola.Width
                <= picRaquete.Left + picRaquete.Width
                && picBola.Top + picBola.Height >= picRaquete.Top && picBola.Top + picBola.Height
                <= picRaquete.Top + picRaquete.Height + picBola.Height)
            {
                esquerda = false;
                resultado += 1;
                this.Text = resultado.ToString();
            }
            if (esquerda)
                picBola.Left += velocidade;
            else
                picBola.Left -= velocidade;
            if (topo)
                picBola.Top += velocidade;
            else
                picBola.Top -= velocidade;
            if (picBola.Top >= this.Height - 50)
                topo = false;
            if (picBola.Top <= 0)
                topo = true;
            if (picBola.Left <= 0)
                esquerda = true;
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void usersBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }
    
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            picRaquete.Top = e.Y;
        }

        private void outToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveandLogOut();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void userRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRegisterUser frm = new FormRegisterUser();
            frm.ShowDialog();
        }

        private void SaveandLogOut()
        {
            try
            {
                this.Validate();
                this.usersBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.databaseDataSet);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível gravar! Erro: " + ex.Message, "Erro ao gravar",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }
    }
}
