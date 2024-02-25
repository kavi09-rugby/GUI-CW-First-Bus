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
using Guna.UI2.WinForms;

namespace GUI_CW
{
    public partial class FormPassengerSingin : Form
    {
        public FormPassengerSingin()
        {
            InitializeComponent();

            custermize();
        }

        private void custermize()
        {
            pictureBoxPwHide.Hide();
            pictureBoxCpwHide.Hide();
            guna2HtmlLabelCPWWrong.Hide();
            guna2HtmlLabelSucRegMess.Hide();
            guna2ButtonOk.Hide();
            guna2HtmlLabeldataEnterMessage.Hide();
        }

       
        //pw hide
        private void pictureBoxPWShow_Click(object sender, EventArgs e)
        {
            textBoxPpw.UseSystemPasswordChar = false;
            pictureBoxPwShow.Hide();
            pictureBoxPwHide.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            textBoxPpw.UseSystemPasswordChar = true;
            pictureBoxPwShow.Show();
            pictureBoxPwHide.Hide();
        }

        private void pictureBoxPWHidePassenger_Click(object sender, EventArgs e)
        {
            guna2TextBoxPcpw.UseSystemPasswordChar = true;
            pictureBoxCpwHide.Hide();
            pictureBoxCpwShow.Show();
        }

        private void pictureBoxCpwShow_Click_1(object sender, EventArgs e)
        {
            guna2TextBoxPcpw.UseSystemPasswordChar = false;
            pictureBoxCpwShow.Hide();
            pictureBoxCpwHide.Show();
        }
        //home
        private void pictureBoxHome_P_Log_Click(object sender, EventArgs e)
        {
            FormWelcome formWelcome = new FormWelcome();
            this.Close();
            formWelcome.Show();

        }
        
       
        //goto login
        private void linkLabelLoginAlert_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormPassengerLogin formPassengerLogin = new FormPassengerLogin();
            formPassengerLogin.Show();
            this.Close();
        }
        //data submit
        private void guna2ButtonSubmitPassenger_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxPFirstName.Text != string.Empty && textBoxPLastName.Text != string.Empty && textBoxPEmail.Text != string.Empty && textBoxPAddresLin1.Text != string.Empty && textBoxPAddressLine2.Text != string.Empty && textBoxPwpNo.Text != string.Empty && textBoxPpw.Text != string.Empty)
                {
                    DB_Connection dB_Connection = new DB_Connection();


                    if (textBoxPpw.Text == guna2TextBoxPcpw.Text)
                    {
                        string sql = " INSERT INTO Passenger(PassengerEmail,PassengerFirstName,PassengerLastName,PassengerGender,PassengerWhatsApp,PassengerPassword,PassengerStreet,PassengerCity) VALUES  ( '" + textBoxPEmail.Text + "','" + textBoxPFirstName.Text + "','" + textBoxPLastName.Text + "', @gender ,'" + textBoxPwpNo.Text + "','" + textBoxPpw.Text + "','" + textBoxPAddresLin1.Text + "','" + textBoxPAddressLine2.Text + "') ";
                        SqlCommand sqlCommand = new SqlCommand(sql, dB_Connection.GetSqlConnection());
                        sqlCommand.Parameters.AddWithValue("@gender", comboBoxPGender.SelectedItem);
                        sqlCommand.ExecuteNonQuery();

                        guna2TextBoxPcpw.BorderColor = Color.DimGray;
                        guna2HtmlLabelCPWWrong.Hide();
                        guna2HtmlLabelSucRegMess.Show();
                        guna2ButtonOk.Show();
                        guna2HtmlLabeldataEnterMessage.Hide();


                    }
                    else
                    {
                        guna2HtmlLabelCPWWrong.Show();
                        guna2TextBoxPcpw.Clear();
                        guna2TextBoxPcpw.BorderColor = Color.Red;
                    }

                }
                else
                {
                    guna2HtmlLabeldataEnterMessage.Show();
                }


            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            
             
        }
        //data ok --> goto home page
        private void guna2ButtonOk_Click(object sender, EventArgs e)
        {
            textBoxPEmail.Clear(); textBoxPFirstName.Clear(); textBoxPLastName.Clear(); textBoxPwpNo.Clear(); textBoxPpw.Clear(); guna2TextBoxPcpw.Clear(); textBoxPAddresLin1.Clear(); textBoxPAddressLine2.Clear();
            FormWelcome formWelcome = new FormWelcome();
            formWelcome.ShowDialog();
            this.Close();
        }
        //validation
        private void textBoxPFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxPFirstName.Text == string.Empty)
            {
                e.Cancel = true;
                  }
            else
            {
                    e.Cancel = false;
                    errorProviderFN.Clear();
                
            }
        }

        private void textBoxPLastName_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxPLastName.Text == string.Empty)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
                errorProviderLN.Clear();
            }
        }

        private void textBoxPEmail_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxPEmail.Text == string.Empty)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
                errorProviderEmail.Clear();
            }
        }

        private void textBoxPAddresLin1_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxPAddresLin1.Text == string.Empty)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
                errorProvider1Add.Clear();
            }
        }

        private void textBoxPAddressLine2_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxPAddressLine2.Text == string.Empty)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
                errorProviderAdd2.Clear();
            }
        }

        private void textBoxPwpNo_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxPwpNo.Text == string.Empty)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
                errorProviderWP.Clear();
            }
        }

        private void textBoxPpw_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxPpw.Text == string.Empty)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
                errorProviderPW.Clear();
            }
        }

        private void guna2TextBoxPcpw_Validating(object sender, CancelEventArgs e)
        {
            if (guna2TextBoxPcpw.Text == string.Empty)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
                errorProviderCPW.Clear();
            }
        }

        private void FormPassengerSingin_Load(object sender, EventArgs e)
        {

        }
    }
}
