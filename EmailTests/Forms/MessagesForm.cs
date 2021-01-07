using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmailTests
{
    public partial class MessagesForm : Form
    {
        public MessagesForm(string errorMessage, string formTitle, string buttonText)
        {
            InitializeComponent();
            this.Text = formTitle;
            //buttonClose.Text = buttonText;
            textBoxErrorMessage.Text = errorMessage;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxErrorMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && (e.KeyCode == Keys.A || e.KeyCode == Keys.A))
            {
                textBoxErrorMessage.SelectAll();
            }
        }
    }
}
