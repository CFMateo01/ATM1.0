using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM1
{
    public partial class frmbd : Form
    {
        public frmbd()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.Name = txtName.Text;
                Properties.Settings.Default.LastName = txtApellido.Text;
                Properties.Settings.Default.Password = txtPasword.Text;
                Properties.Settings.Default.Capital = txtCapital.Text;
                Properties.Settings.Default.Save();
                MessageBox.Show("Cliente Registrado en BD");
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void frmbd_Load(object sender, EventArgs e)
        {
            txtName.Text = Properties.Settings.Default.Name;
            txtApellido.Text = Properties.Settings.Default.LastName;
            txtPasword.Text = Properties.Settings.Default.Password;
            txtCapital.Text = Properties.Settings.Default.Capital;   
        }
    }
}
