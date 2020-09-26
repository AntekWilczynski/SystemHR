namespace SystemHRUserInterface.Forms.Employees
{
    partial class EmployeeAddForm
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
            this.lblEmployee = new System.Windows.Forms.Label();
            this.gbGeneral = new System.Windows.Forms.GroupBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.lblBirthDay = new System.Windows.Forms.Label();
            this.dtpDateBirth = new System.Windows.Forms.DateTimePicker();
            this.lblPesel = new System.Windows.Forms.Label();
            this.txtPESEL = new System.Windows.Forms.TextBox();
            this.pbEmployee = new System.Windows.Forms.PictureBox();
            this.gbGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployee.Location = new System.Drawing.Point(25, 30);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(239, 32);
            this.lblEmployee.TabIndex = 0;
            this.lblEmployee.Text = "Dane identyfikacyjne";
            // 
            // gbGeneral
            // 
            this.gbGeneral.Controls.Add(this.txtPESEL);
            this.gbGeneral.Controls.Add(this.lblPesel);
            this.gbGeneral.Controls.Add(this.dtpDateBirth);
            this.gbGeneral.Controls.Add(this.lblBirthDay);
            this.gbGeneral.Controls.Add(this.cbGender);
            this.gbGeneral.Controls.Add(this.lblGender);
            this.gbGeneral.Controls.Add(this.txtFirstName);
            this.gbGeneral.Controls.Add(this.txtLastName);
            this.gbGeneral.Controls.Add(this.lblFirstName);
            this.gbGeneral.Controls.Add(this.lblLastName);
            this.gbGeneral.Location = new System.Drawing.Point(31, 76);
            this.gbGeneral.Name = "gbGeneral";
            this.gbGeneral.Size = new System.Drawing.Size(479, 290);
            this.gbGeneral.TabIndex = 1;
            this.gbGeneral.TabStop = false;
            this.gbGeneral.Text = " ";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(6, 19);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(100, 26);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Nazwisko";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(6, 54);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(53, 26);
            this.lblFirstName.TabIndex = 3;
            this.lblFirstName.Text = "Imię";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(169, 16);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(235, 29);
            this.txtLastName.TabIndex = 4;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(168, 51);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(236, 29);
            this.txtFirstName.TabIndex = 5;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(6, 89);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(52, 26);
            this.lblGender.TabIndex = 6;
            this.lblGender.Text = "Płeć";
            // 
            // cbGender
            // 
            this.cbGender.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Location = new System.Drawing.Point(168, 86);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(235, 29);
            this.cbGender.TabIndex = 7;
            // 
            // lblBirthDay
            // 
            this.lblBirthDay.AutoSize = true;
            this.lblBirthDay.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthDay.Location = new System.Drawing.Point(7, 124);
            this.lblBirthDay.Name = "lblBirthDay";
            this.lblBirthDay.Size = new System.Drawing.Size(155, 26);
            this.lblBirthDay.TabIndex = 8;
            this.lblBirthDay.Text = "Data urodzenia";
            // 
            // dtpDateBirth
            // 
            this.dtpDateBirth.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateBirth.Location = new System.Drawing.Point(169, 121);
            this.dtpDateBirth.Name = "dtpDateBirth";
            this.dtpDateBirth.Size = new System.Drawing.Size(235, 29);
            this.dtpDateBirth.TabIndex = 9;
            // 
            // lblPesel
            // 
            this.lblPesel.AutoSize = true;
            this.lblPesel.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesel.Location = new System.Drawing.Point(6, 160);
            this.lblPesel.Name = "lblPesel";
            this.lblPesel.Size = new System.Drawing.Size(67, 26);
            this.lblPesel.TabIndex = 10;
            this.lblPesel.Text = "PESEL";
            // 
            // txtPESEL
            // 
            this.txtPESEL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPESEL.Location = new System.Drawing.Point(167, 157);
            this.txtPESEL.Name = "txtPESEL";
            this.txtPESEL.Size = new System.Drawing.Size(236, 29);
            this.txtPESEL.TabIndex = 11;
            // 
            // pbEmployee
            // 
            this.pbEmployee.Image = global::SystemHRUserInterface.Properties.Resources.admin_icon;
            this.pbEmployee.Location = new System.Drawing.Point(744, 12);
            this.pbEmployee.Name = "pbEmployee";
            this.pbEmployee.Size = new System.Drawing.Size(128, 123);
            this.pbEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEmployee.TabIndex = 2;
            this.pbEmployee.TabStop = false;
            // 
            // EmployeeAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.pbEmployee);
            this.Controls.Add(this.gbGeneral);
            this.Controls.Add(this.lblEmployee);
            this.Name = "EmployeeAddForm";
            this.Text = "Dodaj pracownika";
            this.gbGeneral.ResumeLayout(false);
            this.gbGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.GroupBox gbGeneral;
        private System.Windows.Forms.TextBox txtPESEL;
        private System.Windows.Forms.Label lblPesel;
        private System.Windows.Forms.DateTimePicker dtpDateBirth;
        private System.Windows.Forms.Label lblBirthDay;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.PictureBox pbEmployee;
    }
}