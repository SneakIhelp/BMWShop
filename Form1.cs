using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMWShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Command command = new Command();
            command.LoadData("SELECT e.job_title FROM employee e JOIN users u ON e.id_users = u.id_users WHERE u.login_users = '" +
                textBox1.Text + "' AND u.password_users = '" + textBox2.Text + "';");

            if (command.MainTable.Rows.Count > 0)
            {
                if (command.MainTable.Rows[0][0].ToString() == "Администратор")
                {
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                    this.Hide();
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
