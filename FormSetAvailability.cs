using Guna.UI2.WinForms;
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

namespace GUI_CW
{
    public partial class FormSetAvailability : Form
    {
        public FormSetAvailability(string BUN)
        {
            InitializeComponent();

            guna2TextBoxBUN.Text = BUN;
            guna2TextBoxBUN.Hide();
        }

        private void TableView()
        {
            DB_Connection dB_Connection = new DB_Connection();

            string sql = " SELECT*FROM Bus_TimeTable WHERE BusRegisterNumber= '" + guna2TextBoxBUN.Text + "'";
            SqlCommand sqlCommand = new SqlCommand(sql, dB_Connection.GetSqlConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            guna2DataGridViewTimeTable.DataSource = dataTable;
        }

        private void FormSetAvailability_Load(object sender, EventArgs e)
        {
           TableView();
        }

        private void guna2TextBoxBUN_TextChanged(object sender, EventArgs e)
        {

        }

        // when bus not available 
        private void guna2CirclePictureBoxNotAva_Click(object sender, EventArgs e)
        {
            try
            {
                DB_Connection dB_Connection = new DB_Connection();

                string sql = "UPDATE Bus_TimeTable SET BusAvailability = 'Not Available' WHERE BusRegisterNumber = '" + guna2TextBoxBUN.Text + "' AND BusTime = '" + guna2TextBoxTime.Text + "' ";
                SqlCommand sqlCommand = new SqlCommand(sql, dB_Connection.GetSqlConnection());
                sqlCommand.ExecuteNonQuery();
                guna2TextBoxTime.Clear();
                TableView();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        //when bus  available
        private void guna2CirclePictureBoxAvailable_Click(object sender, EventArgs e)
        {
            try
            {
                DB_Connection dB_Connection = new DB_Connection();

                string sql = "UPDATE Bus_TimeTable SET BusAvailability = 'Available' WHERE BusRegisterNumber = '" + guna2TextBoxBUN.Text + "' AND BusTime = '" + guna2TextBoxTime.Text + "' ";
                SqlCommand sqlCommand = new SqlCommand(sql, dB_Connection.GetSqlConnection());
                sqlCommand.ExecuteNonQuery();
                guna2TextBoxTime.Clear();
                TableView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void guna2GradientButtonViewTimeTable_Click(object sender, EventArgs e)
        {
            TableView();
        }

        private void guna2GradientButtonBack_Click(object sender, EventArgs e)
        {
            FormBusDashboard formBusDashboard = new FormBusDashboard(guna2TextBoxBUN.Text);
            formBusDashboard.Show();
            this.Close();
        }
    }
}
