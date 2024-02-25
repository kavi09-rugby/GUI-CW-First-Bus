using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_CW
{
    public partial class FormBusSingin : Form
    {
        public FormBusSingin()
        {
            InitializeComponent();
            pictureBoxPwHide.Hide();
            pictureBoxCpwHide.Hide();
            guna2HtmlLabelCPWWrong.Hide();
            guna2HtmlLabelSucRegMess.Hide();
            guna2ButtonOk.Hide();
            guna2HtmlLabeldataEnterMessage.Hide();
        }

       
        //pw hide
        private void pictureBoxPwShow_Click(object sender, EventArgs e)
        {
            textBoxBusPw.UseSystemPasswordChar = false;
            pictureBoxPwHide.Show();
            pictureBoxPwShow.Hide();
        }

        private void pictureBoxPwHide_Click(object sender, EventArgs e)
        {
            textBoxBusPw.UseSystemPasswordChar = true;
            pictureBoxPwHide.Hide();
            pictureBoxPwShow.Show();
        }

        private void pictureBoxCpwHide_Click(object sender, EventArgs e)
        {
            guna2TextBoxBcpw.UseSystemPasswordChar = true;
            pictureBoxCpwHide.Hide();
            pictureBoxCpwShow.Show();
        }

        private void pictureBoxCpwShow_Click(object sender, EventArgs e)
        {
            guna2TextBoxBcpw.UseSystemPasswordChar = false;
            pictureBoxCpwHide.Show();   
            pictureBoxCpwShow.Hide();
        }
        //exit
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //home
        private void pictureBoxHomeIcon_Click(object sender, EventArgs e)
        {
            FormWelcome formWelcome = new FormWelcome();
            this.Close();
            formWelcome.Show();
        }
        //goto login
        private void linkLabelLoginAlert_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormBusLogin formBusLogin = new FormBusLogin();
            formBusLogin.Show();
            this.Hide();
        }
        //save details
        private void buttonPSubmit_Click(object sender, EventArgs e)
        {

        }

        private void guna2ButtonSubmitBus_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxBusRegNum.Text != string.Empty && textBoxBusName.Text != string.Empty && textBoxBusPw.Text != string.Empty && textBoxBusWpNo.Text != string.Empty && textBox_B_RouteNo.Text != string.Empty )
                {
                    DB_Connection dB_Connection = new DB_Connection();


                    if (textBoxBusPw.Text == guna2TextBoxBcpw.Text)
                    {
                        string sql = " INSERT INTO Bus(BusRegisterNumber,BusName,BusType,BusPassword,BusWhatsApp,RouteNumber) VALUES  ( '" + textBoxBusRegNum.Text + "','" + textBoxBusName.Text + "', @BusType ,'" + textBoxBusPw.Text + "','" + textBoxBusWpNo.Text + "','" + textBox_B_RouteNo.Text + "') ";
                        SqlCommand sqlCommand = new SqlCommand(sql, dB_Connection.GetSqlConnection());
                        sqlCommand.Parameters.AddWithValue("@BusType", comboBoxBusType.SelectedItem);
                        sqlCommand.ExecuteNonQuery();

                        guna2TextBoxBcpw.BorderColor = Color.DimGray;
                        guna2HtmlLabelCPWWrong.Hide();
                        guna2HtmlLabelSucRegMess.Show();
                        guna2ButtonOk.Show();
                        guna2HtmlLabeldataEnterMessage.Hide();


                    }
                    else
                    {
                        guna2HtmlLabelCPWWrong.Show();
                        guna2TextBoxBcpw.Clear();
                        guna2TextBoxBcpw.BorderColor = Color.Red;
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
        //data ok
        private void guna2ButtonOk_Click(object sender, EventArgs e)
        {
            textBoxBusRegNum.Clear(); textBoxBusName.Clear(); textBoxBusPw.Clear(); textBoxBusWpNo.Clear(); textBox_B_RouteNo.Clear(); guna2TextBoxBcpw.Clear();
            FormWelcome formWelcome = new FormWelcome();
            formWelcome.ShowDialog();
            this.Close();
        }
        ///validating
        private void textBoxBusName_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxBusName.Text == string.Empty)
            {
                e.Cancel = true;
                errorProvider_B_Name.SetError(textBoxBusName, "Please enter Discount Rate");
            }
            else
            {
                e.Cancel = false;
                errorProvider_B_Name.Clear();
            }
        }

        private void textBoxBusRegNum_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxBusRegNum.Text == string.Empty)
            {
                e.Cancel = true;
                errorProvider_B_RN.SetError(textBoxBusRegNum, "Please enter Discount Rate");
            }
            else
            {
                e.Cancel = false;
                errorProvider_B_RN.Clear();
            }
        }

        private void textBox_B_RouteNo_Validating(object sender, CancelEventArgs e)
        {
            if (textBox_B_RouteNo.Text == string.Empty)
            {
                e.Cancel = true;
                errorProvider_B_Rou_No.SetError(textBox_B_RouteNo, "Please enter Discount Rate");
            }
            else
            {
                e.Cancel = false;
                errorProvider_B_Rou_No.Clear();
            }
        }

        private void textBoxBusWpNo_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxBusWpNo.Text == string.Empty)
            {
                e.Cancel = true;
                errorProvider_B_WP.SetError(textBoxBusWpNo, "Please enter Discount Rate");
            }
            else
            {
                e.Cancel = false;
                errorProvider_B_WP.Clear();
            }
        }

        private void textBoxBusPw_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxBusPw.Text == string.Empty)
            {
                e.Cancel = true;
                errorProvider_B_PW.SetError(textBoxBusPw, "Please enter Discount Rate");
            }
            else
            {
                e.Cancel = false;
                errorProvider_B_PW.Clear();
            }
        }

        private void guna2TextBoxBcpw_Validating(object sender, CancelEventArgs e)
        {
            if (guna2TextBoxBcpw.Text == string.Empty)
            {
                e.Cancel = true;
                errorProvider_B_CPW.SetError(guna2TextBoxBcpw, "Please enter Discount Rate");
            }
            else
            {
                e.Cancel = false;
                errorProvider_B_CPW.Clear();
            }
        }
    }
}
