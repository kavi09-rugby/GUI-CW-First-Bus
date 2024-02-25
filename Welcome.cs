using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_CW
{
    public partial class FormWelcome : Form
    {
       


        public FormWelcome()
        {
            InitializeComponent();
            CostomizeDesign();
            
        }
  
        //// hide menu bars
        private void CostomizeDesign()
        {
            guna2ShadowPanelRegistr.Visible = false;
            panelSideMenuBar.Visible = false;
        }

        private void HideRegisterMenu()
        { 
            if(guna2ShadowPanelRegistr.Visible == true)
                guna2ShadowPanelRegistr.Visible = false;
        }

        private void ShowRegisterMenu(Panel RegisterSubMenu)
        {
            if(guna2ShadowPanelRegistr.Visible == false)
            {
                HideRegisterMenu();
                RegisterSubMenu.Visible = true;
            }
            else
                RegisterSubMenu.Visible = false;
        }
       
        private void guna2GradientButtonRegister_Click(object sender, EventArgs e)
        {
            ShowRegisterMenu(guna2ShadowPanelRegistr);
        }


        //register button
        private void guna2GradientButtonBusR_Click(object sender, EventArgs e)
        {
            FormBusSingin formBusSingin = new FormBusSingin();
            formBusSingin.Show();
            this.Hide();
            HideRegisterMenu();
        }

        private void guna2GradientButtonBusKeepeR_Click(object sender, EventArgs e)
        {
            FormBusKeeperSingin formBusKeeperSingin = new FormBusKeeperSingin();
            formBusKeeperSingin.Show();
            this.Hide();
            HideRegisterMenu();
        }

        private void guna2GradientButtonPassengerR_Click(object sender, EventArgs e)
        {

            FormPassengerSingin formPassengerSingin = new FormPassengerSingin();
            formPassengerSingin.Show();
            this.Close();
            HideRegisterMenu();
        }
        
        // hide side bar
        private void HideSideMenuBar()
        {
            if (panelSideMenuBar.Visible == true)
                panelSideMenuBar.Visible = false;
        }

        private void ShowSideMenuBar(Panel sideSubMenuBar)
        {
            if (panelSideMenuBar.Visible == false)
            {
                HideSideMenuBar();
                sideSubMenuBar.Visible = true;
            }
            else
                sideSubMenuBar.Visible = false;
        }


        private void guna2GradientButtonLogin_Click(object sender, EventArgs e)
        {
            ShowSideMenuBar(panelSideMenuBar);
        }

        //login
        private void guna2GradientButtonBisKeeper_Click(object sender, EventArgs e)
        {
            FormBusKeeperLogin formBusKeeper = new FormBusKeeperLogin();
            formBusKeeper.ShowDialog();
            this.Hide();
        }

        private void guna2GradientButtonBus_Click(object sender, EventArgs e)
        {
            FormBusLogin formBus = new FormBusLogin();
            formBus.ShowDialog();
            this.Hide();
        }

        private void guna2GradientButtonPassenger_Click(object sender, EventArgs e)
        {
            FormPassengerLogin formPassengerLogin = new FormPassengerLogin();
            formPassengerLogin.ShowDialog();
            this.Hide();
        }
        //exit
        private void guna2GradientButtonExiExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
