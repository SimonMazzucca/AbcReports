using AbcReports.DataAccess.Repositories;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AbcReports
{

    /// <summary>
    /// Story 3: Edit Reports
    /// </summary>
    public partial class EditForm : Form
    {
        ReportsRepo _reportsRepo;
        UserRepo _userRepo;
        Report _report;
        List<Account> _userAccounts;

        int _reportId;
        string _userName;

        public EditForm(ABCReportsContext context, int reportId, string userName)
        {
            _reportsRepo = new ReportsRepo(context);
            _userRepo = new UserRepo(context);
            _reportId = reportId;
            _userName = userName;

            InitializeComponent();
        }

        public EditForm()
        {
            InitializeComponent();
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            _report = _reportsRepo.GetReportDetails(_reportId);
            _userAccounts = _userRepo.GetUserAccounts(1);

            txtReportName.Text = _report.ReportName;
            cmbAccounts.Items.Clear();

            for (int i = 0; i < _userAccounts.Count; i++)
            {
                cmbAccounts.Items.Add(_userAccounts[i].AccountNumber);
                if (_userAccounts[i].AccountId == _report.Account.AccountId)
                    cmbAccounts.SelectedIndex = i;
            }

            if (_report.Period == "PWK")
                optPastWeek.Checked = true;
            else if (_report.Period == "MTD")
                optMonthToDate.Checked = true;
            else if (_report.Period == "YTD")
                optYearToDate.Checked = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string accountNumber = cmbAccounts.SelectedItem.ToString();
            string period;

            if (optPastWeek.Checked)
                period = "PWK";
            else if (optMonthToDate.Checked)
                period = "MTD";
            else 
                period = "YTD";

            _reportsRepo.SaveEditedReport(_report, txtReportName.Text, accountNumber, period);
            this.Close();
        }
    }
}
