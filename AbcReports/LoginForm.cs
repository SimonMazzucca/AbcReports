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

        private void Main_Load(object sender, EventArgs e)
        {
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginRepo loginRepo = new LoginRepo(_context);

            if (loginRepo.IsLoginValid(this.txtUserName.Text, this.txtPassword.Text))
                //Close and open app
                MessageBox.Show("Success");
            else
                MessageBox.Show("Error");
        }
    }
}
