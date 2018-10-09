namespace TaxCalculator
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
            this.lblTaxCal = new System.Windows.Forms.Label();
            this.lblEmpID = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblHourlyRate = new System.Windows.Forms.Label();
            this.lblHoursWorked = new System.Windows.Forms.Label();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtHourlyRate = new System.Windows.Forms.TextBox();
            this.txtHoursWorked = new System.Windows.Forms.TextBox();
            this.comboBoxDepartment = new System.Windows.Forms.ComboBox();
            this.btnCreateEmployee = new System.Windows.Forms.Button();
            this.btnCreateContactor = new System.Windows.Forms.Button();
            this.btnEmployeeTaxPayable = new System.Windows.Forms.Button();
            this.btnContractorTaxPayable = new System.Windows.Forms.Button();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.btnQuickFillEmployee = new System.Windows.Forms.Button();
            this.btnQuickFillContractor = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // lblTaxCal
            // 
            this.lblTaxCal.AutoSize = true;
            this.lblTaxCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxCal.Location = new System.Drawing.Point(32, 24);
            this.lblTaxCal.Margin = new System.Windows.Forms.Padding(5, 0, 3, 5);
            this.lblTaxCal.Name = "lblTaxCal";
            this.lblTaxCal.Size = new System.Drawing.Size(198, 32);
            this.lblTaxCal.TabIndex = 0;
            this.lblTaxCal.Text = "Tax Calculator";
            // 
            // lblEmpID
            // 
            this.lblEmpID.AutoSize = true;
            this.lblEmpID.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpID.Location = new System.Drawing.Point(34, 100);
            this.lblEmpID.Margin = new System.Windows.Forms.Padding(5, 0, 3, 5);
            this.lblEmpID.Name = "lblEmpID";
            this.lblEmpID.Size = new System.Drawing.Size(110, 19);
            this.lblEmpID.TabIndex = 1;
            this.lblEmpID.Text = "Employee ID:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(34, 140);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(5, 0, 3, 5);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(97, 19);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "First Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 180);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Last Name:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(34, 220);
            this.lblGender.Margin = new System.Windows.Forms.Padding(5, 0, 3, 5);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(70, 19);
            this.lblGender.TabIndex = 4;
            this.lblGender.Text = "Gender:";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.Location = new System.Drawing.Point(34, 260);
            this.lblDepartment.Margin = new System.Windows.Forms.Padding(5, 0, 3, 5);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(105, 19);
            this.lblDepartment.TabIndex = 5;
            this.lblDepartment.Text = "Department:";
            this.lblDepartment.Click += new System.EventHandler(this.lblDepartment_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(34, 300);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(5, 0, 3, 5);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(55, 19);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email:";
            // 
            // lblHourlyRate
            // 
            this.lblHourlyRate.AutoSize = true;
            this.lblHourlyRate.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHourlyRate.Location = new System.Drawing.Point(34, 340);
            this.lblHourlyRate.Margin = new System.Windows.Forms.Padding(5, 0, 3, 5);
            this.lblHourlyRate.Name = "lblHourlyRate";
            this.lblHourlyRate.Size = new System.Drawing.Size(103, 19);
            this.lblHourlyRate.TabIndex = 7;
            this.lblHourlyRate.Text = "Hourly Rate:";
            // 
            // lblHoursWorked
            // 
            this.lblHoursWorked.AutoSize = true;
            this.lblHoursWorked.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoursWorked.Location = new System.Drawing.Point(34, 380);
            this.lblHoursWorked.Margin = new System.Windows.Forms.Padding(5, 0, 3, 5);
            this.lblHoursWorked.Name = "lblHoursWorked";
            this.lblHoursWorked.Size = new System.Drawing.Size(123, 19);
            this.lblHoursWorked.TabIndex = 8;
            this.lblHoursWorked.Text = "Hours Worked:";
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(189, 97);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(311, 23);
            this.txtEmployeeID.TabIndex = 9;
            this.txtEmployeeID.TextChanged += new System.EventHandler(this.txtEmployeeID_TextChanged);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(189, 137);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(311, 23);
            this.txtFirstName.TabIndex = 10;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(189, 177);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(311, 23);
            this.txtSurname.TabIndex = 11;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(189, 296);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(311, 23);
            this.txtEmail.TabIndex = 13;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtHourlyRate
            // 
            this.txtHourlyRate.Location = new System.Drawing.Point(189, 336);
            this.txtHourlyRate.Name = "txtHourlyRate";
            this.txtHourlyRate.Size = new System.Drawing.Size(311, 23);
            this.txtHourlyRate.TabIndex = 14;
            // 
            // txtHoursWorked
            // 
            this.txtHoursWorked.Location = new System.Drawing.Point(189, 376);
            this.txtHoursWorked.Name = "txtHoursWorked";
            this.txtHoursWorked.Size = new System.Drawing.Size(311, 23);
            this.txtHoursWorked.TabIndex = 15;
            this.txtHoursWorked.TextChanged += new System.EventHandler(this.txtHoursWorked_TextChanged);
            // 
            // comboBoxDepartment
            // 
            this.comboBoxDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDepartment.FormattingEnabled = true;
            this.comboBoxDepartment.Items.AddRange(new object[] {
            "Accounts",
            "Customer Service",
            "IT",
            "Administration"});
            this.comboBoxDepartment.Location = new System.Drawing.Point(189, 255);
            this.comboBoxDepartment.Name = "comboBoxDepartment";
            this.comboBoxDepartment.Size = new System.Drawing.Size(311, 24);
            this.comboBoxDepartment.TabIndex = 16;
            // 
            // btnCreateEmployee
            // 
            this.btnCreateEmployee.Location = new System.Drawing.Point(550, 97);
            this.btnCreateEmployee.Name = "btnCreateEmployee";
            this.btnCreateEmployee.Size = new System.Drawing.Size(170, 55);
            this.btnCreateEmployee.TabIndex = 17;
            this.btnCreateEmployee.Text = "Create Employee";
            this.btnCreateEmployee.UseVisualStyleBackColor = true;
            this.btnCreateEmployee.Click += new System.EventHandler(this.btnCreateEmployee_Click);
            // 
            // btnCreateContactor
            // 
            this.btnCreateContactor.Location = new System.Drawing.Point(550, 163);
            this.btnCreateContactor.Name = "btnCreateContactor";
            this.btnCreateContactor.Size = new System.Drawing.Size(170, 55);
            this.btnCreateContactor.TabIndex = 18;
            this.btnCreateContactor.Text = "Create Contractor";
            this.btnCreateContactor.UseVisualStyleBackColor = true;
            this.btnCreateContactor.Click += new System.EventHandler(this.btnCreateContactor_Click);
            // 
            // btnEmployeeTaxPayable
            // 
            this.btnEmployeeTaxPayable.Location = new System.Drawing.Point(733, 97);
            this.btnEmployeeTaxPayable.Name = "btnEmployeeTaxPayable";
            this.btnEmployeeTaxPayable.Size = new System.Drawing.Size(170, 55);
            this.btnEmployeeTaxPayable.TabIndex = 19;
            this.btnEmployeeTaxPayable.Text = "Employee Tax Payable";
            this.btnEmployeeTaxPayable.UseVisualStyleBackColor = true;
            this.btnEmployeeTaxPayable.Click += new System.EventHandler(this.btnEmployeeTaxPayable_Click);
            // 
            // btnContractorTaxPayable
            // 
            this.btnContractorTaxPayable.Location = new System.Drawing.Point(733, 163);
            this.btnContractorTaxPayable.Name = "btnContractorTaxPayable";
            this.btnContractorTaxPayable.Size = new System.Drawing.Size(170, 55);
            this.btnContractorTaxPayable.TabIndex = 20;
            this.btnContractorTaxPayable.Text = "Contractor Tax Payable";
            this.btnContractorTaxPayable.UseVisualStyleBackColor = true;
            this.btnContractorTaxPayable.Click += new System.EventHandler(this.btnContractorTaxPayable_Click);
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Location = new System.Drawing.Point(550, 241);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(64, 18);
            this.lblDisplay.TabIndex = 21;
            this.lblDisplay.Text = "Display:";
            // 
            // txtDisplay
            // 
            this.txtDisplay.Location = new System.Drawing.Point(553, 278);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(350, 284);
            this.txtDisplay.TabIndex = 22;
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBoxGender.Location = new System.Drawing.Point(189, 215);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(311, 24);
            this.comboBoxGender.TabIndex = 23;
            // 
            // btnQuickFillEmployee
            // 
            this.btnQuickFillEmployee.Location = new System.Drawing.Point(12, 507);
            this.btnQuickFillEmployee.Name = "btnQuickFillEmployee";
            this.btnQuickFillEmployee.Size = new System.Drawing.Size(170, 55);
            this.btnQuickFillEmployee.TabIndex = 25;
            this.btnQuickFillEmployee.Text = "Quick Fill Employee";
            this.btnQuickFillEmployee.UseVisualStyleBackColor = true;
            this.btnQuickFillEmployee.Click += new System.EventHandler(this.btnQuickFillEmployee_Click);
            // 
            // btnQuickFillContractor
            // 
            this.btnQuickFillContractor.Location = new System.Drawing.Point(199, 507);
            this.btnQuickFillContractor.Name = "btnQuickFillContractor";
            this.btnQuickFillContractor.Size = new System.Drawing.Size(170, 55);
            this.btnQuickFillContractor.TabIndex = 26;
            this.btnQuickFillContractor.Text = "Quick Fill Contractor";
            this.btnQuickFillContractor.UseVisualStyleBackColor = true;
            this.btnQuickFillContractor.Click += new System.EventHandler(this.btnQuickFillContractor_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 574);
            this.Controls.Add(this.btnQuickFillContractor);
            this.Controls.Add(this.btnQuickFillEmployee);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.btnContractorTaxPayable);
            this.Controls.Add(this.btnEmployeeTaxPayable);
            this.Controls.Add(this.btnCreateContactor);
            this.Controls.Add(this.btnCreateEmployee);
            this.Controls.Add(this.comboBoxDepartment);
            this.Controls.Add(this.txtHoursWorked);
            this.Controls.Add(this.txtHourlyRate);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtEmployeeID);
            this.Controls.Add(this.lblHoursWorked);
            this.Controls.Add(this.lblHourlyRate);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblEmpID);
            this.Controls.Add(this.lblTaxCal);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmMain";
            this.Text = "Tax Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTaxCal;
        private System.Windows.Forms.Label lblEmpID;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblHourlyRate;
        private System.Windows.Forms.Label lblHoursWorked;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtHourlyRate;
        private System.Windows.Forms.TextBox txtHoursWorked;
        private System.Windows.Forms.ComboBox comboBoxDepartment;
        private System.Windows.Forms.Button btnCreateEmployee;
        private System.Windows.Forms.Button btnCreateContactor;
        private System.Windows.Forms.Button btnEmployeeTaxPayable;
        private System.Windows.Forms.Button btnContractorTaxPayable;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.Button btnQuickFillEmployee;
        private System.Windows.Forms.Button btnQuickFillContractor;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

