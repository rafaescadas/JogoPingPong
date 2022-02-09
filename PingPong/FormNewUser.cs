﻿using System;
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
    public partial class FormNewUser : Form
    {
        public FormNewUser()
        {
            InitializeComponent();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void FormNewUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.databaseDataSet.users);
            usersBindingSource.AddNew();

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);
            MessageBox.Show("New user saved successfully");
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
