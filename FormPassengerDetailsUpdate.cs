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
    public partial class FormPassengerDetailsUpdate : Form
    {
        public FormPassengerDetailsUpdate(string PUN)
        {
            InitializeComponent();
            textBoxPUN.Text = PUN;
            guna2ButtonOk.Hide();
            guna2HtmlLabelSucUpdateMess.Hide();
            textBoxPUN.Hide();
        }

        private void guna2ButtonSubmitPass_Click(object sender, EventArgs e)
        {
            try
            {
                DB_Connection dB_Connection = new DB_Connection();

                string sql = "UPDATE Passenger SET  PassengerFirstName = '" + textBoxPFirstName.Text + "' , PassengerLastName = '" + textBoxPLastName.Text + "' , PassengerWhatsApp = '" + textBoxPwpNo.Text + "' , PassengerStreet = '" + textBoxPAddresLin1.Text + "',PassengerCity = '" + textBoxPAddressLine2.Text + "' WHERE PassengerEmail = '" + textBoxPUN.Text + "' ";
                SqlCommand sqlCommand = new SqlCommand(sql, dB_Connection.GetSqlConnection());
                sqlCommand.ExecuteNonQuery();

                guna2HtmlLabelSucUpdateMess.Show();
                guna2ButtonOk.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2ButtonOk_Click(object sender, EventArgs e)
        {
            FormPassengerDashBoard formPassengerDashBoard = new FormPassengerDashBoard(textBoxPUN.Text);
            formPassengerDashBoard.Show();
            this.Close();
        }

        private void FormPassengerDetailsUpdate_Load(object sender, EventArgs e)
        {
            try
            {
                DB_Connection dB_Connection = new DB_Connection();
                // guna2ShadowPanelBusKeeperDetails.Show();

                string sql = "SELECT * FROM Passenger WHERE PassengerEmail = '" + textBoxPUN.Text + "' ";
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
                            textBoxPFirstName.Text = dataReader["PassengerFirstName"].ToString();
                            textBoxPLastName.Text = dataReader["PassengerLastName"].ToString();
                            textBoxPwpNo.Text = dataReader["PassengerWhatsApp"].ToString();
                            textBoxPAddresLin1.Text = dataReader["PassengerStreet"].ToString();
                            textBoxPAddressLine2.Text = dataReader["PassengerCity"].ToString();
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void labelPassengerLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
