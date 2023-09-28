using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogInDemo.DAO;
using LogInDemo.DTO;
using LogInDemo.Observer;
using Button = System.Windows.Forms.Button;

namespace LogInDemo
{
    public partial class buyTicketFrm : Form
    {
        public User user;
        public Session session;
        public Movie movie;
        private List<string> userTicketList;
        private List<string> sessionTicketList;
        private List<string> currentTicketList;

        private List<string> prices = new List<string>();
        
        private int h;
        private int w;

        private int totalPrice = 0;
        private string fid = "";
        public buyTicketFrm(User user,Session session,Movie movie)
        {
            InitializeComponent();

            this.user = user;
            this.session = session;
            this.movie = movie;
            this.userTicketList = new List<string>();
            this.sessionTicketList = new List<string>();
            this.currentTicketList = new List<string>();
            loadSessionInfor();

            foodPrice.Text = "0";
            cbPayment.SelectedIndex = 0;
            pickFood.SelectedIndex = 0;

            List<Food> foods = FoodDAO.Instance.GetAll();
            numFood.Text = "1";
            pickFood.DataSource = foods;
            pickFood.DisplayMember = "Name";
        }
        private string formatMoney(int p)
        {
            string str = "";
            if (p < 1000)
            {
                return p.ToString();
            }
            while (p > 0)
            {
                int thr = p % 1000;
                string s = p.ToString();
                if (p >= 1000)
                {
                    if (thr == 0)
                    {
                        s = "0" + "0" + "0";
                    }
                    else if (thr < 100 && thr >= 10)
                    {
                        s = "0" + s;
                    }
                    else if (thr < 10)
                    {
                        s = "0" + "0" + s;
                    }
                }
                p /= 1000;
                if (str != "")
                {
                    str = s + "," + str;
                }
                else
                {
                    str = s + str;
                }
            }
            return str;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void loadSessionInfor()
        {
            mPrice.Text = session.Price.ToString();
            mName.Text = movie.Name.ToString();
            mLen.Text = movie.Length.ToString();
            mSub.Text = session.Subtitle.ToString();
            mTime.Text = session.Date.TimeOfDay.ToString();
            mDate.Text = session.Date.Date.ToString("dd/MM/yyyy");
            mFormat.Text = session.Format.ToString();
            mTotal.Text = "0";
            mDir.Text = movie.Director.ToString();
            foreach (Ticket ticket in TicketDAO.Instance.getTicketListIn4(session.Id, user.Username))
            {
                userTicketList.Add(ticket.Chair);
            }
            foreach (Ticket ticket in TicketDAO.Instance.getTicketListFromSID(session.Id))
            {
                sessionTicketList.Add(ticket.Chair);
            }

        }
        private void loadTicket()
        {
            panel5.Hide();

            this.h = (int)((midFlw.Height - 16 * 6.3) / 16) + 1;
            this.w = (int)((midFlw.Width - 29 * 6.9) / 29) + 1;
            foreach (string chair in TicketDAO.Instance.getMiddleChairList())
            {
                Button bttn = new Button() { Width = this.w, Height = this.h };
                bttn.Click += Bttn_Click;
                bttn.Text = chair;
                if (userTicketList.Contains(chair))
                {
                    bttn.BackColor = Color.Yellow;
                    bttn.ForeColor = Color.Black;
                    bttn.Enabled = false;
                }
                else if (sessionTicketList.Contains(chair))
                {
                    bttn.BackColor = Color.DimGray;
                    bttn.ForeColor = Color.White;
                    bttn.Enabled = false;
                }
                else
                {
                    bttn.BackColor = Color.White;
                    bttn.ForeColor = Color.Black;
                }
                bttn.FlatStyle = FlatStyle.Flat;
                bttn.FlatAppearance.BorderSize = 0;
                bttn.TextAlign = ContentAlignment.MiddleLeft;
                bttn.Font = new Font("Century Gothic", 7);
                midFlw.Controls.Add(bttn);
            }
            panel5.Show();
        }
        private void loadTotal()
        {
            //total
            totalPrice = currentTicketList.Count * session.Price;
            //'mTotal.Text = (totalPrice + int.Parse(foodPrice.Text.Replace(",",""))).ToString();
            mTotal.Text = formatMoney(totalPrice + int.Parse(foodPrice.Text.Replace(",", "")));
            //mTotal.Text = (currentTicketList.Count*session.Price).ToString();
            if (currentTicketList.Count == 0)
            {
                buyTicketBttn.Enabled = false;
            }
            else { buyTicketBttn.Enabled = true; }
        }
        private void Bttn_Click(object? sender, EventArgs e)
        {
            Button bttn = sender as Button;
            if (bttn.ForeColor == Color.Black)
            {
                bttn.BackColor = Color.DarkCyan;
                bttn.ForeColor = Color.White;
                currentTicketList.Add(bttn.Text);
            }
            else if (bttn.ForeColor == Color.White)
            {
                bttn.BackColor = Color.White;
                bttn.ForeColor = Color.Black;
                currentTicketList.Remove(bttn.Text);
            }
            loadTotal();
        }

        private void cancelPurBttn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to cancel the order?", "", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
            }
            
        }

        private void buyTicketFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void buyTicketFrm_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void buyTicketBttn_Click(object sender, EventArgs e)
        {
            if(currentTicketList.Count==0)
            {
                MessageBox.Show("Choose your place first.");
                return;
            }
            if (cbPayment.SelectedItem == null)
            {
                MessageBox.Show("Choose your payment term.");
                return;
            }
            if (cbPayment.SelectedItem.ToString()=="" || cbPayment.SelectedItem.ToString() == "--Select payment--")
            {
                MessageBox.Show("Choose your payment term.");
                return;
            }
            if (MessageBox.Show("Buy the Ticket?", "", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                return;
            }
            string bid = generateBillID();
            totalPrice = int.Parse(mTotal.Text.Replace(",","").ToString());
            BillDAO.Instance.Insert(new Bill(bid, user.Username, session.Id, cbPayment.SelectedItem.ToString(), fid, totalPrice, DateTime.Today));
            foreach(string chair in currentTicketList)
            {
                TicketDAO.Instance.Insert(new Ticket(bid+chair,bid,chair));
            }
            int extraPoint;
            if (totalPrice > 500000)
            {
                extraPoint = 30;
            }
            else if(totalPrice > 300000)
            {
                extraPoint = 20;
            }
            else
            {
                extraPoint = 10;
            }
            user.Point += extraPoint;
            UserDAO.Instance.Update(user);
            MessageBox.Show("You got more "+ extraPoint+"\n"+"Your accumulate point is " + user.Point);
            MessageBox.Show("Purchase successfully.");
            this.Close();
        }
        private string generateBillID()
        {
            return session.Id + (BillDAO.Instance.getBillList(session.Id).Count + 1).ToString("00000");
        }

        private void unselectBttn_Click(object sender, EventArgs e)
        {
            midFlw.Controls.Clear();
            currentTicketList.Clear();
            loadTicket();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to cancel the order?", "", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (this.WindowState != FormWindowState.Maximized)
            {
                
                this.WindowState = FormWindowState.Maximized;
                
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void buyTicketFrm_StyleChanged(object sender, EventArgs e)
        {

        }

        private void pickFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Food> foods = FoodDAO.Instance.GetAll();
            foreach(Food food in foods)
            {
                if(food.Name==pickFood.Text)
                {
                    int pri = food.Price * int.Parse(numFood.Text);
                    foodPrice.Text = formatMoney(pri);
                    //'mTotal.Text = (totalPrice + pri).ToString();
                    mTotal.Text = formatMoney(totalPrice + pri);
                    return;
                }
                else
                {
                    foodPrice.Text = "0";
                    //'mTotal.Text = totalPrice.ToString();
                    mTotal.Text = formatMoney(totalPrice);
                }
            }
        }
        decimal prevValue = 0;
        private void numFood_ValueChanged(object sender, EventArgs e)
        {
            if(numFood.Value < 0)
            {
                numFood.Value = 1;
            }
            List<Food> foods = FoodDAO.Instance.GetAll();
            foreach (Food food in foods)
            {
                if (pickFood.Text == food.Name)
                {
                    //int p = (int)dtt.Rows[i][2];
                    int p;
                    if (numFood.Value <= prevValue)
                    {
                        if(numFood.Value == 0)
                        {
                            p = 0;
                        }
                        else
                        {
                            p = (int)food.Price * (int.Parse(numFood.Text) - 1);
                        }   
                    }
                    else
                    {
                        p = (int)food.Price * (int.Parse(numFood.Text) + 1);
                    }
                    
                    foodPrice.Text = formatMoney(p);
                    //'mTotal.Text = (totalPrice + p).ToString();
                    mTotal.Text = formatMoney(totalPrice + p);
                }
            }
            prevValue = numFood.Value;
        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }
    }
}
