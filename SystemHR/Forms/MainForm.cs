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
        private string addButtonFullPath = @"C:\Users\aswil\Desktop\SystemHR\SystemHR\SystemHR\Resources\add-icon.png";
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            TabPage tpTab = new TabPage();
            tcTabs.Controls.Add(tpTab);
            EmployeesForm frm = new EmployeesForm();
            tpTab.Text = frm.Text ;
            frm.TopLevel = false;
            frm.Visible = true; 
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            tcTabs.TabPages[0].Controls.Add(frm);
            tcTabs.SelectedTab = tpTab;
        }
        private void btnContracts_Click(object sender, EventArgs e)
        {
            TabPage tpTab = new TabPage();
            tcTabs.Controls.Add(tpTab);
            ContractsForm frm = new ContractsForm();
            tpTab.Text = frm.Text ;
            frm.TopLevel = false;
            frm.Visible = true;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            tcTabs.TabPages[0].Controls.Add(frm);
            tcTabs.SelectedTab = tpTab;
        }

        private void tcTabs_DrawItem(object sender, DrawItemEventArgs e)
        {
            {
                try
                {
                    var tabPage = this.tcTabs.TabPages[e.Index];
                    var tabRect = this.tcTabs.GetTabRect(e.Index);
                    var closeImage = new Bitmap(closeButtonFullPath);
                        e.Graphics.DrawImage(closeImage,
                            (tabRect.Right - closeImage.Width),
                            tabRect.Top + (tabRect.Height - closeImage.Height) / 2);
                        TextRenderer.DrawText(e.Graphics, tabPage.Text, tabPage.Font,
                            tabRect, tabPage.ForeColor, TextFormatFlags.Left);
                    
                }
                catch (Exception ex) { throw new Exception(ex.Message); }
            }
        }

        private void tcTabs_MouseDown(object sender, MouseEventArgs e)
        {
            // Process MouseDown event only till (tabControl.TabPages.Count - 1) excluding the last TabPage
            for (var i = 0; i < this.tcTabs.TabPages.Count; i++)
            {
                var tabRect = this.tcTabs.GetTabRect(i);
                tabRect.Inflate(-2, -2);
                var closeImage = new Bitmap(closeButtonFullPath);
                var imageRect = new Rectangle(
                    (tabRect.Right - closeImage.Width),
                    tabRect.Top + (tabRect.Height - closeImage.Height) / 2,
                    closeImage.Width,
                    closeImage.Height);
                if (imageRect.Contains(e.Location))
                {
                    this.tcTabs.TabPages.RemoveAt(i);
                    break;
                }
            }
        }
    }
    
}
