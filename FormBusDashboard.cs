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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace GUI_CW
{
    public partial class FormBusDashboard : Form
    {
        public FormBusDashboard(string BusUN)
        {
            InitializeComponent();

            guna2TextBoxEnterBusPW.Text = BusUN;

            guna2ShadowPanelBusDetails.Hide();
            guna2PanelButtons.Show();
            guna2ShadowPanelRoutDetails.Hide();


        }
        // goto home
        private void guna2GradientButtonHome_Click(object sender, EventArgs e)
        {

            FormWelcome formWelcome = new FormWelcome();
            formWelcome.ShowDialog();
            this.Close();
        }
        //see details
        private void guna2GradientButtonBusDetails_Click(object sender, EventArgs e)
        {
            try
            {
                DB_Connection dB_Connection = new DB_Connection();

                string sql = "SELECT B.BusRegisterNumber,B.BusName,B.BusType,B.BusWhatsApp,R.RouteNumber,R.RouteName FROM Bus B JOIN Bus_Routes R ON B.RouteNumber = R.RouteNumber WHERE BusRegisterNumber = '" + guna2TextBoxEnterBusPW.Text + "' ";
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
                            guna2HtmlLabelBusRoute.Text = dataReader["RouteName"].ToString();

                        }
                        guna2PanelButtons.Hide();
                        guna2ShadowPanelBusDetails.Show();
                        guna2TextBoxEnterBusPW.Hide();
                        guna2PanelLableDisplay.Hide();
                        guna2HtmlLabelBusDetails2.Hide();
                        guna2HtmlLabelBusDetails2.Show();
                        guna2PanelLableDisplay.Show();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           

        }
        //back to main panal
        private void guna2GradientButtonBackPDetails_Click(object sender, EventArgs e)
        {
            guna2ShadowPanelBusDetails.Hide();
            guna2PanelButtons.Show();
        }
        //time table panal
      
        private void guna2GradientButtonViewYourBusTimeTable_Click(object sender, EventArgs e)
        {
            FormSetAvailability formSetAvailability = new FormSetAvailability(guna2TextBoxEnterBusPW.Text);
            formSetAvailability.Show();
            this.Close();
        }

        //route details view
        private void guna2GradientButtonViewRouteDetails_Click(object sender, EventArgs e)
        {
            guna2ShadowPanelRoutDetails.Show();
            guna2PanelButtons.Hide();
            try
            {
                DB_Connection dB_Connection = new DB_Connection();

                string sql = "SELECT R.RouteNumber,R.RouteName,R.Distance,R.TravelTime FROM Bus_Routes R INNER JOIN Bus B ON R.RouteNumber = B.RouteNumber WHERE BusRegisterNumber = '" + guna2TextBoxEnterBusPW.Text + "' ";
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
                            guna2HtmlLabelRNo.Text = dataReader["RouteNumber"].ToString();
                            guna2HtmlLabelRoutName.Text = dataReader["RouteName"].ToString();
                            guna2HtmlLabelDistence.Text = dataReader["Distance"].ToString();
                            guna2HtmlLabelTravelTime.Text = dataReader["TravelTime"].ToString();
                        }
                        guna2ShadowPanelRoutDetails.Show();
                        guna2PanelButtons.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormBusDashboard_Load(object sender, EventArgs e)
        {
            guna2ShadowPanelBusDetails.Hide();
            guna2PanelButtons.Show();
            
        }

       
        private void guna2GradientButtonBackFormRD_Click(object sender, EventArgs e)
        {
            guna2ShadowPanelRoutDetails.Hide();
            guna2PanelButtons.Show();
        }
    }
}
