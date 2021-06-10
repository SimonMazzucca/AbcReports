using AbcReports.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AbcReports
{
    public partial class EditForm : Form
    {
        ReportsRepo _reportsRepo;
        UserRepo _userRepo;

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
            Report report = _reportsRepo.GetReportDetails(_reportId);
            List<Account> userAccounts = _userRepo.GetUserAccounts(1);

            txtReportName.Text = report.ReportName;
            cmbAccounts.Items.Clear();

            for (int i = 0; i < userAccounts.Count; i++)
            {
                cmbAccounts.Items.Add(userAccounts[i].AccountNumber);
                if (userAccounts[i].AccountId == report.Account.AccountId)
                    cmbAccounts.SelectedIndex = i;
            }

            if (report.Period == "PWK")
                optPastWeek.Checked = true;
            else if (report.Period == "MTD")
                optMonthToDate.Checked = true;
            else if (report.Period == "YTD")
                optYearToDate.Checked = true;
        }
    }
}
