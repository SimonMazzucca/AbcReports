using AbcReports.DataAccess;
using AbcReports.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AbcReports
{
    public partial class ReportForm : Form
    {

        ABCReportsContext _context;
        string _userName;

        public ReportForm()
        {
            InitializeComponent();
        }

        public ReportForm(ABCReportsContext context, string userName)
        {
            _context = context;
            _userName = userName;

            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            SetupListView();
            LoadReports();
        }

        private void LoadReports()
        {
            // Retrive report data
            ReportsRepo repo = new ReportsRepo(_context);
            IList<Report> reports = repo.GetUserReports(_userName);

            // Populate ListView
            foreach (var report in reports)
            {
                ListViewItem lvi = GetAsListViewItem(report);
                lvwReports.Items.Add(lvi);
            }
        }

        private void SetupListView()
        {
            lvwReports.View = View.Details;
            lvwReports.Columns.Add("Report Name", 200);
            lvwReports.Columns.Add("Created on", 70);
            lvwReports.Columns.Add("Account Number", 110);
            lvwReports.Columns.Add("Period", 90);
            lvwReports.Columns.Add("Edit", 80);
            lvwReports.Columns.Add("Delete", 80);
            lvwReports.FullRowSelect = true;

            ListViewExtender extender = new ListViewExtender(lvwReports);

            ListViewButtonColumn btnEdit = new ListViewButtonColumn(4);
            btnEdit.Click += OnEditButtonActionClick;
            btnEdit.FixedWidth = true;
            extender.AddColumn(btnEdit);

            ListViewButtonColumn btnDelete = new ListViewButtonColumn(5);
            btnDelete.Click += OnDeleteButtonActionClick;
            btnDelete.FixedWidth = true;
            extender.AddColumn(btnDelete);
        }

        private void OnEditButtonActionClick(object sender, ListViewColumnMouseEventArgs e)
        {
            MessageBox.Show(this, @"EDIT: " + e.Item.Tag);
        }

        private void OnDeleteButtonActionClick(object sender, ListViewColumnMouseEventArgs e)
        {
            MessageBox.Show(this, @"DEL: " + e.Item.Tag);
        }

        private ListViewItem GetAsListViewItem(Report report)
        {
            ListViewItem result = new ListViewItem(report.ReportName);
            result.Tag = report.ReportId;
            result.SubItems.Add(report.CreationDate.ToString("MM/dd/yy"));
            result.SubItems.Add(report.Account.AccountNumber);
            result.SubItems.Add(report.Period.ToVerbose());
            result.SubItems.Add("Edit");
            result.SubItems.Add("Delete");

            return result;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
