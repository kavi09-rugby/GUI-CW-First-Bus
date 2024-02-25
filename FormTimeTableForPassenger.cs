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
    public partial class FormTimeTableForPassenger : Form
    {
        public FormTimeTableForPassenger(string PUN)
        {
            InitializeComponent();
            guna2TextBoxPUN.Text = PUN;
            guna2TextBoxPUN.Hide();
        }


        private void guna2TextBoxSearchBar_MouseEnter_1(object sender, EventArgs e)
        {
            guna2TextBoxSearchBar.Clear();
        }

        private void FormTimeTableForPassenger_Load_1(object sender, EventArgs e)
        {
            DB_Connection dB_Connection = new DB_Connection();

            string sql = "SELECT BusTime,RouteName,BusName,BusAvailability,TravelTime,Distance FROM Bus_Routes br INNER JOIN Bus b ON br.RouteNumber = b.RouteNumber INNER JOIN Bus_TimeTable bt ON bt.BusRegisterNumber = b.BusRegisterNumber";
            SqlCommand sqlCommand = new SqlCommand(sql, dB_Connection.GetSqlConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            guna2DataGridViewTimeTable.DataSource = dataTable;
        }

        private void guna2CirclePictureBoxSearch_Click_1(object sender, EventArgs e)
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
        
        private void guna2GradientButtonBack_Click_1(object sender, EventArgs e)
        {
            FormPassengerDashBoard formBusPassengerDashboard = new FormPassengerDashBoard(guna2TextBoxPUN.Text);
            formBusPassengerDashboard.ShowDialog();
            this.Close();
            
        }

        private void guna2TextBoxSearchBar_KeyPress_1(object sender, KeyPressEventArgs e)
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
    }
}
