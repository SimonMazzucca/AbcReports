using AbcReports.DataAccess.Repositories;
using System;
using System.Windows.Forms;

namespace AbcReports
{
    public partial class LoginForm : Form
    {
        ABCReportsContext _context;

        public LoginForm()
        {
            InitializeComponent();
        }

        public LoginForm(ABCReportsContext context)
        {
            _context = context;
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            btnLogin.Enabled = false;

            LoginRepo loginRepo = new LoginRepo(_context);

            if (loginRepo.IsLoginValid(this.txtUserName.Text, this.txtPassword.Text))
            {
                ReportForm reportForm = new ReportForm(_context, this.txtUserName.Text);
                reportForm.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Invalid UserName or Password", "ABC Reports - Login Error");

            btnLogin.Enabled = true;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
    }
}
