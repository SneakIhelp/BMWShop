using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMWShop
{
    public partial class Orders : Form
    {
        private int selectId;
        private int rowInd = -2;
        public Orders()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            Command loadData = new Command();
            loadData.LoadData("SELECT shopping_cart.id_shopping_cart, shopping_cart.id_spares, shopping_cart.quantity, shopping_cart.sum, client.name_client, client.surname_client, client.patronymic_client, client.number_client, client.address_client, delivery.delivery_time, delivery.confirmation FROM shopping_cart JOIN client ON shopping_cart.id_shopping_cart = client.id_client JOIN delivery ON shopping_cart.id_shopping_cart = delivery.id_delivery;");
            ordersTable.DataSource = loadData.MainTable;
        }

        private void ordersTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowInd = e.RowIndex;
            selectId = Convert.ToInt32(ordersTable[0, rowInd].Value.ToString());

            GoodsNumbers.Text = ordersTable[1, rowInd].Value.ToString();
            GoodsQuant.Text = ordersTable[2, rowInd].Value.ToString();
            ClientName.Text = ordersTable[4, rowInd].Value.ToString();
            ClientSurname.Text = ordersTable[5, rowInd].Value.ToString();
            ClientPatr.Text = ordersTable[6, rowInd].Value.ToString();
            ClientPhoneNumber.Text = ordersTable[7, rowInd].Value.ToString();
            ClientAddress.Text = ordersTable[8, rowInd].Value.ToString();
            ClientDeliveryTime.Text = ordersTable[9, rowInd].Value.ToString();
        }

        private void ChangeBtn_Click(object sender, EventArgs e)
        {
            Command command = new Command();
            int totalSum = CalculateTotalSum(GoodsNumbers.Text, GoodsQuant.Text);
            command.SendCommand("UPDATE shopping_cart SET id_spares = '" + GoodsNumbers.Text + "', quantity = '" + GoodsQuant.Text + "', sum = '" + totalSum.ToString() + "' WHERE id_shopping_cart = '" + selectId + "'; UPDATE client SET name_client = '" + ClientName.Text + "', surname_client = '" + ClientSurname.Text + "', patronymic_client = '" + ClientPatr.Text + "', number_client = '" + ClientPhoneNumber.Text + "', address_client = '" + ClientAddress.Text + "' WHERE id_client = '" + selectId + "'; UPDATE delivery SET delivery_time = '" + ClientDeliveryTime.Text + "' WHERE id_delivery = '" + selectId + "';");
            LoadData();
        }


        public static int CalculateTotalSum(string sparesIds, string quantities)
        {
            string connectionString = "Data Source=DESKTOP-T5QI3N7\\SQLEXPRESS; Initial Catalog = bottg; Integrated Security=SSPI";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string[] ids = sparesIds.Split(';');
                string[] quantityValues = quantities.Split(';');

                int totalSum = 0;

                for (int i = 0; i < ids.Length; i++)
                {
                    int spareId = int.Parse(ids[i]);
                    int quantity = int.Parse(quantityValues[i]);

                    int sum = GetSpareSum(connection, spareId);
                    totalSum += sum * quantity;
                }

                return totalSum;
            }
        }

        public static int GetSpareSum(SqlConnection connection, int spareId)
        {
            string sqlQuery = "SELECT SUM(price_spares) FROM spares WHERE id_spares = @spareId";

            using (SqlCommand command = new SqlCommand(sqlQuery, connection))
            {
                command.Parameters.AddWithValue("@spareId", spareId);

                object result = command.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    return Convert.ToInt32(result);
                }

                return 0;
            }
        }

        private void BacktoMain_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void AcceptBtn_Click(object sender, EventArgs e)
        {
            if (rowInd == -2) return;
            Command command = new Command();
            command.SendCommand("UPDATE delivery SET confirmation = 'Одобрено' WHERE id_delivery = '" + selectId.ToString() + "';");
            LoadData();
        }

        private void DeclineBtn_Click(object sender, EventArgs e)
        {
            if (rowInd == -2) return;
            Command command = new Command();
            command.SendCommand("UPDATE delivery SET confirmation = 'Отклонено' WHERE id_delivery = '" + selectId.ToString() + "';");
            LoadData();
        }
    }
}
