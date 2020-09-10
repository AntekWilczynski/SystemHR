using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemHRUserInterface.Forms.Contracts;
using SystemHRUserInterface.Forms.Employees;

namespace SystemHRUserInterface.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            TabPage tpTab = new TabPage();
            tcTabs.Controls.Add(tpTab);
            EmployeesForm frm = new EmployeesForm();
            tpTab.Text = frm.Text = "Zakładka";
            frm.TopLevel = false;
            frm.Visible = true;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            tcTabs.TabPages[0].Controls.Add(frm);
        }
        private void btnContracts_Click(object sender, EventArgs e)
        {
            TabPage tpTab = new TabPage();
            tcTabs.Controls.Add(tpTab);
            ContractsForm frm = new ContractsForm();
            tpTab.Text = frm.Text = "Zakładka";
            frm.TopLevel = false;
            frm.Visible = true;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            tcTabs.TabPages[0].Controls.Add(frm);
        }
    

    }
}
