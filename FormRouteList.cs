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
    public partial class FormRouteList : Form
    {
        public FormRouteList(string BKUN)
        {
            InitializeComponent();
            guna2TextBoxBKUN.Text = BKUN;
            guna2TextBoxBKUN.Hide();

            guna2GradientPanelDeletRouteIF.Hide();
            labelDeleteRoute.Hide();
            guna2HtmlLabelSuccsesMessge.Hide();
            guna2GradientButtonOk.Hide();
            panelDelete.Hide();
            guna2TextBoxBKUN.Hide();
        }

        private void FormRouteList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'first_BusDataSet7.Bus_Routes' table. You can move, or remove it, as needed.
            this.bus_RoutesTableAdapter1.Fill(this.first_BusDataSet7.Bus_Routes);

        }

      

        private void guna2GradientButtonBack_Click(object sender, EventArgs e)
        {
            FormBusKeeperDashboard formBusKeeperDashboard = new FormBusKeeperDashboard(guna2TextBoxBKUN.Text);
            formBusKeeperDashboard.ShowDialog();
            this.Close();
        }

        private void guna2GradientButtonDeletRout_Click(object sender, EventArgs e)
        {
            guna2GradientPanelDeletRouteIF.Show();
            labelDeleteRoute.Show();
            labelBusRouteViwe.Hide();
        }

     
    }
}
