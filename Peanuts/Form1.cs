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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        LoginClass lc = new LoginClass();


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "" || txtLastName.Text == "" || txtContact.Text == "" || txtAddress.Text == "" || txtEmail.Text == "" || txtUsername.Text == "" || txtPassword.Text == "" || txtConfirmPass.Text == "")
            {
                MessageBox.Show("Please fill mandatory fields");
            }
            else if (txtPassword.Text != txtConfirmPass.Text)
            {
                MessageBox.Show("Passwords dont match");
            }
            else
            {
                lc.FirstName = txtFirstName.Text;
                lc.LastName = txtLastName.Text;
                lc.Contact = txtContact.Text;
                lc.Address = txtAddress.Text;
                lc.Email = txtEmail.Text;
                lc.Username = txtUsername.Text;
                lc.Password = txtPassword.Text;

                bool success = lc.Insert(lc);

                if (success == true)
                {
                    const string message = "New User Successfully Inserted";
                    const string caption = "New User";
                    var result = MessageBox.Show(message, caption, MessageBoxButtons.OK);
                    if(result == DialogResult.OK)
                    {
                        Clear();//Insert Clear Method here
                        Home hme = new Home();
                        hme.Show();
                        this.Hide();
                      
                    }
                    else
                    {
                        this.Close();
                    }
                }
                else
                {
                    //failed to add new user
                    MessageBox.Show("Failed to add new User. Please try again");
                }

            }
        }

        private void Clear()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtContact.Text = "";
            txtAddress.Text = "";
            txtEmail.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
        }
    }
}
