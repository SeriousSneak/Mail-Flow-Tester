using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics; //needed for "Process.Start"

namespace EmailTests
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void buttonAboutClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start(@"\\tkfiltoolbox\tools\mailflowtester\release\Mail Flow Tester read me.docx");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message + ". Ensure you are connected to corpnet.", "Error (╯°□°)╯︵ ┻━┻", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
