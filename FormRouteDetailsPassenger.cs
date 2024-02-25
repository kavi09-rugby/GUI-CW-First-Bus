using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_CW
{
    public partial class FormRouteDetailsPassenger : Form
    {
        public FormRouteDetailsPassenger(string PUN)
        {
            InitializeComponent();
            tpun.Text = PUN;
            tpun.Hide();
        }


        private void guna2GradientButtonBack_Click(object sender, EventArgs e)
        {
            FormPassengerDashBoard formPassengerDashBoard = new FormPassengerDashBoard(tpun.Text);
            formPassengerDashBoard.ShowDialog();
            this.Close();
        }

        private void FormRouteDetailsPassenger_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'first_BusDataSet6.Bus_Routes' table. You can move, or remove it, as needed.
            this.bus_RoutesTableAdapter.Fill(this.first_BusDataSet6.Bus_Routes);

        }
    }
}
