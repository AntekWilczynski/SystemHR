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
            this.btnEmployes = new System.Windows.Forms.Button();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnContracts = new System.Windows.Forms.Button();
            this.btnDepartments = new System.Windows.Forms.Button();
            this.btnOrganizationeStructures = new System.Windows.Forms.Button();
            this.btnSalaries = new System.Windows.Forms.Button();
            this.btnPositions = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.tcMain.SuspendLayout();
            this.tpConfiguration.SuspendLayout();
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
            this.tcMain.Size = new System.Drawing.Size(1008, 92);
            this.tcMain.TabIndex = 0;
            // 
            // tpGeneral
            // 
            this.tpGeneral.Location = new System.Drawing.Point(4, 22);
            this.tpGeneral.Name = "tpGeneral";
            this.tpGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tpGeneral.Size = new System.Drawing.Size(792, 114);
            this.tpGeneral.TabIndex = 0;
            this.tpGeneral.Text = "Ogólne";
            this.tpGeneral.UseVisualStyleBackColor = true;
            // 
            // tpConfiguration
            // 
            this.tpConfiguration.Controls.Add(this.splitter1);
            this.tpConfiguration.Controls.Add(this.btnPositions);
            this.tpConfiguration.Controls.Add(this.btnSalaries);
            this.tpConfiguration.Controls.Add(this.btnOrganizationeStructures);
            this.tpConfiguration.Controls.Add(this.btnDepartments);
            this.tpConfiguration.Controls.Add(this.btnEmployes);
            this.tpConfiguration.Controls.Add(this.btnContracts);
            this.tpConfiguration.Location = new System.Drawing.Point(4, 22);
            this.tpConfiguration.Name = "tpConfiguration";
            this.tpConfiguration.Padding = new System.Windows.Forms.Padding(3);
            this.tpConfiguration.Size = new System.Drawing.Size(1000, 66);
            this.tpConfiguration.TabIndex = 1;
            this.tpConfiguration.Text = "Konfiguracja";
            this.tpConfiguration.UseVisualStyleBackColor = true;
            // 
            // btnEmployes
            // 
            this.btnEmployes.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEmployes.Location = new System.Drawing.Point(153, 3);
            this.btnEmployes.Name = "btnEmployes";
            this.btnEmployes.Size = new System.Drawing.Size(150, 60);
            this.btnEmployes.TabIndex = 0;
            this.btnEmployes.Text = "Pracownicy";
            this.btnEmployes.UseVisualStyleBackColor = true;
            // 
            // ssMain
            // 
            this.ssMain.Location = new System.Drawing.Point(0, 428);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(1008, 22);
            this.ssMain.TabIndex = 1;
            this.ssMain.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 336);
            this.panel1.TabIndex = 2;
            // 
            // btnContracts
            // 
            this.btnContracts.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnContracts.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnContracts.Location = new System.Drawing.Point(3, 3);
            this.btnContracts.Name = "btnContracts";
            this.btnContracts.Size = new System.Drawing.Size(150, 60);
            this.btnContracts.TabIndex = 1;
            this.btnContracts.Text = "Umowy";
            this.btnContracts.UseVisualStyleBackColor = true;
            this.btnContracts.Click += new System.EventHandler(this.btnContracts_Click);
            // 
            // btnDepartments
            // 
            this.btnDepartments.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDepartments.Location = new System.Drawing.Point(303, 3);
            this.btnDepartments.Name = "btnDepartments";
            this.btnDepartments.Size = new System.Drawing.Size(150, 60);
            this.btnDepartments.TabIndex = 2;
            this.btnDepartments.Text = "Działy";
            this.btnDepartments.UseVisualStyleBackColor = true;
            // 
            // btnOrganizationeStructures
            // 
            this.btnOrganizationeStructures.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnOrganizationeStructures.Location = new System.Drawing.Point(453, 3);
            this.btnOrganizationeStructures.Name = "btnOrganizationeStructures";
            this.btnOrganizationeStructures.Size = new System.Drawing.Size(150, 60);
            this.btnOrganizationeStructures.TabIndex = 3;
            this.btnOrganizationeStructures.Text = "Struktura organizacyjna";
            this.btnOrganizationeStructures.UseVisualStyleBackColor = true;
            // 
            // btnSalaries
            // 
            this.btnSalaries.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSalaries.Location = new System.Drawing.Point(603, 3);
            this.btnSalaries.Name = "btnSalaries";
            this.btnSalaries.Size = new System.Drawing.Size(150, 60);
            this.btnSalaries.TabIndex = 4;
            this.btnSalaries.Text = "Wynagrodzenia";
            this.btnSalaries.UseVisualStyleBackColor = true;
            // 
            // btnPositions
            // 
            this.btnPositions.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPositions.Location = new System.Drawing.Point(753, 3);
            this.btnPositions.Name = "btnPositions";
            this.btnPositions.Size = new System.Drawing.Size(150, 60);
            this.btnPositions.TabIndex = 7;
            this.btnPositions.Text = "Stanowiska";
            this.btnPositions.UseVisualStyleBackColor = true;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(903, 3);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 60);
            this.splitter1.TabIndex = 8;
            this.splitter1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ssMain);
            this.Controls.Add(this.tcMain);
            this.Name = "MainForm";
            this.Text = "System HR";
            this.tcMain.ResumeLayout(false);
            this.tpConfiguration.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpGeneral;
        private System.Windows.Forms.TabPage tpConfiguration;
        private System.Windows.Forms.Button btnEmployes;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnContracts;
        private System.Windows.Forms.Button btnPositions;
        private System.Windows.Forms.Button btnDepartments;
        private System.Windows.Forms.Button btnOrganizationeStructures;
        private System.Windows.Forms.Button btnSalaries;
        private System.Windows.Forms.Splitter splitter1;
    }
}