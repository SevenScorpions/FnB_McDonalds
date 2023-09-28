using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogInDemo.DAO;
using LogInDemo.Strategy;

namespace LogInDemo
{
    public partial class forgotPasswordFrm : Form
    {
        bool isEmail = false;
        StrategyValidator emailValidator = new EmailValidator();
        public forgotPasswordFrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isEmail = emailValidator.validate(tbEmail.Text);
            if(!isEmail)
            {
                MessageBox.Show("Not enough information.");
            }    
            else if(UserDAO.Instance.forgotPassword(fpUsername.Text,tbEmail.Text))
            {
                MessageBox.Show("Check your Email to change your password.");
                this.Close();
            }
            else
            {
                MessageBox.Show("This account is not exist.");
            }
        }

        private void phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
