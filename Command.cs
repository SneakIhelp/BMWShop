using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BMWShop
{
    internal class Command : database
    {
        private SqlDataAdapter sqlDataAdapter = null;
        public DataTable MainTable = new DataTable();
        private DataSet dataSet = null;

        private List<ParametersSql> Parametr = new List<ParametersSql>();
        
        public void LoadData(string _command)
        {
            openConnection();

            try
            {
                SqlCommand newCommand = new SqlCommand(_command,  getConnection());
                dataSet = new DataSet();

                sqlDataAdapter = new SqlDataAdapter();
                sqlDataAdapter.SelectCommand = newCommand;
                sqlDataAdapter.Fill(dataSet, "Load");

                MainTable = dataSet.Tables["Load"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            closeConnection();
        }

        public void SendCommand(string command)
        {
            openConnection();
            try
            {
                SqlCommand sqlCommand = new SqlCommand(command, getConnection());
                foreach (ParametersSql parS in Parametr)
                {
                    sqlCommand.Parameters.Add(parS.Title, parS.TypeSql).Value = parS.Value;
                }
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            closeConnection();
            Parametr.Clear();
        }

        public void AddParameter(string _title, SqlDbType _type, string _value)
        {
            ParametersSql parametersSql = new ParametersSql();
            parametersSql.Title = _title;
            parametersSql.TypeSql = _type;
            parametersSql.Value = _value;
            Parametr.Add(parametersSql);
        }

        public class ParametersSql 
        {
            public string Title;
            public SqlDbType TypeSql;
            public string Value;
        }
    }
}
