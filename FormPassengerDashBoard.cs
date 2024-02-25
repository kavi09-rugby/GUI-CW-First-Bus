using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GUI_CW
{
    public partial class FormPassengerDashBoard : Form
    {
        public FormPassengerDashBoard(string passengerUN)
        {
            InitializeComponent();
            guna2TextBoxPUN.Text = passengerUN;

            guna2ShadowPanelPassengerDetails.Hide();
            guna2TextBoxPUN.Hide();
        }

        public FormPassengerDashBoard()
        {
            InitializeComponent();
        }


        ///go to home
        private void guna2GradientButtonHome_Click(object sender, EventArgs e)
        {
            FormWelcome formWelcome = new FormWelcome();
            formWelcome.ShowDialog();
            this.Close();
        }


        //see  your details
        private void guna2GradientButtonYourDetails_Click(object sender, EventArgs e)
        {
            DB_Connection dB_Connection = new DB_Connection();

            string sql = "SELECT * FROM Passenger WHERE PassengerEmail = '" + guna2TextBoxPUN.Text + "' ";
            SqlCommand sqlCommand = new SqlCommand(sql, dB_Connection.GetSqlConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
            {
                try
                {
                    if (dataTable.Rows.Count > 0)
                    {
                        if (dataReader.Read())
                        {
                            guna2HtmlLabel_P_Email.Text = dataReader["PassengerEmail"].ToString();
                            guna2HtmlLabel_P_F_Name.Text = dataReader["PassengerFirstName"].ToString();
                            guna2HtmlLabel_P_L_Name.Text = dataReader["PassengerLastName"].ToString();
                            guna2HtmlLabel_P_Gender.Text = dataReader["PassengerGender"].ToString();
                            guna2HtmlLabel_P_WpNo.Text = dataReader["PassengerWhatsApp"].ToString();
                            guna2HtmlLabel_P_Street.Text = dataReader["PassengerStreet"].ToString();
                            guna2HtmlLabel_P_City.Text = dataReader["PassengerCity"].ToString();

                        }
                        guna2PanelButtons.Hide();
                        guna2ShadowPanelPassengerDetails.Show();
                        guna2TextBoxPUN.Hide();
                        guna2PanelLableDisplay.Hide();
                        //guna2HtmlLabelYourDetails2.Hide();
                        guna2HtmlLabelYourDetails2.Show();
                        guna2PanelLableDisplay.Show();
                        // guna2TextBoxPUN.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
               
            }
        }
        //back to main panal
        private void guna2GradientButtonBackPDetails_Click(object sender, EventArgs e)
        {
            guna2ShadowPanelPassengerDetails.Hide();
            guna2PanelButtons.Show();
        }

        //goto edit detail panal
        private void guna2GradientButtonEditDetails_Click(object sender, EventArgs e)
        {
            FormPassengerDetailsUpdate formPassengerDetailsUpdate = new FormPassengerDetailsUpdate(guna2TextBoxPUN.Text);
            formPassengerDetailsUpdate.Show();
            this.Hide();
        }
        public string GetPassengerPassword()
        {
            return guna2TextBoxPUN.Text;
        }

        // goto passenger bus time table
        private void guna2GradientButtonViewBusTimeTable_Click(object sender, EventArgs e)
        {
            FormTimeTableForPassenger formTimeTableForPassenger = new FormTimeTableForPassenger(guna2TextBoxPUN.Text);
            formTimeTableForPassenger.Show();
            this.Hide();
        }

        // goto passenger route details
        private void guna2GradientButtonViewRouteDetails_Click(object sender, EventArgs e)
        {
            FormRouteDetailsPassenger formRouteDetailsPassenger = new FormRouteDetailsPassenger(guna2TextBoxPUN.Text);
            formRouteDetailsPassenger.Show();
            this.Hide();
        }

        private void guna2GradientButtonExit_Click(object sender, EventArgs e)
        {
            guna2TextBoxPUN.Clear();
            Close();
        }

        private void guna2TextBoxPUN_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
/*  DB_Connection dB_Connection = new DB_Connection();
            guna2ShadowPanelBusDetails.Show();

            string sql = "SELECT B.BusRegisterNumber,B.BusName,B.BusType,B.BusWhatsApp,R.RouteNumber,R.RouteName FROM Bus B JOIN Bus_Routes R ON B.RouteNumber = R.RouteNumber WHERE BusRegisterNumber = '"+guna2TextBoxEnterBusPW.Text+"' ";
            SqlCommand sqlCommand = new SqlCommand(sql, dB_Connection.GetSqlConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
            {
                if (dataTable.Rows.Count > 0)
                {
                    if (dataReader.Read())
                    {
                        guna2HtmlLabel_B_RegNo.Text = dataReader["BusRegisterNumber"].ToString();
                        guna2HtmlLabel_B_Name.Text = dataReader["BusName"].ToString();
                        guna2HtmlLabel_B_Type.Text = dataReader["BusType"].ToString();
                        guna2HtmlLabel_B_WPN.Text = dataReader["BusWhatsApp"].ToString();
                        guna2HtmlLabel_B_RouteNo.Text = dataReader["RouteNumber"].ToString();
                        guna2HtmlLabelBusRoute.Text = dataReader["RouteName"].ToString() ;
                        
                    }
                    guna2PanelButtons.Hide();
                    guna2ShadowPanelBusDetails.Show();
                    guna2TextBoxEnterBusPW.Hide();
                    guna2PanelLableDisplay.Hide();
                    guna2HtmlLabelBusDetails2.Hide();
                    guna2HtmlLabelBusDetails2.Show();
                    guna2PanelLableDisplay.Show();
                    guna2TextBoxEnterBusPW.Clear();
                }
            } */

/*                          guna2HtmlLabel_P_Email.Text = dataReader["PassengerEmail"].ToString();
                            guna2HtmlLabel_P_F_Name.Text = dataReader["PassengerFirstName"].ToString();
                            guna2HtmlLabel_P_L_Name.Text = dataReader["PassengerLastName"].ToString();
                            guna2HtmlLabel_P_Gender.Text = dataReader["PassengerGender"].ToString();
                            guna2HtmlLabel_P_WpNo.Text = dataReader["PassengerWhatsApp"].ToString();
                            guna2HtmlLabel_P_Street.Text = dataReader["PassengerStreet"].ToString();
                            guna2HtmlLabel_P_City.Text = dataReader["PassengerCity"].ToString(); */

/* string sql = "SELECT * FROM Passenger WHERE PassengerEmail = '" + guna2TextBoxPUN.Text + "' ";*/