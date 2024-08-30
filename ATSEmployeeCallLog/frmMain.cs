using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATSEmployeeCallLog
{
    public partial class frmMain : Form
    {
        TabPage newTab;
        TabPage existingTab;
        bool hiddenButtonClicked = false;
        int hiddenButtonCount = 0;
        dsHRTableAdapters.QueriesTableAdapter queriesAdapter = new dsHRTableAdapters.QueriesTableAdapter();

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsHR.tblEmpMaster' table. You can move, or remove it, as needed.
            this.tblEmpMasterTableAdapter.Fill(this.dsHR.tblEmpMaster);
            tabPanel.Visible = false;
            newTab = tabNew;
            existingTab = tabExisting;
            cmbAtsEmployee.SelectedIndex = -1;
        }

        private void radNew_CheckedChanged(object sender, EventArgs e)
        {
            tabPanel.Visible = true;
            if(radNew.Checked)
            {
                tabPanel.TabPages.Remove(existingTab);
                if(!tabPanel.TabPages.Contains(newTab))
                {
                    tabPanel.TabPages.Add(newTab);
                }
            }
        }

        private void btnInvisible_Click(object sender, EventArgs e)
        {
            switch (hiddenButtonCount)
            {
                case 0:
                    queriesAdapter.HiddenButtonLogAdd(Environment.UserName);
                    MessageBox.Show("Why did you click this hidden button?");
                    hiddenButtonCount++;
                    break;
                case 1:
                    MessageBox.Show("Why did you click this hidden button?");
                    hiddenButtonCount++;
                    break;
                case 2:
                    MessageBox.Show("Hidden button deactivating");
                    hiddenButtonCount++;
                    break;
                default:
                    break;
            }

                if (!hiddenButtonClicked)
                {
                    hiddenButtonClicked = true;
                }
                


            if (!hiddenButtonClicked)
            {
                hiddenButtonClicked = true;
            }
        }

        private void radExisting_CheckedChanged(object sender, EventArgs e)
        {
            tabPanel.Visible = true;
            if (radExisting.Checked)
            {
                tabPanel.TabPages.Remove(newTab);
                if (!tabPanel.TabPages.Contains(existingTab))
                {
                    tabPanel.TabPages.Add(existingTab);
                    this.tblEmpMasterTableAdapter.Fill(this.dsHR.tblEmpMaster);
                    cmbAtsEmployee.SelectedIndex = -1;
                }
            }
        }

        private void btnAtsAdd_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(txtFName.Text) || String.IsNullOrWhiteSpace(txtLName.Text))
            {
                MessageBox.Show("ATS Employee must have a name.");
                return;
            }
            int employeeExist = (int)queriesAdapter.DoesEmployeeExist(txtFName.Text, txtLName.Text, txtMiddleInitial.Text);
            if(employeeExist > 0)
            {
                MessageBox.Show("This employee exists, please use the existing/previous instead.");
                return;
            }
            int nextEmpId = (int)queriesAdapter.GetNextEmpId();
            this.tblEmpMasterTableAdapter.InsertNewEmployee(nextEmpId, txtLName.Text, txtFName.Text, txtMiddleInitial.Text);
            MessageBox.Show("ATS Employee has been added for the Call Log.");
            txtFName.Clear();
            txtLName.Clear();
            txtMiddleInitial.Clear();
            radNew.Checked = false;
            btnInvisible.Select();
            tabPanel.Visible = false;
        }

        private void btnAtsUpdate_Click(object sender, EventArgs e)
        {
            if(cmbAtsEmployee.SelectedIndex == -1)
            {
                return;
            }
            this.tblEmpMasterTableAdapter.UpdateExistingEmployee(chkAtsActive.Checked, (int)cmbAtsEmployee.SelectedValue);
            MessageBox.Show("ATS Employee " + cmbAtsEmployee.Text + " has been updated.");
            cmbAtsEmployee.SelectedIndex = -1;
            chkAtsActive.Checked = false;
            radExisting.Checked = false;
            btnInvisible.Select();
            tabPanel.Visible = false;
        }

        private void cmbAtsEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbAtsEmployee.SelectedIndex == -1)
            {
                return;
            }

            chkAtsActive.Checked = (bool)queriesAdapter.IsEmployeeActive((int)cmbAtsEmployee.SelectedValue);
        }
    }
}
