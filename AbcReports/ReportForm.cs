﻿using AbcReports.DataAccess;
using AbcReports.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;


namespace AbcReports
{
    public partial class ReportForm : Form
    {

        ReportsRepo _reportsRepo;
        string _userName;

        public ReportForm()
        {
            InitializeComponent();
        }

        public ReportForm(ABCReportsContext context, string userName)
        {
            _userName = userName;
            _reportsRepo = new ReportsRepo(context);

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
            IList<Report> reports = _reportsRepo.GetUserReports(_userName);

            // Populate ListView
            lvwReports.Items.Clear();
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
            DialogResult answer = MessageBox.Show(this, "Are you sure you want to delete report " + e.Item.Name + "?", "Delete Report?", MessageBoxButtons.YesNo);

            if (answer == DialogResult.Yes)
            {
                _reportsRepo.DeleteReport((int)e.Item.Tag);
                LoadReports();
            }
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
