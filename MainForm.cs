using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BMWShop{
    
    public partial class MainForm : Form
    {
        private string binaryCodeAdd = null;
        private string binaryCodeUpdate = null;
        private int selectId;
        private int rowInd;
        public MainForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData() 
        {
            Command loadData = new Command();
            loadData.LoadData("SELECT id_spares, name_spares, price_spares, id_model, category FROM spares");
            productsTable.DataSource = loadData.MainTable;
        }

        private void groupBox1_Enter(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            Command command = new Command();
            command.SendCommand("INSERT INTO spares (id_spares, name_spares, price_spares, id_model, category, ImageData) VALUES ((SELECT ISNULL(MAX(id_spares), 0) + 1 FROM spares), '" + ProductTitleAdd.Text + "', '" + CostAdd.Text + "', '" + IdModelAdd.Text + "', '" + CategoryAdd.Text + "', CONVERT(varbinary(max), '" + binaryCodeAdd + "'));");
            LoadData();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            Command command = new Command();
            if (binaryCodeUpdate != null)
            {
                command.SendCommand("UPDATE spares SET name_spares = '" + ProductTitleUpdate.Text + "', price_spares = " + CostUpdate.Text + ", id_model = " + IdModelUpdate.Text + ", category = '" + CategoryUpdate.Text + "', ImageData = CONVERT(varbinary(max), '" + binaryCodeUpdate + "') WHERE id_spares = " + (selectId).ToString());
            }
            else
            {
                command.SendCommand("UPDATE spares SET name_spares = '" + ProductTitleUpdate.Text + "', price_spares = " + CostUpdate.Text + ", id_model = " + IdModelUpdate.Text + ", category = '" + CategoryUpdate.Text + "' WHERE id_spares = " + (selectId).ToString());
            }
            LoadData();
        }

        private void AddPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif";
            openFileDialog.Title = "Выберите фотографию";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                byte[] binaryData = File.ReadAllBytes(filePath);
                binaryCodeAdd = Convert.ToBase64String(binaryData);
            }
        }

        private void UpdatePhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif";
            openFileDialog.Title = "Выберите фотографию";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                byte[] binaryData = File.ReadAllBytes(filePath);
                binaryCodeUpdate = Convert.ToBase64String(binaryData);
            }
        }

        private void productsTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowInd = e.RowIndex;
            selectId = Convert.ToInt32(productsTable[0, e.RowIndex].Value);

            ProductTitleUpdate.Text = productsTable[1, e.RowIndex].Value.ToString();
            CostUpdate.Text = productsTable[2, e.RowIndex].Value.ToString();
            IdModelUpdate.Text = productsTable[3, e.RowIndex].Value.ToString();
            CategoryUpdate.Text = productsTable[4, e.RowIndex].Value.ToString();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (rowInd == 0) return;
            string titleDeleteProd = productsTable[1, rowInd].Value.ToString();

            if(MessageBox.Show("Вы уверены, что хотите удалить " + titleDeleteProd + "?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Command command = new Command();
                command.SendCommand("DELETE spares WHERE id_spares = " + selectId.ToString());
                LoadData();
            }
        }

        private void OrdersBtn_Click(object sender, EventArgs e)
        {
            Orders orders = new Orders();
            orders.Show();
            this.Hide();
        }
    }
}
