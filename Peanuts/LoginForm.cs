using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Peanuts
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        LoginForm lf = new LoginForm();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUname.Text == "" || txtUname.Text == "")
            {
                MessageBox.Show("Please fill in mandatory fields");
            }
            else
            {
                lf.txtUname = 
                lf.txtPword
            }
        }
    }
}
