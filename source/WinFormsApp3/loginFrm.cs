using LogInDemo.DAO;
using LogInDemo.DTO;
using System.Data;
using System.Data.SqlClient;
namespace LogInDemo
{
    public partial class loginFrm : Form
    {
        public loginFrm()
        {
            InitializeComponent();
        }

        private bool CheckError()
        {
            string temp = "";
            if (tbUserName.Text == "")
                temp += "Username is empty\n";
            if (tbPassWord.Text == "")
                temp += "Password is empty";
            if (temp == "")
            {
                return true;
            }
            else
            {
                MessageBox.Show(temp);
                return false;
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(CheckError())
            {
                User user = UserDAO.Instance.GetAccount(tbUserName.Text, tbPassWord.Text);
                if (user!=null)
                {
                    var frm = new mainFrm(user);
                    this.Hide();
                    frm.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Wrong password.\nPlease try again.");
                }
            }    
           
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void tbUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var frm = new signUpFrm();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var frm = new forgotPasswordFrm();
            frm.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            var window = MessageBox.Show("Do you want to exit?", "Exit?", MessageBoxButtons.OKCancel);
            if (window == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}