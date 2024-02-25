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
    public partial class FormPassengerLogin : Form
    {
        public FormPassengerLogin()
        {
            InitializeComponent();
            pictureBoxPWHidePassenger.Hide();
            guna2HtmlLabelwarningMessage.Hide();
        }
        //Exit
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        
        ////Password Hide
        private void pictureBoxPWShowPassengwe_Click(object sender, EventArgs e)
        {

            textBoxPasswordPassengerLogin.UseSystemPasswordChar = false;
            pictureBoxPWShowPassengwe.Hide();
            pictureBoxPWHidePassenger.Show();
        }

        private void pictureBoxPWHidePassenger_Click(object sender, EventArgs e)
        {
            textBoxPasswordPassengerLogin.UseSystemPasswordChar = true;
            pictureBoxPWShowPassengwe.Show();
            pictureBoxPWHidePassenger.Hide();
        }


        private void pictureBoxHome_P_Log_Click(object sender, EventArgs e)
        {
                FormWelcome formWelcome = new FormWelcome();
                this.Close();
                formWelcome.Show();
            
        }

        private void linkLabelRegiterAlert_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormPassengerSingin formPassengerSingin = new FormPassengerSingin();
            formPassengerSingin.Show();
            this.Hide();
        }

        ////To move dashboarsd
        private void buttonLoginPassenger_Click(object sender, EventArgs e)
        {
            try
            {
                guna2HtmlLabelwarningMessage.Hide();
                DB_Connection dB_Connection = new DB_Connection();

                string sql = "SELECT * FROM Passenger WHERE PassengerEmail = '" + textBoxUserNamePassengerLogin.Text.Trim() + "' AND PassengerPassword = '" + textBoxPasswordPassengerLogin.Text.Trim() + "' ";

                SqlCommand cmd = new SqlCommand(sql, dB_Connection.GetSqlConnection());
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {


                    FormPassengerDashBoard formPassengerDashBoard = new FormPassengerDashBoard(textBoxUserNamePassengerLogin.Text);
                    formPassengerDashBoard.Show();
                    this.Hide();
                }
                else
                {
                    guna2HtmlLabelwarningMessage.Show();
                    textBoxUserNamePassengerLogin.Clear();
                    textBoxPasswordPassengerLogin.Clear();

                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
          

        }

        //login validating
        private void textBoxUserNamePassengerLogin_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (textBoxUserNamePassengerLogin.Text == string.Empty)
                {
                    e.Cancel = true;
                    errorProvider_P_userName.SetError(textBoxUserNamePassengerLogin, "Please enter user name");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider_P_userName.Clear();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
           
            
        }

        private void textBoxPasswordPassengerLogin_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (textBoxPasswordPassengerLogin.Text == string.Empty)
                {
                    e.Cancel = true;
                    errorProvider_P_Password.SetError(textBoxPasswordPassengerLogin, "Please enter user name");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider_P_Password.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

       /* public string GetPassengerPassword()
        {
            
           return textBoxPasswordPassengerLogin.Text;

        }*/
    }
}
