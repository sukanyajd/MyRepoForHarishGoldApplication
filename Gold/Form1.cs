using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gold
{
    public partial class Form1 : Form
    {
        public int LoginUserId;
        public Form1()
        {
            InitializeComponent();
            lblMacAddressData.Text = GetMACAddress();
        }

        public string GetMACAddress()
        {
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            String sMacAddress = string.Empty;
            foreach (NetworkInterface adapter in nics)
            {
                if (sMacAddress == String.Empty)// only return MAC Address from first card  
                {
                    IPInterfaceProperties properties = adapter.GetIPProperties();
                    sMacAddress = adapter.GetPhysicalAddress().ToString();
                }
            }
            return sMacAddress;
        }
        private void submit_Click(object sender, EventArgs e)
        {
            BAL objBAL = new BAL();
            int authenticationCheck = objBAL.loginAuthentication(txtLoginName.Text, txtLoginPwd.Text, GetMACAddress());
            if (authenticationCheck == 0)
            {
                LoginMessageBox mb = new LoginMessageBox();
                mb.lblMessageData.Text = "Authentication Failed";
                mb.Show();
            }
            else
            {
                if (authenticationCheck != 1)
                {
                    LoginMessageBox mb = new LoginMessageBox();
                    mb.lblMessageData.Text = "Will expire in " + authenticationCheck + " days";
                    mb.ShowDialog();
                }
                txtLoginName.Text = string.Empty;
                txtLoginPwd.Text = string.Empty;
                this.Hide();
                LandingPage objLandingPage = new LandingPage();
                objLandingPage.ShowDialog();
                this.Close();
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchLoan objCloseLoan = new SearchLoan();
            objCloseLoan.ShowDialog();
            this.Close();
        }

    }
}
