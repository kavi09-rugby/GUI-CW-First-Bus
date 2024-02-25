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
    public partial class FormBusKeeperSingin : Form
    {
        public FormBusKeeperSingin()
        {
            InitializeComponent();
            pictureBoxPwHide.Hide();
            pictureBoxHideCpw.Hide();
            guna2HtmlLabelCPWWrong.Hide();
            guna2HtmlLabelSucRegMess.Hide();
            guna2ButtonOk.Hide();
            guna2HtmlLabeldataEnterMessage.Hide();

        }
        //login
        private void linkLabelLoginAlert_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormBusKeeperLogin formBusKeeper = new FormBusKeeperLogin();
            formBusKeeper.ShowDialog();
            this.Close();
        }
        //pw hide
        private void pictureBoxShowPw_Click(object sender, EventArgs e)
        {
            textBox_BK_pw.UseSystemPasswordChar = false;
            pictureBoxPwHide.Show();
            pictureBoxShowPw.Hide();
        }

        private void pictureBoxPwHide_Click(object sender, EventArgs e)
        {
            textBox_BK_pw.UseSystemPasswordChar = true;
            pictureBoxPwHide.Hide();
            pictureBoxShowPw.Show();
        }

        private void pictureBoxCpwShow_Click(object sender, EventArgs e)
        {
            guna2TextBoxBKcpw.UseSystemPasswordChar = false;
            pictureBoxCpwShow.Hide();
            pictureBoxHideCpw.Show();
        }

        private void pictureBoxHideCpw_Click(object sender, EventArgs e)
        {
            guna2TextBoxBKcpw.UseSystemPasswordChar = true;
            pictureBoxCpwShow.Show();
            pictureBoxHideCpw.Hide();
        }
        //home
        private void pictureBoxHomeIcon_Click(object sender, EventArgs e)
        {
            FormWelcome formWelcome = new FormWelcome();
            this.Close();
            formWelcome.Show();
        }
       
        
        //details ok
        private void guna2ButtonOk_Click(object sender, EventArgs e)
        {
            textBox_BK_Id.Clear(); textBox_BK_FirstName.Clear(); textBox_BK_LastName.Clear(); textBoxBustandName.Clear(); textBox_BK_Email.Clear(); textBox_BK_wpNo.Clear(); textBox_BK_pw.Clear(); guna2TextBoxBKcpw.Clear();
            FormWelcome formWelcome = new FormWelcome();
            formWelcome.ShowDialog();
            this.Close();
        }
        //validating
        private void textBox_BK_FirstName_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (textBox_BK_FirstName.Text == string.Empty)
                {
                    e.Cancel = true;
                    errorProviderFN.SetError(textBox_BK_FirstName, "Please enter Discount Rate");
                }
                else
                {
                    e.Cancel = false;
                    errorProviderFN.Clear();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void textBox_BK_LastName_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (textBox_BK_LastName.Text == string.Empty)
                {
                    e.Cancel = true;
                    errorProviderLN.SetError(textBox_BK_LastName, "Please enter Discount Rate");
                }
                else
                {
                    e.Cancel = false;
                    errorProviderLN.Clear();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void textBox_BK_Email_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (textBox_BK_Email.Text == string.Empty)
                {
                    e.Cancel = true;
                    errorProviderEmail.SetError(textBox_BK_Email, "Please enter Discount Rate");
                }
                else
                {
                    e.Cancel = false;
                    errorProviderEmail.Clear();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void textBox_BK_Id_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (textBox_BK_Id.Text == string.Empty)
                {
                    e.Cancel = true;
                    errorProviderID.SetError(textBox_BK_Id, "Please enter Discount Rate");
                }
                else
                {
                    e.Cancel = false;
                    errorProviderID.Clear();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void textBoxBustandName_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (textBoxBustandName.Text == string.Empty)
                {
                    e.Cancel = true;
                    errorProviderbustand.SetError(textBoxBustandName, "Please enter Discount Rate");
                }
                else
                {
                    e.Cancel = false;
                    errorProviderbustand.Clear();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void textBox_BK_wpNo_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (textBox_BK_wpNo.Text == string.Empty)
                {
                    e.Cancel = true;
                    errorProviderWP.SetError(textBox_BK_wpNo, "Please enter Discount Rate");
                }
                else
                {
                    e.Cancel = false;
                    errorProviderWP.Clear();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void textBox_BK_pw_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (textBox_BK_pw.Text == string.Empty)
                {
                    e.Cancel = true;
                    errorProviderPW.SetError(textBox_BK_pw, "Please enter Discount Rate");
                }
                else
                {
                    e.Cancel = false;
                    errorProviderPW.Clear();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void guna2TextBoxBKcpw_Validating(object sender, CancelEventArgs e)
        {
            try 
            {
                if (guna2TextBoxBKcpw.Text == string.Empty)
                {
                    e.Cancel = true;
                    errorProviderCPW.SetError(guna2TextBoxBKcpw, "Please enter Discount Rate");
                }
                else
                {
                    e.Cancel = false;
                    errorProviderCPW.Clear();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
        //data submit
        private void guna2ButtonSubmitPassenger_Click(object sender, EventArgs e)
        {

            try
            {
                if (textBox_BK_FirstName.Text != string.Empty && textBox_BK_LastName.Text != string.Empty && textBox_BK_Email.Text != string.Empty && textBox_BK_Id.Text != string.Empty && textBoxBustandName.Text != string.Empty && textBox_BK_wpNo.Text != string.Empty && textBox_BK_pw.Text != string.Empty)
                {
                    DB_Connection dB_Connection = new DB_Connection();


                    if (textBox_BK_pw.Text == guna2TextBoxBKcpw.Text)
                    {
                        string sql = " INSERT INTO Bus_Keeper(BusKeeperID,BusKeeperFirstName,BusKeeperLastName,BusKeeperPassword,BusStandName,BusKeeperEmail,BusKeeperWhatsApp) VALUES  ( '" + textBox_BK_Id.Text + "','" + textBox_BK_FirstName.Text + "','" + textBox_BK_LastName.Text + "','" + textBox_BK_pw.Text + "','" + textBoxBustandName.Text + "','" + textBox_BK_Email.Text + "','" + textBox_BK_wpNo.Text + "') ";
                        SqlCommand sqlCommand = new SqlCommand(sql, dB_Connection.GetSqlConnection());
                        sqlCommand.ExecuteNonQuery();

                        guna2TextBoxBKcpw.BorderColor = Color.DimGray;
                        guna2HtmlLabelCPWWrong.Hide();
                        guna2HtmlLabelSucRegMess.Show();
                        guna2ButtonOk.Show();
                        guna2HtmlLabeldataEnterMessage.Hide();


                    }
                    else
                    {
                        guna2HtmlLabelCPWWrong.Show();
                        guna2TextBoxBKcpw.Clear();
                        guna2TextBoxBKcpw.BorderColor = Color.Red;
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
    }
}
