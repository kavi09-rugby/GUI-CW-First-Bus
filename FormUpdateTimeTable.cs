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
    public partial class FormUpdateTimeTable : Form
    {
        public FormUpdateTimeTable(string BKU)
        {
            InitializeComponent();
            guna2TextBoxBKUN.Text = BKU;
            guna2TextBoxBKUN.Hide();
        }

        public void timeTableView()
        {

            try
            {
                DB_Connection dB_Connection = new DB_Connection();

                string sql = "SELECT * FROM Bus_TimeTable";
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

        private void guna2GradientPanelButtonBar_Paint(object sender, PaintEventArgs e)
        {

        }
        //back
        private void guna2GradientButtonBack_Click(object sender, EventArgs e)
        {
            FormBusKeeperDashboard formBusKeeperDashboard = new FormBusKeeperDashboard(guna2TextBoxBKUN.Text);
            formBusKeeperDashboard.Show();
            this.Close();
        }

       

      /*  private void guna2GradientButtonSave_Click(object sender, EventArgs e)
        {
            DB_Connection dbConnection = new DB_Connection();

            string sql = "UPDATE Bus_TimeTable SET BusRegisterNumber = '"+ guna2TextBoxBusRN.Text + "',BusTime = '"+ guna2TextBoxSetTimes.Text + "' WHERE RouteNumber = '"+ guna2TextBoxRouteNo.Text + "' ";
            SqlCommand sqlCommand = new SqlCommand( sql, dbConnection.GetSqlConnection());
            sqlCommand.ExecuteNonQuery();
        }
      */
      
        /// add new time for bus
        private void guna2GradientButtonAddNewttimeSave_Click(object sender, EventArgs e)
        {

            try
            {
                DB_Connection dB_Connection = new DB_Connection();

                string sql = "INSERT INTO Bus_TimeTable(BusRegisterNumber,RouteNumber,BusTime,BusAvailability) VALUES ('" + guna2TextBoxAddNewTimeBusRNo.Text + "','" + guna2TextBoxAddNewTimeRoute.Text + "','" + guna2TextBoxAddNewTime.Text + "','')";
                SqlCommand sqlCommand = new SqlCommand(sql, dB_Connection.GetSqlConnection());
                sqlCommand.ExecuteNonQuery();

                timeTableView();

                guna2TextBoxAddNewTime.Clear();
                guna2TextBoxAddNewTimeBusRNo.Clear();
                guna2TextBoxAddNewTimeRoute.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void guna2GradientButtonViweTable_Click(object sender, EventArgs e)
        {
            DB_Connection dB_Connection = new DB_Connection();

            timeTableView();
        }

        private void guna2GradientButtonSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                DB_Connection dbConnection = new DB_Connection();

                string sql = " DELETE FROM  Bus_TimeTable WHERE BusRegisterNumber = '" + guna2TextBoxBusRN.Text + "' ";
                SqlCommand sqlCommand = new SqlCommand(sql, dbConnection.GetSqlConnection());
                sqlCommand.ExecuteNonQuery();

                timeTableView();

                guna2TextBoxBusRN.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
