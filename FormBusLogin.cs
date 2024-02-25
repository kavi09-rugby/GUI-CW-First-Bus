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
    public partial class FormBusLogin : Form
    {
        public FormBusLogin()
        {
            InitializeComponent();
            pictureBoxPWHide.Hide();
            guna2HtmlLabelwarningMessage.Hide();
        }
       
       
        //pw hide
        private void pictureBoxPWShow_Click(object sender, EventArgs e)
        {
            textBoxPasswordBusLogin.UseSystemPasswordChar = false;
            pictureBoxPWHide.Show();
            pictureBoxPWShow.Hide();

        }

        private void pictureBoxPWHide_Click(object sender, EventArgs e)
        {
            textBoxPasswordBusLogin.UseSystemPasswordChar = true;
            pictureBoxPWHide.Hide();
            pictureBoxPWShow.Show();

        }

        private void pictureBoxHomeIcon_Click(object sender, EventArgs e)
        {
            FormWelcome formWelcome = new FormWelcome();
            this.Close();
            formWelcome.Show();
        }
        //go to bus singin
        private void linkLabelRegiterAlert_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormBusSingin formBusSingin = new FormBusSingin();
            formBusSingin.Show();
            this.Close();
        }
        //////To move dashboarsd/////////////////////////////////////////////////////////////
        private void buttonLoginBus_Click(object sender, EventArgs e)
        {
            try
            {
                guna2HtmlLabelwarningMessage.Hide();
                DB_Connection dB_Connection = new DB_Connection();
                string sql = "SELECT * FROM Bus WHERE BusRegisterNumber = '" + textBoxUserNameBusLogin.Text + "' AND BusPassword = '" + textBoxPasswordBusLogin.Text + "' ";

                SqlCommand cmd = new SqlCommand(sql, dB_Connection.GetSqlConnection());
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    FormBusDashboard formBusDashboard = new FormBusDashboard(textBoxUserNameBusLogin.Text);
                    formBusDashboard.Show();
                    this.Hide();
                }
                else
                {
                    guna2HtmlLabelwarningMessage.Show();
                    textBoxPasswordBusLogin.Clear();
                    textBoxUserNameBusLogin.Clear();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //validating
        private void textBoxUserNameBusLogin_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxUserNameBusLogin.Text == string.Empty)
            {
                e.Cancel = true;
                errorProviderBusUserName.SetError(textBoxUserNameBusLogin, "Please enter user name");
            }
            else
            {
                e.Cancel = false;
                errorProviderBusUserName.Clear();
            }

        }

        private void textBoxPasswordBusLogin_Validating(object sender, CancelEventArgs e)
        {

            if (textBoxPasswordBusLogin.Text == string.Empty)
            {
                e.Cancel = true;
                errorProviderBusPW.SetError(textBoxPasswordBusLogin, "Please enter password");
            }
            else
            {
                e.Cancel = false;
                errorProviderBusPW.Clear();
            }
        }
    }
}
