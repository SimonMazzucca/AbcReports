
namespace AbcReports
{
    partial class EditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtReportName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbAccounts = new System.Windows.Forms.ComboBox();
            this.optPastWeek = new System.Windows.Forms.RadioButton();
            this.optYearToDate = new System.Windows.Forms.RadioButton();
            this.optMonthToDate = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(120, 188);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(115, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "&Save Changes";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(259, 188);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(115, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Report Name";
            // 
            // txtReportName
            // 
            this.txtReportName.Location = new System.Drawing.Point(120, 23);
            this.txtReportName.Name = "txtReportName";
            this.txtReportName.Size = new System.Drawing.Size(254, 23);
            this.txtReportName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Period";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Account";
            // 
            // cmbAccounts
            // 
            this.cmbAccounts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAccounts.FormattingEnabled = true;
            this.cmbAccounts.Location = new System.Drawing.Point(120, 52);
            this.cmbAccounts.Name = "cmbAccounts";
            this.cmbAccounts.Size = new System.Drawing.Size(254, 23);
            this.cmbAccounts.TabIndex = 6;
            // 
            // optPastWeek
            // 
            this.optPastWeek.AutoSize = true;
            this.optPastWeek.Location = new System.Drawing.Point(120, 81);
            this.optPastWeek.Name = "optPastWeek";
            this.optPastWeek.Size = new System.Drawing.Size(79, 19);
            this.optPastWeek.TabIndex = 7;
            this.optPastWeek.TabStop = true;
            this.optPastWeek.Text = "Past Week";
            this.optPastWeek.UseVisualStyleBackColor = true;
            // 
            // optYearToDate
            // 
            this.optYearToDate.AutoSize = true;
            this.optYearToDate.Location = new System.Drawing.Point(120, 131);
            this.optYearToDate.Name = "optYearToDate";
            this.optYearToDate.Size = new System.Drawing.Size(88, 19);
            this.optYearToDate.TabIndex = 8;
            this.optYearToDate.TabStop = true;
            this.optYearToDate.Text = "Year to Date";
            this.optYearToDate.UseVisualStyleBackColor = true;
            // 
            // optMonthToDate
            // 
            this.optMonthToDate.AutoSize = true;
            this.optMonthToDate.Location = new System.Drawing.Point(120, 106);
            this.optMonthToDate.Name = "optMonthToDate";
            this.optMonthToDate.Size = new System.Drawing.Size(102, 19);
            this.optMonthToDate.TabIndex = 9;
            this.optMonthToDate.TabStop = true;
            this.optMonthToDate.Text = "Month to Date";
            this.optMonthToDate.UseVisualStyleBackColor = true;
            // 
            // EditForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(399, 233);
            this.Controls.Add(this.optMonthToDate);
            this.Controls.Add(this.optYearToDate);
            this.Controls.Add(this.optPastWeek);
            this.Controls.Add(this.cmbAccounts);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtReportName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Report";
            this.Load += new System.EventHandler(this.EditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtReportName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbAccounts;
        private System.Windows.Forms.RadioButton optPastWeek;
        private System.Windows.Forms.RadioButton optYearToDate;
        private System.Windows.Forms.RadioButton optMonthToDate;
    }
}