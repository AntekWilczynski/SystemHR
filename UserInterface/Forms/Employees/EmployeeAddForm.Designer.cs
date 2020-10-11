namespace SystemHR.UserInterface.Forms.Employees
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
            this.components = new System.ComponentModel.Container();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.gbGeneral = new System.Windows.Forms.GroupBox();
            this.txtPESEL = new System.Windows.Forms.TextBox();
            this.lblPesel = new System.Windows.Forms.Label();
            this.dtpDateBirth = new System.Windows.Forms.DateTimePicker();
            this.lblBirthDay = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.bsGender = new System.Windows.Forms.BindingSource(this.components);
            this.lblGender = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.pbEmployee = new System.Windows.Forms.PictureBox();
            this.gbContact = new System.Windows.Forms.GroupBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.lbEmailAddress = new System.Windows.Forms.Label();
            this.gbIdentityCard = new System.Windows.Forms.GroupBox();
            this.dtpExpirationIdentityCard = new System.Windows.Forms.DateTimePicker();
            this.dtpIssueDateIdentityCard = new System.Windows.Forms.DateTimePicker();
            this.lblExpirationIdentityCard = new System.Windows.Forms.Label();
            this.txtIdentityCard = new System.Windows.Forms.TextBox();
            this.lblIdentityCard = new System.Windows.Forms.Label();
            this.lblUssueDateIdentityCard = new System.Windows.Forms.Label();
            this.gbPassport = new System.Windows.Forms.GroupBox();
            this.dtpExpirationPassport = new System.Windows.Forms.DateTimePicker();
            this.dtpUssueDatePassport = new System.Windows.Forms.DateTimePicker();
            this.lblExpirationPassport = new System.Windows.Forms.Label();
            this.txtPassport = new System.Windows.Forms.TextBox();
            this.lblPassport = new System.Windows.Forms.Label();
            this.lblUssueDatePassport = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.epLastName = new System.Windows.Forms.ErrorProvider(this.components);
            this.epFirstName = new System.Windows.Forms.ErrorProvider(this.components);
            this.epPESEL = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsGender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployee)).BeginInit();
            this.gbContact.SuspendLayout();
            this.gbIdentityCard.SuspendLayout();
            this.gbPassport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epLastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epFirstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPESEL)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployee.Location = new System.Drawing.Point(23, 19);
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
            this.gbGeneral.Location = new System.Drawing.Point(20, 80);
            this.gbGeneral.Name = "gbGeneral";
            this.gbGeneral.Size = new System.Drawing.Size(420, 230);
            this.gbGeneral.TabIndex = 1;
            this.gbGeneral.TabStop = false;
            this.gbGeneral.Text = " Ogólne";
            // 
            // txtPESEL
            // 
            this.txtPESEL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPESEL.Location = new System.Drawing.Point(140, 160);
            this.txtPESEL.Name = "txtPESEL";
            this.txtPESEL.Size = new System.Drawing.Size(240, 29);
            this.txtPESEL.TabIndex = 11;
            this.txtPESEL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPESEL_KeyPress);
            this.txtPESEL.Validated += new System.EventHandler(this.txtPESEL_Validated);
            // 
            // lblPesel
            // 
            this.lblPesel.AutoSize = true;
            this.lblPesel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesel.Location = new System.Drawing.Point(5, 160);
            this.lblPesel.Name = "lblPesel";
            this.lblPesel.Size = new System.Drawing.Size(52, 21);
            this.lblPesel.TabIndex = 10;
            this.lblPesel.Text = "PESEL";
            // 
            // dtpDateBirth
            // 
            this.dtpDateBirth.CustomFormat = " ";
            this.dtpDateBirth.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateBirth.Location = new System.Drawing.Point(140, 125);
            this.dtpDateBirth.Name = "dtpDateBirth";
            this.dtpDateBirth.Size = new System.Drawing.Size(240, 29);
            this.dtpDateBirth.TabIndex = 9;
            this.dtpDateBirth.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
            // 
            // lblBirthDay
            // 
            this.lblBirthDay.AutoSize = true;
            this.lblBirthDay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthDay.Location = new System.Drawing.Point(5, 125);
            this.lblBirthDay.Name = "lblBirthDay";
            this.lblBirthDay.Size = new System.Drawing.Size(115, 21);
            this.lblBirthDay.TabIndex = 8;
            this.lblBirthDay.Text = "Data urodzenia";
            // 
            // cbGender
            // 
            this.cbGender.DataSource = this.bsGender;
            this.cbGender.DisplayMember = "Value";
            this.cbGender.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Location = new System.Drawing.Point(140, 90);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(240, 29);
            this.cbGender.TabIndex = 7;
            this.cbGender.ValueMember = "Id";
            // 
            // bsGender
            // 
            this.bsGender.DataSource = typeof(SystemHR.DataAccessLayer.Models.Dictionaries.GenderModel);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(5, 90);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(38, 21);
            this.lblGender.TabIndex = 6;
            this.lblGender.Text = "Płeć";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(140, 55);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(240, 29);
            this.txtFirstName.TabIndex = 5;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(140, 20);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(240, 29);
            this.txtLastName.TabIndex = 4;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(5, 55);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(44, 21);
            this.lblFirstName.TabIndex = 3;
            this.lblFirstName.Text = "Imię";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(5, 20);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(84, 21);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Nazwisko";
            // 
            // pbEmployee
            // 
            this.pbEmployee.Image = global::SystemHR.UserInterface.Properties.Resources.admin_icon;
            this.pbEmployee.Location = new System.Drawing.Point(812, 10);
            this.pbEmployee.Name = "pbEmployee";
            this.pbEmployee.Size = new System.Drawing.Size(60, 64);
            this.pbEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEmployee.TabIndex = 2;
            this.pbEmployee.TabStop = false;
            // 
            // gbContact
            // 
            this.gbContact.Controls.Add(this.txtPhoneNumber);
            this.gbContact.Controls.Add(this.label1);
            this.gbContact.Controls.Add(this.txtEmailAddress);
            this.gbContact.Controls.Add(this.lbEmailAddress);
            this.gbContact.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbContact.Location = new System.Drawing.Point(20, 310);
            this.gbContact.Name = "gbContact";
            this.gbContact.Size = new System.Drawing.Size(420, 130);
            this.gbContact.TabIndex = 3;
            this.gbContact.TabStop = false;
            this.gbContact.Text = "Kontakt";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(140, 20);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(240, 29);
            this.txtPhoneNumber.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nr. telefonu";
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailAddress.Location = new System.Drawing.Point(140, 55);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(240, 29);
            this.txtEmailAddress.TabIndex = 3;
            // 
            // lbEmailAddress
            // 
            this.lbEmailAddress.AutoSize = true;
            this.lbEmailAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmailAddress.Location = new System.Drawing.Point(5, 55);
            this.lbEmailAddress.Name = "lbEmailAddress";
            this.lbEmailAddress.Size = new System.Drawing.Size(92, 21);
            this.lbEmailAddress.TabIndex = 2;
            this.lbEmailAddress.Text = "Adres email";
            // 
            // gbIdentityCard
            // 
            this.gbIdentityCard.Controls.Add(this.dtpExpirationIdentityCard);
            this.gbIdentityCard.Controls.Add(this.dtpIssueDateIdentityCard);
            this.gbIdentityCard.Controls.Add(this.lblExpirationIdentityCard);
            this.gbIdentityCard.Controls.Add(this.txtIdentityCard);
            this.gbIdentityCard.Controls.Add(this.lblIdentityCard);
            this.gbIdentityCard.Controls.Add(this.lblUssueDateIdentityCard);
            this.gbIdentityCard.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbIdentityCard.Location = new System.Drawing.Point(450, 80);
            this.gbIdentityCard.Name = "gbIdentityCard";
            this.gbIdentityCard.Size = new System.Drawing.Size(420, 160);
            this.gbIdentityCard.TabIndex = 6;
            this.gbIdentityCard.TabStop = false;
            this.gbIdentityCard.Text = "Dowód osobisty";
            // 
            // dtpExpirationIdentityCard
            // 
            this.dtpExpirationIdentityCard.CustomFormat = " ";
            this.dtpExpirationIdentityCard.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpExpirationIdentityCard.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpExpirationIdentityCard.Location = new System.Drawing.Point(140, 90);
            this.dtpExpirationIdentityCard.Name = "dtpExpirationIdentityCard";
            this.dtpExpirationIdentityCard.Size = new System.Drawing.Size(240, 29);
            this.dtpExpirationIdentityCard.TabIndex = 12;
            this.dtpExpirationIdentityCard.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
            // 
            // dtpIssueDateIdentityCard
            // 
            this.dtpIssueDateIdentityCard.CustomFormat = " ";
            this.dtpIssueDateIdentityCard.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpIssueDateIdentityCard.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpIssueDateIdentityCard.Location = new System.Drawing.Point(140, 55);
            this.dtpIssueDateIdentityCard.Name = "dtpIssueDateIdentityCard";
            this.dtpIssueDateIdentityCard.Size = new System.Drawing.Size(240, 29);
            this.dtpIssueDateIdentityCard.TabIndex = 13;
            this.dtpIssueDateIdentityCard.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
            // 
            // lblExpirationIdentityCard
            // 
            this.lblExpirationIdentityCard.AutoSize = true;
            this.lblExpirationIdentityCard.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpirationIdentityCard.Location = new System.Drawing.Point(5, 90);
            this.lblExpirationIdentityCard.Name = "lblExpirationIdentityCard";
            this.lblExpirationIdentityCard.Size = new System.Drawing.Size(109, 21);
            this.lblExpirationIdentityCard.TabIndex = 6;
            this.lblExpirationIdentityCard.Text = "Data ważności";
            // 
            // txtIdentityCard
            // 
            this.txtIdentityCard.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentityCard.Location = new System.Drawing.Point(140, 20);
            this.txtIdentityCard.Name = "txtIdentityCard";
            this.txtIdentityCard.Size = new System.Drawing.Size(240, 29);
            this.txtIdentityCard.TabIndex = 5;
            // 
            // lblIdentityCard
            // 
            this.lblIdentityCard.AutoSize = true;
            this.lblIdentityCard.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentityCard.Location = new System.Drawing.Point(5, 20);
            this.lblIdentityCard.Name = "lblIdentityCard";
            this.lblIdentityCard.Size = new System.Drawing.Size(92, 21);
            this.lblIdentityCard.TabIndex = 4;
            this.lblIdentityCard.Text = "Nr. dowodu";
            // 
            // lblUssueDateIdentityCard
            // 
            this.lblUssueDateIdentityCard.AutoSize = true;
            this.lblUssueDateIdentityCard.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUssueDateIdentityCard.Location = new System.Drawing.Point(5, 55);
            this.lblUssueDateIdentityCard.Name = "lblUssueDateIdentityCard";
            this.lblUssueDateIdentityCard.Size = new System.Drawing.Size(104, 21);
            this.lblUssueDateIdentityCard.TabIndex = 2;
            this.lblUssueDateIdentityCard.Text = "Data wydania";
            // 
            // gbPassport
            // 
            this.gbPassport.Controls.Add(this.dtpExpirationPassport);
            this.gbPassport.Controls.Add(this.dtpUssueDatePassport);
            this.gbPassport.Controls.Add(this.lblExpirationPassport);
            this.gbPassport.Controls.Add(this.txtPassport);
            this.gbPassport.Controls.Add(this.lblPassport);
            this.gbPassport.Controls.Add(this.lblUssueDatePassport);
            this.gbPassport.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPassport.Location = new System.Drawing.Point(450, 260);
            this.gbPassport.Name = "gbPassport";
            this.gbPassport.Size = new System.Drawing.Size(423, 160);
            this.gbPassport.TabIndex = 14;
            this.gbPassport.TabStop = false;
            this.gbPassport.Text = "Paszport";
            // 
            // dtpExpirationPassport
            // 
            this.dtpExpirationPassport.CustomFormat = " ";
            this.dtpExpirationPassport.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpExpirationPassport.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpExpirationPassport.Location = new System.Drawing.Point(140, 90);
            this.dtpExpirationPassport.Name = "dtpExpirationPassport";
            this.dtpExpirationPassport.Size = new System.Drawing.Size(240, 29);
            this.dtpExpirationPassport.TabIndex = 12;
            this.dtpExpirationPassport.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
            // 
            // dtpUssueDatePassport
            // 
            this.dtpUssueDatePassport.CustomFormat = " ";
            this.dtpUssueDatePassport.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpUssueDatePassport.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpUssueDatePassport.Location = new System.Drawing.Point(140, 55);
            this.dtpUssueDatePassport.Name = "dtpUssueDatePassport";
            this.dtpUssueDatePassport.Size = new System.Drawing.Size(240, 29);
            this.dtpUssueDatePassport.TabIndex = 13;
            this.dtpUssueDatePassport.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
            // 
            // lblExpirationPassport
            // 
            this.lblExpirationPassport.AutoSize = true;
            this.lblExpirationPassport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpirationPassport.Location = new System.Drawing.Point(5, 90);
            this.lblExpirationPassport.Name = "lblExpirationPassport";
            this.lblExpirationPassport.Size = new System.Drawing.Size(109, 21);
            this.lblExpirationPassport.TabIndex = 6;
            this.lblExpirationPassport.Text = "Data ważności";
            // 
            // txtPassport
            // 
            this.txtPassport.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassport.Location = new System.Drawing.Point(140, 20);
            this.txtPassport.Name = "txtPassport";
            this.txtPassport.Size = new System.Drawing.Size(240, 29);
            this.txtPassport.TabIndex = 5;
            // 
            // lblPassport
            // 
            this.lblPassport.AutoSize = true;
            this.lblPassport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassport.Location = new System.Drawing.Point(5, 20);
            this.lblPassport.Name = "lblPassport";
            this.lblPassport.Size = new System.Drawing.Size(92, 21);
            this.lblPassport.TabIndex = 4;
            this.lblPassport.Text = "Nr. dowodu";
            // 
            // lblUssueDatePassport
            // 
            this.lblUssueDatePassport.AutoSize = true;
            this.lblUssueDatePassport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUssueDatePassport.Location = new System.Drawing.Point(5, 55);
            this.lblUssueDatePassport.Name = "lblUssueDatePassport";
            this.lblUssueDatePassport.Size = new System.Drawing.Size(104, 21);
            this.lblUssueDatePassport.TabIndex = 2;
            this.lblUssueDatePassport.Text = "Data wydania";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::SystemHR.UserInterface.Properties.Resources.edit_icon;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(590, 471);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(117, 40);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Zapisz";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = global::SystemHR.UserInterface.Properties.Resources.delete_icon;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(713, 471);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(117, 40);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // epLastName
            // 
            this.epLastName.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epLastName.ContainerControl = this;
            // 
            // epFirstName
            // 
            this.epFirstName.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epFirstName.ContainerControl = this;
            // 
            // epPESEL
            // 
            this.epPESEL.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epPESEL.ContainerControl = this;
            // 
            // EmployeeAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbPassport);
            this.Controls.Add(this.gbIdentityCard);
            this.Controls.Add(this.gbContact);
            this.Controls.Add(this.pbEmployee);
            this.Controls.Add(this.gbGeneral);
            this.Controls.Add(this.lblEmployee);
            this.KeyPreview = true;
            this.Name = "EmployeeAddForm";
            this.Text = "Dodaj pracownika";
            this.gbGeneral.ResumeLayout(false);
            this.gbGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsGender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployee)).EndInit();
            this.gbContact.ResumeLayout(false);
            this.gbContact.PerformLayout();
            this.gbIdentityCard.ResumeLayout(false);
            this.gbIdentityCard.PerformLayout();
            this.gbPassport.ResumeLayout(false);
            this.gbPassport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epLastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epFirstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPESEL)).EndInit();
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
        private System.Windows.Forms.GroupBox gbContact;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.Label lbEmailAddress;
        private System.Windows.Forms.GroupBox gbIdentityCard;
        private System.Windows.Forms.TextBox txtIdentityCard;
        private System.Windows.Forms.Label lblIdentityCard;
        private System.Windows.Forms.Label lblUssueDateIdentityCard;
        private System.Windows.Forms.DateTimePicker dtpExpirationIdentityCard;
        private System.Windows.Forms.DateTimePicker dtpIssueDateIdentityCard;
        private System.Windows.Forms.Label lblExpirationIdentityCard;
        private System.Windows.Forms.GroupBox gbPassport;
        private System.Windows.Forms.DateTimePicker dtpExpirationPassport;
        private System.Windows.Forms.DateTimePicker dtpUssueDatePassport;
        private System.Windows.Forms.Label lblExpirationPassport;
        private System.Windows.Forms.TextBox txtPassport;
        private System.Windows.Forms.Label lblPassport;
        private System.Windows.Forms.Label lblUssueDatePassport;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.BindingSource bsGender;
        private System.Windows.Forms.ErrorProvider epLastName;
        private System.Windows.Forms.ErrorProvider epFirstName;
        private System.Windows.Forms.ErrorProvider epPESEL;
    }
}