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
    public partial class FormBusKeeperLogin : Form
    {
        
        public FormBusKeeperLogin()
        {
            InitializeComponent();
            //when page loard
            pictureBoxPWHide.Hide();
            guna2HtmlLabelwarningMessage.Hide();
            
        }
        //exit
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();   
        }
        //goto home
        private void pictureBoxHomeIcon_Click(object sender, EventArgs e)
        {
            FormWelcome formWelcome = new FormWelcome();
            this.Close();
            formWelcome.Show();
        }
        //pw hide
        private void pictureBoxPWShow_Click(object sender, EventArgs e)
        {
            textBoxPasswordBusKeeperLogin.UseSystemPasswordChar = false;
            pictureBoxPWHide.Show();
            pictureBoxPWShow.Hide();

        }
        private void pictureBoxPWHide_Click(object sender, EventArgs e)
        {
            textBoxPasswordBusKeeperLogin.UseSystemPasswordChar = true;
            pictureBoxPWHide.Hide();
            pictureBoxPWShow.Show();
        }

        //libk to register form
        private void linkLabelRegiterAlert_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormBusKeeperSingin formBusKeeperSingin = new FormBusKeeperSingin();
            formBusKeeperSingin.Show();
            this.Close();
        }

        //login to bus leeper form
       private void buttonLoginBusKeeper_Click(object sender, EventArgs e)
        {
            try
            {
                guna2HtmlLabelwarningMessage.Hide();
                DB_Connection dB_Connection = new DB_Connection();

                string sql = "SELECT * FROM Bus_Keeper WHERE BusKeeperID = '" + textBoxUserNameBusKeeperLogin.Text.Trim() + "' AND BusKeeperPassword = '" + textBoxPasswordBusKeeperLogin.Text.Trim() + "' ";

                SqlCommand cmd = new SqlCommand(sql, dB_Connection.GetSqlConnection());
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {


                    FormBusKeeperDashboard formBusKeeperDashboard = new FormBusKeeperDashboard(textBoxUserNameBusKeeperLogin.Text);
                    FormBusKeeperDetailsUpdate formBusKeeperDetailsUpdate = new FormBusKeeperDetailsUpdate(textBoxUserNameBusKeeperLogin.Text);
                    formBusKeeperDashboard.Show();
                    this.Hide();
                }
                else
                {
                    guna2HtmlLabelwarningMessage.Show();
                    textBoxPasswordBusKeeperLogin.Clear();
                    textBoxUserNameBusKeeperLogin.Clear();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //validating
        private void textBoxUserNameBusKeeperLogin_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (textBoxUserNameBusKeeperLogin.Text == string.Empty)
                {
                    e.Cancel = true;
                    errorProvider_BK_UN.SetError(textBoxUserNameBusKeeperLogin, "Please enter user name");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider_BK_UN.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxPasswordBusKeeperLogin_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (textBoxPasswordBusKeeperLogin.Text == string.Empty)
                {
                    e.Cancel = true;
                    errorProvider_BK_P.SetError(textBoxPasswordBusKeeperLogin, "Please enter user name");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider_BK_P.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
