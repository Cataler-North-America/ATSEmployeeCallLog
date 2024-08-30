namespace ATSEmployeeCallLog
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.radNew = new System.Windows.Forms.RadioButton();
            this.radExisting = new System.Windows.Forms.RadioButton();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.tabPanel = new System.Windows.Forms.TabControl();
            this.tabNew = new System.Windows.Forms.TabPage();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtMiddleInitial = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblMiddleInitial = new System.Windows.Forms.Label();
            this.btnAtsAdd = new System.Windows.Forms.Button();
            this.lblNewInstructions = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.tabExisting = new System.Windows.Forms.TabPage();
            this.btnAtsUpdate = new System.Windows.Forms.Button();
            this.chkAtsActive = new System.Windows.Forms.CheckBox();
            this.lblAtsExisting = new System.Windows.Forms.Label();
            this.cmbAtsEmployee = new System.Windows.Forms.ComboBox();
            this.tblEmpMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsHR = new ATSEmployeeCallLog.dsHR();
            this.btnInvisible = new System.Windows.Forms.Button();
            this.tblEmpMasterTableAdapter = new ATSEmployeeCallLog.dsHRTableAdapters.tblEmpMasterTableAdapter();
            this.tabPanel.SuspendLayout();
            this.tabNew.SuspendLayout();
            this.tabExisting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmpMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHR)).BeginInit();
            this.SuspendLayout();
            // 
            // radNew
            // 
            this.radNew.AutoSize = true;
            this.radNew.Location = new System.Drawing.Point(285, 89);
            this.radNew.Name = "radNew";
            this.radNew.Size = new System.Drawing.Size(58, 24);
            this.radNew.TabIndex = 1;
            this.radNew.TabStop = true;
            this.radNew.Text = "New";
            this.radNew.UseVisualStyleBackColor = true;
            this.radNew.CheckedChanged += new System.EventHandler(this.radNew_CheckedChanged);
            // 
            // radExisting
            // 
            this.radExisting.AutoSize = true;
            this.radExisting.Location = new System.Drawing.Point(411, 89);
            this.radExisting.Name = "radExisting";
            this.radExisting.Size = new System.Drawing.Size(154, 24);
            this.radExisting.TabIndex = 2;
            this.radExisting.TabStop = true;
            this.radExisting.Text = "Existing / Previous";
            this.radExisting.UseVisualStyleBackColor = true;
            this.radExisting.CheckedChanged += new System.EventHandler(this.radExisting_CheckedChanged);
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(245, 46);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(345, 20);
            this.lblQuestion.TabIndex = 2;
            this.lblQuestion.Text = "Is this ATS Employee New or Existing/Previous?";
            // 
            // tabPanel
            // 
            this.tabPanel.Controls.Add(this.tabNew);
            this.tabPanel.Controls.Add(this.tabExisting);
            this.tabPanel.Location = new System.Drawing.Point(97, 134);
            this.tabPanel.Name = "tabPanel";
            this.tabPanel.SelectedIndex = 0;
            this.tabPanel.Size = new System.Drawing.Size(855, 468);
            this.tabPanel.TabIndex = 3;
            // 
            // tabNew
            // 
            this.tabNew.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabNew.Controls.Add(this.txtLName);
            this.tabNew.Controls.Add(this.txtMiddleInitial);
            this.tabNew.Controls.Add(this.txtFName);
            this.tabNew.Controls.Add(this.lblLName);
            this.tabNew.Controls.Add(this.lblMiddleInitial);
            this.tabNew.Controls.Add(this.btnAtsAdd);
            this.tabNew.Controls.Add(this.lblNewInstructions);
            this.tabNew.Controls.Add(this.lblFName);
            this.tabNew.ForeColor = System.Drawing.Color.Black;
            this.tabNew.Location = new System.Drawing.Point(4, 29);
            this.tabNew.Name = "tabNew";
            this.tabNew.Padding = new System.Windows.Forms.Padding(3);
            this.tabNew.Size = new System.Drawing.Size(847, 435);
            this.tabNew.TabIndex = 0;
            this.tabNew.Text = "New ATS Employee";
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(389, 218);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(241, 26);
            this.txtLName.TabIndex = 9;
            // 
            // txtMiddleInitial
            // 
            this.txtMiddleInitial.Location = new System.Drawing.Point(389, 175);
            this.txtMiddleInitial.Name = "txtMiddleInitial";
            this.txtMiddleInitial.Size = new System.Drawing.Size(241, 26);
            this.txtMiddleInitial.TabIndex = 8;
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(389, 131);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(241, 26);
            this.txtFName.TabIndex = 7;
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(239, 221);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(90, 20);
            this.lblLName.TabIndex = 6;
            this.lblLName.Text = "Last Name:";
            // 
            // lblMiddleInitial
            // 
            this.lblMiddleInitial.AutoSize = true;
            this.lblMiddleInitial.Location = new System.Drawing.Point(239, 178);
            this.lblMiddleInitial.Name = "lblMiddleInitial";
            this.lblMiddleInitial.Size = new System.Drawing.Size(100, 20);
            this.lblMiddleInitial.TabIndex = 5;
            this.lblMiddleInitial.Text = "Middle Initial:";
            // 
            // btnAtsAdd
            // 
            this.btnAtsAdd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAtsAdd.Location = new System.Drawing.Point(284, 310);
            this.btnAtsAdd.Name = "btnAtsAdd";
            this.btnAtsAdd.Size = new System.Drawing.Size(300, 74);
            this.btnAtsAdd.TabIndex = 4;
            this.btnAtsAdd.Text = "Add ATS Employee To Call Log";
            this.btnAtsAdd.UseVisualStyleBackColor = false;
            this.btnAtsAdd.Click += new System.EventHandler(this.btnAtsAdd_Click);
            // 
            // lblNewInstructions
            // 
            this.lblNewInstructions.AutoSize = true;
            this.lblNewInstructions.Location = new System.Drawing.Point(297, 67);
            this.lblNewInstructions.Name = "lblNewInstructions";
            this.lblNewInstructions.Size = new System.Drawing.Size(287, 20);
            this.lblNewInstructions.TabIndex = 1;
            this.lblNewInstructions.Text = "Please input the ATS Employee\'s name";
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(239, 134);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(90, 20);
            this.lblFName.TabIndex = 0;
            this.lblFName.Text = "First Name:";
            // 
            // tabExisting
            // 
            this.tabExisting.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabExisting.Controls.Add(this.btnAtsUpdate);
            this.tabExisting.Controls.Add(this.chkAtsActive);
            this.tabExisting.Controls.Add(this.lblAtsExisting);
            this.tabExisting.Controls.Add(this.cmbAtsEmployee);
            this.tabExisting.ForeColor = System.Drawing.Color.Black;
            this.tabExisting.Location = new System.Drawing.Point(4, 29);
            this.tabExisting.Name = "tabExisting";
            this.tabExisting.Padding = new System.Windows.Forms.Padding(3);
            this.tabExisting.Size = new System.Drawing.Size(847, 435);
            this.tabExisting.TabIndex = 1;
            this.tabExisting.Text = "Existing / Previous ATS Employee";
            // 
            // btnAtsUpdate
            // 
            this.btnAtsUpdate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAtsUpdate.Location = new System.Drawing.Point(252, 270);
            this.btnAtsUpdate.Name = "btnAtsUpdate";
            this.btnAtsUpdate.Size = new System.Drawing.Size(300, 74);
            this.btnAtsUpdate.TabIndex = 3;
            this.btnAtsUpdate.Text = "Update ATS Employee In Call Log";
            this.btnAtsUpdate.UseVisualStyleBackColor = false;
            this.btnAtsUpdate.Click += new System.EventHandler(this.btnAtsUpdate_Click);
            // 
            // chkAtsActive
            // 
            this.chkAtsActive.AutoSize = true;
            this.chkAtsActive.Location = new System.Drawing.Point(297, 193);
            this.chkAtsActive.Name = "chkAtsActive";
            this.chkAtsActive.Size = new System.Drawing.Size(206, 24);
            this.chkAtsActive.TabIndex = 2;
            this.chkAtsActive.Text = "Is ATS Employee Active?";
            this.chkAtsActive.UseVisualStyleBackColor = true;
            // 
            // lblAtsExisting
            // 
            this.lblAtsExisting.AutoSize = true;
            this.lblAtsExisting.Location = new System.Drawing.Point(115, 97);
            this.lblAtsExisting.Name = "lblAtsExisting";
            this.lblAtsExisting.Size = new System.Drawing.Size(164, 20);
            this.lblAtsExisting.TabIndex = 1;
            this.lblAtsExisting.Text = "ATS Employee Name:";
            // 
            // cmbAtsEmployee
            // 
            this.cmbAtsEmployee.DataSource = this.tblEmpMasterBindingSource;
            this.cmbAtsEmployee.DisplayMember = "FullName";
            this.cmbAtsEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAtsEmployee.FormattingEnabled = true;
            this.cmbAtsEmployee.Location = new System.Drawing.Point(297, 94);
            this.cmbAtsEmployee.Name = "cmbAtsEmployee";
            this.cmbAtsEmployee.Size = new System.Drawing.Size(446, 28);
            this.cmbAtsEmployee.TabIndex = 0;
            this.cmbAtsEmployee.ValueMember = "EmpID";
            this.cmbAtsEmployee.SelectedIndexChanged += new System.EventHandler(this.cmbAtsEmployee_SelectedIndexChanged);
            // 
            // tblEmpMasterBindingSource
            // 
            this.tblEmpMasterBindingSource.DataMember = "tblEmpMaster";
            this.tblEmpMasterBindingSource.DataSource = this.dsHR;
            // 
            // dsHR
            // 
            this.dsHR.DataSetName = "dsHR";
            this.dsHR.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnInvisible
            // 
            this.btnInvisible.BackColor = System.Drawing.Color.Teal;
            this.btnInvisible.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvisible.ForeColor = System.Drawing.Color.Teal;
            this.btnInvisible.Location = new System.Drawing.Point(-3, -2);
            this.btnInvisible.Name = "btnInvisible";
            this.btnInvisible.Size = new System.Drawing.Size(10, 10);
            this.btnInvisible.TabIndex = 0;
            this.btnInvisible.Text = "button1";
            this.btnInvisible.UseVisualStyleBackColor = false;
            this.btnInvisible.Click += new System.EventHandler(this.btnInvisible_Click);
            // 
            // tblEmpMasterTableAdapter
            // 
            this.tblEmpMasterTableAdapter.ClearBeforeFill = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1019, 644);
            this.Controls.Add(this.btnInvisible);
            this.Controls.Add(this.tabPanel);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.radExisting);
            this.Controls.Add(this.radNew);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.Text = "ATS Call Log Maintenance";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabPanel.ResumeLayout(false);
            this.tabNew.ResumeLayout(false);
            this.tabNew.PerformLayout();
            this.tabExisting.ResumeLayout(false);
            this.tabExisting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmpMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radNew;
        private System.Windows.Forms.RadioButton radExisting;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.TabControl tabPanel;
        private System.Windows.Forms.TabPage tabNew;
        private System.Windows.Forms.TabPage tabExisting;
        private System.Windows.Forms.Button btnInvisible;
        private System.Windows.Forms.Label lblNewInstructions;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.ComboBox cmbAtsEmployee;
        private dsHR dsHR;
        private System.Windows.Forms.BindingSource tblEmpMasterBindingSource;
        private dsHRTableAdapters.tblEmpMasterTableAdapter tblEmpMasterTableAdapter;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtMiddleInitial;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblMiddleInitial;
        private System.Windows.Forms.Button btnAtsAdd;
        private System.Windows.Forms.Button btnAtsUpdate;
        private System.Windows.Forms.CheckBox chkAtsActive;
        private System.Windows.Forms.Label lblAtsExisting;
    }
}

