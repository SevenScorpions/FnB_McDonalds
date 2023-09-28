using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogInDemo.DTO;
using LogInDemo.DAO;
using Excel = Microsoft.Office.Interop.Excel;// use to export excel
using iTextSharp.text;
using iTextSharp.text.pdf;
using LogInDemo.Strategy;
using LogInDemo.FactoryMethod;
using LogInDemo.Template;
using LogInDemo.Adapter;

namespace LogInDemo
{
    public partial class mainFrm : Form
    {
        public User user;
        private RevenueDataService revenueDataService;
        IExporterFactory exporterFactory = new ExporterFactory();
        IExporter exporter = null;
        public mainFrm(User user)
        {
            InitializeComponent();
            this.user = user;
            loadArea();
            loadMovie();
            loadHis();
            loadPro5();
            loadData();
            loadDateComboBox();

        }
        private void loadDateComboBox()
        {
            for (int i = 2025; i > 2010; i--)
            {
                cbYear1.Items.Add(i.ToString());
            }

            cbDay1.Items.Add("--");
            cbDay1.SelectedIndex = 0;
            cbMonth1.Items.Add("--");
            cbMonth1.SelectedIndex = 0;
            cbYear1.Items.Insert(0, "--");
            cbYear1.SelectedIndex = 0;
            cbMonth1.SelectedIndexChanged += dataGridViewFill;
            cbYear1.SelectedIndexChanged += dataGridViewFill;
            cbDay1.SelectedIndexChanged += dataGridViewFill;
        }


        private void loadData()
        {
            string query1 = @"select [Username],[Password],[Name],[Birthday],[Email],[Phone],[Gender],[Point],[NID] from customer where username != 'admin'";
            DataTable data1 = DataProvider.Instance.ExcuteQuery(query1);
            dataGridView1.DataSource = data1;
            string query2 = @"select * from food where fid != ''";
            DataTable data2 = DataProvider.Instance.ExcuteQuery(query2);
            dataGridView2.DataSource = data2;

            for (int i = 0; i <= dataGridView1.ColumnCount - 1; i++)
            {
                dataGridView1.Columns[i].ReadOnly = true;
            }

            for (int i = 0; i <= dataGridView2.ColumnCount - 1; i++)
            {
                dataGridView2.Columns[i].ReadOnly = true;
            }

            for (int i = 0; i <= dataGridView3.ColumnCount - 1; i++)
            {
                dataGridView3.Columns[i].ReadOnly = true;
            }
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void loadArea()
        {
            List<Area> areas = AreaDAO.Instance.GetAll();
            cbArea.DataSource = areas;
            cbArea.DisplayMember = "name";
        }

        private void loadCinemaByAID(string aid)
        {
            List<Cinema> cinemas = CinemaDAO.Instance.getCinemaListByAID(aid);
            cbCinema.DataSource = cinemas;
            cbCinema.DisplayMember = "name";
        }
        private void loadMovie()
        {
            List<Movie> movies = MovieDAO.Instance.GetAll();
            cbMovie.DataSource = movies;
            cbMovie.DisplayMember = "name";
        }
        private void loadHis()
        {
            List<Bill> bills = BillDAO.Instance.getUserBill(user.Username);
            foreach (Bill bill in bills)
            {
                Button bttn = new Button() { Width = hisFlw.Width, Height = 90 };
                string query = @"select * from session where sid='" + bill.Sid + "'";
                DataTable data = DataProvider.Instance.ExcuteQuery(query);
                Session session = new Session(data.Rows[0]);
                query = @"select * from movie where mid='" + session.Mid + "'";
                data = DataProvider.Instance.ExcuteQuery(query);
                Movie movie = new Movie(data.Rows[0]);
                query = @"select Cinema.cid,cinema.cname,cinema.aid from cinema,room,session where cinema.cid=room.cid and room.rid = session.rid and session.rid = '" + session.Room + "'";
                data = DataProvider.Instance.ExcuteQuery(query);
                Cinema cinema = new Cinema(data.Rows[0]);
                List<Ticket> tickets = TicketDAO.Instance.getTicketList(bill.Id);
                bttn.Text = "Bill: " + bill.Id + " - " + cinema.Name + "\n" + movie.Name;
                if (session.Format != "Normal")
                {
                    bttn.Text += " (" + session.Format + ")";
                }
                bttn.Text += " - Time: " + session.Date.ToString("dd/MM/yyyy HH:mm");
                bttn.Text += "\nTotal: " + session.Price * tickets.Count + " VND";
                bttn.BackColor = Color.Turquoise;
                bttn.ForeColor = Color.White;
                bttn.FlatStyle = FlatStyle.Flat;
                bttn.FlatAppearance.BorderSize = 0;
                bttn.TextAlign = ContentAlignment.MiddleLeft;
                bttn.Enabled = false;
                hisFlw.Controls.Add(bttn);
                foreach (Ticket ticket in tickets)
                {
                    Button bttnt = new Button() { Width = hisFlw.Width, Height = 40 };
                    bttnt.Text = "ID: " + ticket.Id + " - Chair number: " + ticket.Chair;
                    bttnt.BackColor = Color.PaleGoldenrod;
                    bttnt.ForeColor = Color.Black;
                    bttnt.FlatStyle = FlatStyle.Flat;
                    bttnt.FlatAppearance.BorderSize = 0;
                    bttnt.TextAlign = ContentAlignment.MiddleLeft;
                    bttnt.Enabled = false;
                    hisFlw.Controls.Add(bttnt);
                }
            }
        }
        private SessionDAO sessionDAO;
        private void loadSession()
        {
            Movie movie = ((Movie)cbMovie.Tag);
            Cinema cinema = ((Cinema)cbCinema.Tag);
            sessionFlw.Controls.Clear();
            sessionDAO = SessionDAO.Instance;
            sessionDAO.SetRoomAdapter(new RoomAdapter());
            List<Session> sessions = sessionDAO.GetSessionsByMovieCinemaAndDate(movie, cinema, ((DateTime)timePick.Tag).Date);
            //List<Session> sessions = SessionDAO.Instance.GetSessionsByMovieCinemaAndDate(movie,cinema, ((DateTime)timePick.Tag).Date);
            foreach (Session session in sessions)
            {
                Button bttn = new Button() { Width = SessionDAO.width, Height = SessionDAO.height };
                bttn.Text = ((Movie)cbMovie.Tag).Name;
                if (session.Format != "Normal")
                {
                    bttn.Text += " (" + session.Format + ")";
                }
                bttn.Click += Bttn_Click;
                bttn.Text += "\n" + session.Subtitle + " - Time Start: " + session.Date.TimeOfDay;
                bttn.BackColor = Color.DarkCyan;
                bttn.ForeColor = Color.White;
                bttn.FlatStyle = FlatStyle.Flat;
                bttn.FlatAppearance.BorderSize = 0;
                bttn.TextAlign = ContentAlignment.MiddleLeft;
                bttn.Tag = session;
                sessionFlw.Controls.Add(bttn);
            }

        }

        private void Bttn_Click(object? sender, EventArgs e)
        {
            Button button = sender as Button;
            buyTicketFrm frm = new buyTicketFrm(user, (Session)button.Tag, (Movie)cbMovie.Tag);
            MessageBox.Show("You need to click Reload to select chair!");
            frm.ShowDialog();
        }

        private void loadPro5()
        {
            pro4Username.Text = user.Username;
            pro4BirthDay.Value = user.Birthdate;
            pro4Email.Text = user.Email;
            pro4Id.Text = user.Nid;
            pro4Name.Text = user.Name;
            pro4Phone.Text = user.Phone;
            if (user.Gender == "F")
            {
                genderF.Checked = true;
            }
            else
            {
                genderM.Checked = true;
            }
        }
        private void pro4Tab_Click(object sender, EventArgs e)
        {

        }

        private void mainFrm_Load(object sender, EventArgs e)
        {
            cbArea.SelectedIndex = -1;
            cbCinema.SelectedIndex = -1;
            cbCinema.Enabled = false;
            cbMovie.SelectedIndex = -1;
            searchBttn.Enabled = false;

            if (user.Username != "admin")
            {
                settingTab.TabPages.RemoveAt(3);
                settingTab.TabPages.RemoveAt(3);
                settingTab.TabPages.RemoveAt(3);
            }

        }

        private void appExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to close the program?", "", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                return;
            }
            Application.Exit();
        }

        private void appSignOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            string aid = "";
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
            {
                return;
            }
            Area a = cb.SelectedItem as Area;
            aid = a.Id;
            loadCinemaByAID(aid);
            cbCinema.SelectedIndex = -1;
            cbCinema.Enabled = true;
        }

        private string formatMoney(int p)
        {
            if (p == 0)
            {
                return 0 + " VND";
            }
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
            return str + " VND";
        }

        private void timePick_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = timePick.Value;
            timePick.Tag = date;
            searchBttn.Enabled = true;
        }

        private void searchBttn_Click(object sender, EventArgs e)
        {
            loadSession();
        }

        private void cbCinema_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
            {
                return;
            }
            Cinema a = cb.SelectedItem as Cinema;
            cbCinema.Tag = a;
        }

        private void cbMovie_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
            {
                return;
            }
            Movie a = cb.SelectedItem as Movie;
            cbMovie.Tag = a;
        }

        private void pro4Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void settingTab_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frm = new changePassFrm(user);
            frm.ShowDialog();
        }

        private void saveChangeBttn_Click(object sender, EventArgs e)
        {
            if (pro4Password.Text == user.Password)
            {
                if (genderF.Checked == true)
                {
                    user.Gender = "F";
                }
                else
                {
                    user.Gender = "M";
                }
                user.Phone = pro4Phone.Text;
                user.Birthdate = ((DateTime)pro4BirthDay.Value).Date;
                user.Email = pro4Email.Text;
                user.Nid = pro4Id.Text;
                UserDAO.Instance.Update(user);
                MessageBox.Show("Change profile information successfully");
            }
            else if (pro4Password.Text == "")
            {
                MessageBox.Show("Enter the password to save your change.");
            }
            else
            {
                MessageBox.Show("Wrong password.");
            }
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void textBoxToday_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabRevenue_Click(object sender, EventArgs e)
        {

        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            exporter = exporterFactory.CreateExporter("excel");
            exporter.Export(dataGridView3);
        }

        private void btnExportPDF_Click(object sender, EventArgs e)
        {
            exporter = exporterFactory.CreateExporter("pdf");
            exporter.Export(dataGridView3);
        }

        private void btnExportCSV_Click(object sender, EventArgs e)
        {
            exporter = exporterFactory.CreateExporter("csv");
            exporter.Export(dataGridView3);
        }

        private void mainFrm_SizeChanged(object sender, EventArgs e)
        {
            foreach (Control control in hisFlw.Controls)
            {
                control.Width = hisFlw.Width - 5;
            }
        }

        private void tabHis_Click(object sender, EventArgs e)
        {

        }

        private void hisFlw_SizeChanged(object sender, EventArgs e)
        {
            foreach (Control control in hisFlw.Controls)
            {
                control.Width = hisFlw.Width - 5;
            }
        }

        private void cbDay1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbYear1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbYear1.SelectedIndex == 0)
            {
                cbMonth1.Items.Clear();
                cbMonth1.Items.Add("--");
                cbMonth1.SelectedIndex = 0;
            }
            else
            {
                if (cbMonth1.Items.Count == 1)
                {
                    for (int i = 1; i < 13; i++)
                    {
                        cbMonth1.Items.Add(i.ToString());
                    }
                }
            }
        }

        private void cbMonth1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMonth1.SelectedIndex == 0)
            {
                cbDay1.Items.Clear();
                cbDay1.Items.Add("--");
                cbDay1.SelectedIndex = 0;
            }
            else
            {
                int n = DateTime.DaysInMonth(int.Parse(cbYear1.Text), int.Parse(cbMonth1.Text));
                for (int i = 1; i <= n; i++)
                {
                    cbDay1.Items.Add(i);
                }
            }
        }
        private void dataGridViewFill(object? sender, EventArgs e)
        {
            int year = 0;
            int month = 0;
            int day = 0;
            if (!int.TryParse(cbYear1.Text, out year))
            {
                revenueDataService = new RDSAll(dataGridView3);
            }
            else if (!int.TryParse(cbMonth1.Text, out month))
            {
                revenueDataService = new RDSByYear(dataGridView3, year);
            }
            else if (!int.TryParse(cbDay1.Text, out day))
            {
                revenueDataService = new RDSByMonth(dataGridView3, year, month);
            }
            else
            {
                revenueDataService = new RDSByDate(dataGridView3, year, month, day);
            }
            revenueDataService.FillStatisticData();
        }
    }
}
