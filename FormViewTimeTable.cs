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
    public partial class FormViewTimeTable : Form
    {
        public FormViewTimeTable(string BKUN)
        {
            InitializeComponent();
            guna2TextBoxBKUN.Text = BKUN;
            guna2TextBoxBKUN.Hide();
           
            
        }
       

        private void FormViewTimeTable_Load(object sender, EventArgs e)
        {
            DB_Connection dB_Connection = new DB_Connection();

            string sql = "SELECT BusTime,RouteName,BusName,BusAvailability,TravelTime,Distance FROM Bus_Routes br INNER JOIN Bus b ON br.RouteNumber = b.RouteNumber INNER JOIN Bus_TimeTable bt ON bt.BusRegisterNumber = b.BusRegisterNumber";
            SqlCommand sqlCommand = new SqlCommand(sql, dB_Connection.GetSqlConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            guna2DataGridViewTimeTable.DataSource = dataTable;
        }

        private void guna2TextBoxSearchBar_MouseEnter(object sender, EventArgs e)
        {
            guna2TextBoxSearchBar.Clear();
        }


        private void guna2CirclePictureBoxSearch_Click(object sender, EventArgs e)
        {

            try
            {
                DB_Connection dB_Connection = new DB_Connection();

                string sql = "SELECT BusTime,RouteName,BusName,BusAvailability,TravelTime,Distance FROM Bus_Routes br INNER JOIN Bus b ON br.RouteNumber = b.RouteNumber INNER JOIN Bus_TimeTable bt ON bt.BusRegisterNumber = b.BusRegisterNumber WHERE RouteName = '" + guna2TextBoxSearchBar.Text + "' ";
                SqlCommand sqlCommand = new SqlCommand(sql, dB_Connection.GetSqlConnection());
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                guna2DataGridViewTimeTable.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void guna2TextBoxSearchBar_KeyPress(object sender, KeyPressEventArgs e)
        {

            try
            {
                DB_Connection dB_Connection = new DB_Connection();

                string sql = "SELECT BusTime,RouteName,BusName,BusAvailability,TravelTime,Distance FROM Bus_Routes br INNER JOIN Bus b ON br.RouteNumber = b.RouteNumber INNER JOIN Bus_TimeTable bt ON bt.BusRegisterNumber = b.BusRegisterNumber WHERE RouteName = '" + guna2TextBoxSearchBar.Text + "' ";
                SqlCommand sqlCommand = new SqlCommand(sql, dB_Connection.GetSqlConnection());
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                guna2DataGridViewTimeTable.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void guna2GradientButtonBack_Click(object sender, EventArgs e)
        {
            FormBusKeeperDashboard formBusKeeperDashboard = new FormBusKeeperDashboard(guna2TextBoxBKUN.Text);
            formBusKeeperDashboard.ShowDialog();
            this.Close();
        }
    }
}
