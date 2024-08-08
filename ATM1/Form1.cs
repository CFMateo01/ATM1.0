using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;  
using System.Threading;

namespace ATM1
{
    public partial class Form1ATM1 : Form
    {
        public Form1ATM1()
        {
            Thread tardar = new Thread(new ThreadStart(pantalla));
            tardar.Start();
            Thread.Sleep(5000);
             InitializeComponent();
            tardar.Abort();
        }
        public void pantalla() { Application.Run(new atmInicio()); }

        private void label4_Click(object sender, EventArgs e)
        {
            txtpin.Text += "4";
        }
        private void label0_Click(object sender, EventArgs e)
        {
            txtpin.Text += "0";
        }

        private void lbl5_Click(object sender, EventArgs e)
        {
            txtpin.Text += "5";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            txtpin.Text += "1";
        }

        private void lbl2_Click(object sender, EventArgs e)
        {
            txtpin.Text += "2";
        }

        private void lbl3_Click(object sender, EventArgs e)
        {
            txtpin.Text += "3";
        }

        private void lbl6_Click(object sender, EventArgs e)
        {
            txtpin.Text += "6";
        }

        private void lbl8_Click(object sender, EventArgs e)
        {
            txtpin.Text += "8";
        }

        private void lbl9_Click(object sender, EventArgs e)
        {
            txtpin.Text += "9";
        }

        private void label7_Click(object sender, EventArgs e)
        {
            txtpin.Text += "7";
        }

        private void lbldelete_Click(object sender, EventArgs e)
        {
            string lastchart = txtpin.Text.Substring(0, txtpin.TextLength - 1);
            txtpin.Text = lastchart;
        }

        private void lblcancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblenter_Click(object sender, EventArgs e)
        {
            string password = Properties.Settings.Default.Password;
            if (txtpin.Text == password)
            {
                tabControl1.SelectTab(1);
            }
            else
            {
                MessageBox.Show("PIN incorrecto", "Validadacion BD");
                txtpin.Text = "";
            }
        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
            lblBalance.Text  = Properties.Settings.Default.Capital;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
            txtpin.Text = "";
        }

        private void btnRetiro_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(3);
            aux.Text = Properties.Settings.Default.Capital;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            withDraw(100);
        }

        private void withDraw(Double cantidad)
        { 
            double balance = double.Parse(aux.Text);
            if (balance >= cantidad)
            {
                double z = balance - cantidad;
                Properties.Settings.Default.Capital = Convert.ToString(z);
                MessageBox.Show("Retire su dinero, Gracias por preferirnos", "Retirando dinero", MessageBoxButtons.OK);
            }
            else {
                MessageBox.Show("No posee fondos suficientes");
            }
        }

        private void btn200_Click(object sender, EventArgs e)
        {
            withDraw(200);
        }

        private void btn300_Click(object sender, EventArgs e)
        {
            withDraw(300);
        }

        private void btn500_Click(object sender, EventArgs e)
        {
            withDraw(500);
        }

        private void btn1000_Click(object sender, EventArgs e)
        {
            withDraw(1000);
        }

        private void btnOtro_Click(object sender, EventArgs e)
        {
            String request = Microsoft.VisualBasic.Interaction.InputBox("Ingrese Otra cantidad","Otra cantidad","0");
            double dinero = double.Parse(request);
            MessageBox.Show("" + dinero);
            withDraw(dinero);
        }
    }
}
