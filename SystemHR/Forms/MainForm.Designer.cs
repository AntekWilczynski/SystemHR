namespace SystemHRUserInterface.Forms
{
    partial class MainForm
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
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpGeneral = new System.Windows.Forms.TabPage();
            this.tpConfiguration = new System.Windows.Forms.TabPage();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tsslVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslDataBase = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnPositions = new System.Windows.Forms.Button();
            this.btnDepartments = new System.Windows.Forms.Button();
            this.btnSalaries = new System.Windows.Forms.Button();
            this.btnOrganizationeStructures = new System.Windows.Forms.Button();
            this.btnContracts = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.tcMain.SuspendLayout();
            this.tpGeneral.SuspendLayout();
            this.ssMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpGeneral);
            this.tcMain.Controls.Add(this.tpConfiguration);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(874, 92);
            this.tcMain.TabIndex = 0;
            // 
            // tpGeneral
            // 
            this.tpGeneral.Controls.Add(this.splitter1);
            this.tpGeneral.Controls.Add(this.btnPositions);
            this.tpGeneral.Controls.Add(this.btnDepartments);
            this.tpGeneral.Controls.Add(this.btnSalaries);
            this.tpGeneral.Controls.Add(this.btnOrganizationeStructures);
            this.tpGeneral.Controls.Add(this.btnContracts);
            this.tpGeneral.Controls.Add(this.btnEmployee);
            this.tpGeneral.Location = new System.Drawing.Point(4, 22);
            this.tpGeneral.Name = "tpGeneral";
            this.tpGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tpGeneral.Size = new System.Drawing.Size(866, 66);
            this.tpGeneral.TabIndex = 0;
            this.tpGeneral.Text = "Ogólne";
            this.tpGeneral.UseVisualStyleBackColor = true;
            // 
            // tpConfiguration
            // 
            this.tpConfiguration.Location = new System.Drawing.Point(4, 22);
            this.tpConfiguration.Name = "tpConfiguration";
            this.tpConfiguration.Padding = new System.Windows.Forms.Padding(3);
            this.tpConfiguration.Size = new System.Drawing.Size(866, 66);
            this.tpConfiguration.TabIndex = 1;
            this.tpConfiguration.Text = "Konfiguracja";
            this.tpConfiguration.UseVisualStyleBackColor = true;
            // 
            // ssMain
            // 
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslVersion,
            this.tsslDataBase,
            this.tsslUser});
            this.ssMain.Location = new System.Drawing.Point(0, 539);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(874, 22);
            this.ssMain.TabIndex = 1;
            this.ssMain.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(874, 447);
            this.panel1.TabIndex = 2;
            // 
            // tsslVersion
            // 
            this.tsslVersion.Name = "tsslVersion";
            this.tsslVersion.Size = new System.Drawing.Size(69, 17);
            this.tsslVersion.Text = "Wersja 1.0.0";
            // 
            // tsslDataBase
            // 
            this.tsslDataBase.Name = "tsslDataBase";
            this.tsslDataBase.Size = new System.Drawing.Size(122, 17);
            this.tsslDataBase.Text = "Baza HumanResource";
            // 
            // tsslUser
            // 
            this.tsslUser.Name = "tsslUser";
            this.tsslUser.Size = new System.Drawing.Size(68, 17);
            this.tsslUser.Text = "Użytkownik";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(843, 3);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 60);
            this.splitter1.TabIndex = 15;
            this.splitter1.TabStop = false;
            // 
            // btnPositions
            // 
            this.btnPositions.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPositions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPositions.Image = global::SystemHRUserInterface.Properties.Resources.bar_chart_icon;
            this.btnPositions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPositions.Location = new System.Drawing.Point(703, 3);
            this.btnPositions.Name = "btnPositions";
            this.btnPositions.Size = new System.Drawing.Size(140, 60);
            this.btnPositions.TabIndex = 14;
            this.btnPositions.Text = "Stanowiska";
            this.btnPositions.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPositions.UseVisualStyleBackColor = true;
            // 
            // btnDepartments
            // 
            this.btnDepartments.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDepartments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepartments.Image = global::SystemHRUserInterface.Properties.Resources.briefcase_icon;
            this.btnDepartments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDepartments.Location = new System.Drawing.Point(563, 3);
            this.btnDepartments.Name = "btnDepartments";
            this.btnDepartments.Size = new System.Drawing.Size(140, 60);
            this.btnDepartments.TabIndex = 13;
            this.btnDepartments.Text = "Działy";
            this.btnDepartments.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDepartments.UseVisualStyleBackColor = true;
            // 
            // btnSalaries
            // 
            this.btnSalaries.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSalaries.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalaries.Image = global::SystemHRUserInterface.Properties.Resources.money_icon;
            this.btnSalaries.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalaries.Location = new System.Drawing.Point(423, 3);
            this.btnSalaries.Name = "btnSalaries";
            this.btnSalaries.Size = new System.Drawing.Size(140, 60);
            this.btnSalaries.TabIndex = 12;
            this.btnSalaries.Text = "Wynagrodzenie";
            this.btnSalaries.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalaries.UseVisualStyleBackColor = true;
            // 
            // btnOrganizationeStructures
            // 
            this.btnOrganizationeStructures.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnOrganizationeStructures.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrganizationeStructures.Image = global::SystemHRUserInterface.Properties.Resources.internet_icon;
            this.btnOrganizationeStructures.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrganizationeStructures.Location = new System.Drawing.Point(283, 3);
            this.btnOrganizationeStructures.Name = "btnOrganizationeStructures";
            this.btnOrganizationeStructures.Size = new System.Drawing.Size(140, 60);
            this.btnOrganizationeStructures.TabIndex = 11;
            this.btnOrganizationeStructures.Text = "Struktury organizacyjne";
            this.btnOrganizationeStructures.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOrganizationeStructures.UseVisualStyleBackColor = true;
            // 
            // btnContracts
            // 
            this.btnContracts.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnContracts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContracts.Image = global::SystemHRUserInterface.Properties.Resources.edit_icon;
            this.btnContracts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContracts.Location = new System.Drawing.Point(143, 3);
            this.btnContracts.Name = "btnContracts";
            this.btnContracts.Size = new System.Drawing.Size(140, 60);
            this.btnContracts.TabIndex = 9;
            this.btnContracts.Text = "Umowy";
            this.btnContracts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnContracts.UseVisualStyleBackColor = true;
            // 
            // btnEmployee
            // 
            this.btnEmployee.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnEmployee.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.Image = global::SystemHRUserInterface.Properties.Resources.admin_icon;
            this.btnEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployee.Location = new System.Drawing.Point(3, 3);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(140, 60);
            this.btnEmployee.TabIndex = 10;
            this.btnEmployee.Text = "Pracownicy";
            this.btnEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEmployee.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ssMain);
            this.Controls.Add(this.tcMain);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System HR";
            this.tcMain.ResumeLayout(false);
            this.tpGeneral.ResumeLayout(false);
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpGeneral;
        private System.Windows.Forms.TabPage tpConfiguration;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripStatusLabel tsslVersion;
        private System.Windows.Forms.ToolStripStatusLabel tsslDataBase;
        private System.Windows.Forms.ToolStripStatusLabel tsslUser;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button btnPositions;
        private System.Windows.Forms.Button btnDepartments;
        private System.Windows.Forms.Button btnSalaries;
        private System.Windows.Forms.Button btnOrganizationeStructures;
        private System.Windows.Forms.Button btnContracts;
        private System.Windows.Forms.Button btnEmployee;
    }
}