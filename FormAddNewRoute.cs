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
    public partial class FormAddNewRoute : Form
    {
        public FormAddNewRoute(string BKUN)
        {
            InitializeComponent();
            //get bus keeper user name
            guna2TextBoxBKUN.Text = BKUN; 
            //when page loard
            guna2HtmlLabelSuccsesMessge.Hide();
            guna2GradientButtonOk.Hide();
            guna2GradientPanelEditRoute.Hide();
            guna2HtmlLabelUpdateSuccsMess.Hide();
            guna2GradientButtonEOk.Hide();
            labelEditRoute.Hide();
            guna2TextBoxBKUN.Hide();
        }

       

        public void textBoxClear()
        {
            guna2TextBoxRouteNum.Clear();
            guna2TextBoxRouteName.Clear();
            guna2TextBoxDistence.Clear();
            guna2TextBoxTravelTime.Clear();
        }
        //creat route
        private void guna2gradientButtonCreate_Click(object sender, EventArgs e)
        {
            try
            {
                DB_Connection dB_Connection = new DB_Connection();

                string sql = "INSERT INTO Bus_Routes(RouteNumber,RouteName,Distance,TravelTime) VALUES ('" + guna2TextBoxRouteNum.Text + "','" + guna2TextBoxRouteName.Text + "','" + guna2TextBoxDistence.Text + "','" + guna2TextBoxTravelTime.Text + "')";
                SqlCommand sqlCommand = new SqlCommand(sql, dB_Connection.GetSqlConnection());
                sqlCommand.ExecuteNonQuery();

                guna2HtmlLabelSuccsesMessge.Show();
                guna2GradientButtonOk.Show();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        //clear text boxes
        private void guna2GradientButtonOk_Click(object sender, EventArgs e)
        {
            textBoxClear();
            guna2HtmlLabelSuccsesMessge.Hide();
            guna2GradientButtonOk.Hide();

        }
        //back
        private void guna2GradientButtonBack_Click(object sender, EventArgs e)
        {
            FormBusKeeperDashboard formBusKeeperDashboard = new FormBusKeeperDashboard(guna2TextBoxBKUN.Text);
            formBusKeeperDashboard.Show();
            this.Hide();
        }
        //edit rout
        private void guna2GradientButtonEdit_Click(object sender, EventArgs e)
        {
            labelEditRoute.Show();
            labelAddBusRoute.Hide();
            guna2GradientPanelEditRoute.Show();
        }
        // show route details to edit
        private void guna2GradientButtonOkEdit_Click(object sender, EventArgs e)

        {
            try
            {
                DB_Connection dB_Connection = new DB_Connection();

                string sql = "SELECT * FROM Bus_Routes WHERE RouteNumber = '" + guna2TextBoxEnterRNum.Text + "' ";
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
                            guna2TextBoxERName.Text = dataReader["RouteName"].ToString();
                            guna2TextBoxED.Text = dataReader["Distance"].ToString();
                            guna2TextBoxETT.Text = dataReader["TravelTime"].ToString();


                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
        // update route details
        private void guna2GradientButtonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                DB_Connection dB_Connection = new DB_Connection();

                string sql = "UPDATE Bus_Routes SET RouteName = '" + guna2TextBoxERName.Text + "', Distance = '" + guna2TextBoxED.Text + "', TravelTime = '" + guna2TextBoxETT.Text + "' WHERE RouteNumber = '" + guna2TextBoxEnterRNum.Text + "'";
                SqlCommand sqlCommand = new SqlCommand(sql, dB_Connection.GetSqlConnection());
                sqlCommand.ExecuteNonQuery();

                guna2HtmlLabelUpdateSuccsMess.Show();
                guna2GradientButtonEOk.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

           
        }

        private void guna2GradientButtonEOk_Click(object sender, EventArgs e)
        {
            
            guna2HtmlLabelUpdateSuccsMess.Hide();
            guna2GradientButtonEOk.Hide();

        }

        private void guna2GradientButtonAddNew_Click(object sender, EventArgs e)
        {
            guna2GradientPanelAddRoute.Show();
            guna2GradientPanelEditRoute.Hide();
            labelAddBusRoute.Show();
            labelEditRoute.Hide();
        }
    }
}

/* DB_Connection dB_Connection = new DB_Connection();
            guna2ShadowPanelPassengerDetails.Show();

            string sql = "SELECT * FROM Passenger WHERE PassengerEmail = '" + guna2TextBoxPUN.Text + "' ";
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
                        guna2HtmlLabel_P_Email.Text = dataReader["PassengerEmail"].ToString();
                        guna2HtmlLabel_P_F_Name.Text = dataReader["PassengerFirstName"].ToString();
                        guna2HtmlLabel_P_L_Name.Text = dataReader["PassengerLastName"].ToString();
                        guna2HtmlLabel_P_Gender.Text = dataReader["PassengerGender"].ToString();
                        guna2HtmlLabel_P_WpNo.Text = dataReader["PassengerWhatsApp"].ToString();
                        guna2HtmlLabel_P_Street.Text = dataReader["PassengerStreet"].ToString();
                        guna2HtmlLabel_P_City.Text = dataReader["PassengerCity"].ToString();

                    }
                }
            }
           */