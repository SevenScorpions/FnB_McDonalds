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
using LogInDemo.DTO;
namespace LogInDemo
{
    public partial class changePassFrm : Form
    {
        public User user;
        public changePassFrm(User user)
        {
            InitializeComponent();
            this.user = user;
        }
        bool check()
        {
            if(newPassWord.Text.Length<8)
            {
                MessageBox.Show("Password must be longer than 8 characters");
                return false;
            }
            if (newPassWord.Text!=newRePassWord.Text)
            {
                MessageBox.Show("Re-Password does not match.");
                return false;
            }
            if (oldPassword.Text!=user.Password)
            {
                MessageBox.Show("Wrong password.");
                return false;
            }
            return true;
        }
        private void acceptBttn_Click(object sender, EventArgs e)
        {
            if (check())
            {
                user.Password = newPassWord.Text;
                UserDAO.Instance.Update(user);
                MessageBox.Show("Change password successfully");
                this.Close();
            }
        }

        private void cancelBttn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
