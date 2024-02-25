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
    public partial class FormBusKeeperDetailsUpdate : Form
    {
        public FormBusKeeperDetailsUpdate()
        {
            InitializeComponent();
           
           
        }
        public FormBusKeeperDetailsUpdate(string BusKeeperUN)
        {
            InitializeComponent();
            textBoxBKUN.Text = BusKeeperUN;
            guna2ButtonOk.Hide();
            guna2HtmlLabelSucUpdateMess.Hide();
            textBoxBKUN.Hide();
        }



        private void guna2ButtonSubmitBK_Click(object sender, EventArgs e)
        {
            try
            {
                DB_Connection dB_Connection = new DB_Connection();

                string sql = "UPDATE Bus_Keeper SET  BusKeeperFirstName = '" + textBox_BK_FirstName.Text + "' , BusKeeperLastName = '" + textBox_BK_LastName.Text + "' , BusStandName = '" + textBoxBustandName.Text + "' , BusKeeperEmail = '" + textBox_BK_Email.Text + "',BusKeeperWhatsApp = '" + textBox_BK_wpNo.Text + "' WHERE BusKeeperID = '" + textBoxBKUN.Text + "' ";
                SqlCommand sqlCommand = new SqlCommand(sql, dB_Connection.GetSqlConnection());
                sqlCommand.ExecuteNonQuery();

                guna2HtmlLabelSucUpdateMess.Show();
                guna2ButtonOk.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void guna2ButtonOk_Click(object sender, EventArgs e)
        {
            FormBusKeeperDashboard formBusKeeperDashboard = new FormBusKeeperDashboard(textBoxBKUN.Text);
            formBusKeeperDashboard.ShowDialog();
            this.Close();
        }

        private void FormBusKeeperDetailsUpdate_Load(object sender, EventArgs e)
        {
            textBoxBKUN.Hide();
            // guna2ShadowPanelBusKeeperDetails.Show();

            try
            {
                DB_Connection dB_Connection = new DB_Connection();

                string sql = "SELECT * FROM Bus_Keeper WHERE BusKeeperID = '" + textBoxBKUN.Text + "' ";
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
                            textBox_BK_FirstName.Text = dataReader["BusKeeperFirstName"].ToString();
                            textBox_BK_LastName.Text = dataReader["BusKeeperLastName"].ToString();
                            textBox_BK_Id.Text = dataReader["BusKeeperID"].ToString();
                            textBoxBustandName.Text = dataReader["BusStandName"].ToString();
                            textBox_BK_wpNo.Text = dataReader["BusKeeperWhatsApp"].ToString();
                            textBox_BK_Email.Text = dataReader["BusKeeperEmail"].ToString();
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
