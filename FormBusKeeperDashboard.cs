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
    public partial class FormBusKeeperDashboard : Form
    {
        public FormBusKeeperDashboard(string busKeeperUserName)
        {
            InitializeComponent();

            guna2TextBoxBKUN.Text = busKeeperUserName;

            guna2ShadowPanelBusKeeperDetails.Hide();
            //guna2HtmlLabelErrorMessage.Hide();
        }
       
        ///go to home
        private void guna2GradientButtonHome_Click(object sender, EventArgs e)
        {
            FormWelcome formWelcome = new FormWelcome();
            formWelcome.ShowDialog();
            this.Close();
        }
        //see details
        private void guna2GradientButtonBusKeeperDetails_Click(object sender, EventArgs e)
        {
            try 
            {
                DB_Connection dB_Connection = new DB_Connection();

                string sql = "SELECT * FROM Bus_Keeper WHERE BusKeeperID = '" + guna2TextBoxBKUN.Text + "' ";
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
                            guna2HtmlLabel_BK_FN.Text = dataReader["BusKeeperFirstName"].ToString();
                            guna2HtmlLabel_BK_LN.Text = dataReader["BusKeeperLastName"].ToString();
                            guna2HtmlLabel_BK_Id.Text = dataReader["BusKeeperID"].ToString();
                            guna2HtmlLabel_BK_BusStand.Text = dataReader["BusStandName"].ToString();
                            guna2HtmlLabel_BK_WPN.Text = dataReader["BusKeeperWhatsApp"].ToString();
                            guna2HtmlLabel_BK_email.Text = dataReader["BusKeeperEmail"].ToString();
                        }
                        guna2PanelButtons.Hide();
                        guna2ShadowPanelBusKeeperDetails.Show();
                        guna2TextBoxBKUN.Hide();
                        guna2PanelLableDisplay.Hide();
                        guna2HtmlLabelBusKeeperDetails2.Hide();
                        guna2HtmlLabelBusKeeperDetails2.Show();
                        guna2PanelLableDisplay.Show();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Back to main panal
        private void guna2GradientButtonBackPDetails_Click(object sender, EventArgs e)
        {


            guna2ShadowPanelBusKeeperDetails.Hide();
            guna2PanelButtons.Show();
        }

        private void guna2GradientButtonEditDetails_Click(object sender, EventArgs e)
        {
            FormBusKeeperDetailsUpdate formBusKeeperDetailsUpdate = new FormBusKeeperDetailsUpdate(guna2TextBoxBKUN.Text);
            formBusKeeperDetailsUpdate.Show();
            this.Close();
        }

        private void guna2GradientButtonViewRouteDetails_Click(object sender, EventArgs e)
        {
            FormRouteList formRouteList = new FormRouteList(guna2TextBoxBKUN.Text);
            formRouteList.Show();
            this.Close();
        }

        private void guna2GradientButtonAddNewRoute_Click(object sender, EventArgs e)
        {
            FormAddNewRoute formAddNewRoute = new FormAddNewRoute(guna2TextBoxBKUN.Text);
            formAddNewRoute.Show();
            this.Close();
        }

        private void guna2GradientButtonViewBusTimeTable_Click(object sender, EventArgs e)
        {
            FormViewTimeTable formViewTimeTable = new FormViewTimeTable(guna2TextBoxBKUN.Text);
            formViewTimeTable.Show();
            this.Close();
        }

        private void guna2GradientButtonApdateTimeTable_Click(object sender, EventArgs e)
        {
            FormUpdateTimeTable formUpdateTimeTable = new FormUpdateTimeTable(guna2TextBoxBKUN.Text);
            formUpdateTimeTable.Show();
            this.Close();
        }
    }
        
}
/* private void guna2ButtonOkPDB_Click(object sender, EventArgs e)
       {
           try
           {

                DB_Connection dB_Connection = new DB_Connection();


                 string sql = "SELECT * FROM Bus_Keeper WHERE BusKeeperPassword = '@busKeeperPw' ";
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
                             guna2HtmlLabel_BK_FN.Text = dataReader["BusKeeperFirstName"].ToString();
                             guna2HtmlLabel_BK_LN.Text = dataReader["BusKeeperLastName"].ToString();
                             guna2HtmlLabel_BK_Id.Text = dataReader["BusKeeperID"].ToString();
                             guna2HtmlLabel_BK_BusStand.Text = dataReader["BusStandName"].ToString();
                             guna2HtmlLabel_BK_WPN.Text = dataReader["BusKeeperWhatsApp"].ToString();
                             guna2HtmlLabel_BK_email.Text = dataReader["BusKeeperEmail"].ToString();


                          }
                         guna2HtmlLabelBusKeeperDetails.Hide();
                         guna2HtmlLabelBusKeeperDetails2.Show();
                         guna2PanelLableDisplay.Show();
                         guna2HtmlLabelBusKeeperPW.Hide();
                         guna2TextBoxEnterBusKeeperPW.Hide();
                         guna2ButtonOkPDB.Hide();
                         guna2TextBoxEnterBusKeeperPW.Clear();
                         guna2HtmlLabelErrorMessage.Hide();
                     }
                     else
                     {
                         guna2HtmlLabelErrorMessage.Show();
                         guna2TextBoxEnterBusKeeperPW.Clear();

                     }

                 }


           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.Message);

           } 
       }*/
