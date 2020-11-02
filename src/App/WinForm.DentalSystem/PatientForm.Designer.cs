using System;

namespace WinForm.DentalSystem
{
    partial class PatientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnHome = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDoB = new System.Windows.Forms.DateTimePicker();
            this.txtHealth = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnHealth = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTreatment = new System.Windows.Forms.TextBox();
            this.txtDiagnosis = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnSavePatient = new System.Windows.Forms.Button();
            this.AppointmentPanel = new System.Windows.Forms.GroupBox();
            this.txtEndTime = new System.Windows.Forms.DateTimePicker();
            this.label19 = new System.Windows.Forms.Label();
            this.txtAppointmentReason = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.BtnSaveAppointment = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtStartTime = new System.Windows.Forms.DateTimePicker();
            this.TxtAptDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.firstNameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.lastNameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.phoneErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.AppointmentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.firstNameErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastNameErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.lblPatientName);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.BtnHome);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(893, 77);
            this.panel1.TabIndex = 0;
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPatientName.ForeColor = System.Drawing.Color.White;
            this.lblPatientName.Location = new System.Drawing.Point(394, 22);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(0, 23);
            this.lblPatientName.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(76, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Dashboard";
            // 
            // BtnHome
            // 
            this.BtnHome.BackColor = System.Drawing.Color.Transparent;
            this.BtnHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnHome.BackgroundImage")));
            this.BtnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnHome.Location = new System.Drawing.Point(21, 15);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(49, 40);
            this.BtnHome.TabIndex = 0;
            this.BtnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnHome.UseVisualStyleBackColor = false;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(340, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(113, 40);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(187, 27);
            this.txtFirstName.TabIndex = 2;
            this.txtFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.txtFirstName_Validating);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(438, 40);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(187, 27);
            this.txtLastName.TabIndex = 2;
            this.txtLastName.Validating += new System.ComponentModel.CancelEventHandler(this.txtLastName_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Date of Birth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(32, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Gender";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(438, 96);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(187, 27);
            this.txtPhone.TabIndex = 2;
            this.txtPhone.Validating += new System.ComponentModel.CancelEventHandler(this.txtPhone_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(306, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Phone Number";
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Location = new System.Drawing.Point(101, 160);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(64, 24);
            this.radMale.TabIndex = 3;
            this.radMale.TabStop = true;
            this.radMale.Text = "Male";
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.Location = new System.Drawing.Point(101, 190);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(79, 24);
            this.radFemale.TabIndex = 3;
            this.radFemale.TabStop = true;
            this.radFemale.Text = "Female";
            this.radFemale.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.txtDoB);
            this.groupBox1.Controls.Add(this.txtHealth);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.radFemale);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.radMale);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(206, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(640, 246);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Basic Information";
            // 
            // txtDoB
            // 
            this.txtDoB.CustomFormat = "dd/MM/yyyy";
            this.txtDoB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDoB.Location = new System.Drawing.Point(114, 94);
            this.txtDoB.Name = "txtDoB";
            this.txtDoB.Size = new System.Drawing.Size(186, 27);
            this.txtDoB.TabIndex = 6;
            // 
            // txtHealth
            // 
            this.txtHealth.Location = new System.Drawing.Point(438, 162);
            this.txtHealth.Multiline = true;
            this.txtHealth.Name = "txtHealth";
            this.txtHealth.Size = new System.Drawing.Size(187, 69);
            this.txtHealth.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(322, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Health Notes";
            // 
            // BtnHealth
            // 
            this.BtnHealth.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnHealth.Location = new System.Drawing.Point(21, 586);
            this.BtnHealth.Name = "BtnHealth";
            this.BtnHealth.Size = new System.Drawing.Size(158, 40);
            this.BtnHealth.TabIndex = 3;
            this.BtnHealth.Text = "Generate Form";
            this.BtnHealth.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(12, 164);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Xray";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(306, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 20);
            this.label12.TabIndex = 1;
            this.label12.Text = "Treatments";
            // 
            // txtTreatment
            // 
            this.txtTreatment.Location = new System.Drawing.Point(405, 43);
            this.txtTreatment.Multiline = true;
            this.txtTreatment.Name = "txtTreatment";
            this.txtTreatment.Size = new System.Drawing.Size(220, 82);
            this.txtTreatment.TabIndex = 2;
            // 
            // txtDiagnosis
            // 
            this.txtDiagnosis.Location = new System.Drawing.Point(101, 47);
            this.txtDiagnosis.Multiline = true;
            this.txtDiagnosis.Name = "txtDiagnosis";
            this.txtDiagnosis.Size = new System.Drawing.Size(199, 78);
            this.txtDiagnosis.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(12, 43);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 20);
            this.label13.TabIndex = 1;
            this.label13.Text = "Diagnosis";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtTreatment);
            this.groupBox2.Controls.Add(this.txtDiagnosis);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(206, 356);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(640, 207);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Procedures and Treatments";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button3.Location = new System.Drawing.Point(405, 158);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 32);
            this.button3.TabIndex = 3;
            this.button3.Text = "Upload File";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(286, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Consent Form";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button2.Location = new System.Drawing.Point(101, 158);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 32);
            this.button2.TabIndex = 3;
            this.button2.Text = "Upload Image";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // BtnSavePatient
            // 
            this.BtnSavePatient.BackColor = System.Drawing.Color.Silver;
            this.BtnSavePatient.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSavePatient.Location = new System.Drawing.Point(430, 583);
            this.BtnSavePatient.Name = "BtnSavePatient";
            this.BtnSavePatient.Size = new System.Drawing.Size(186, 43);
            this.BtnSavePatient.TabIndex = 2;
            this.BtnSavePatient.Text = "Save Changes";
            this.BtnSavePatient.UseVisualStyleBackColor = false;
            this.BtnSavePatient.Click += new System.EventHandler(this.BtnSavePatient_Click);
            // 
            // AppointmentPanel
            // 
            this.AppointmentPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.AppointmentPanel.Controls.Add(this.txtEndTime);
            this.AppointmentPanel.Controls.Add(this.label19);
            this.AppointmentPanel.Controls.Add(this.txtAppointmentReason);
            this.AppointmentPanel.Controls.Add(this.label18);
            this.AppointmentPanel.Controls.Add(this.BtnSaveAppointment);
            this.AppointmentPanel.Controls.Add(this.label11);
            this.AppointmentPanel.Controls.Add(this.txtStartTime);
            this.AppointmentPanel.Controls.Add(this.TxtAptDate);
            this.AppointmentPanel.Controls.Add(this.label9);
            this.AppointmentPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AppointmentPanel.Location = new System.Drawing.Point(13, 95);
            this.AppointmentPanel.Name = "AppointmentPanel";
            this.AppointmentPanel.Size = new System.Drawing.Size(171, 468);
            this.AppointmentPanel.TabIndex = 5;
            this.AppointmentPanel.TabStop = false;
            this.AppointmentPanel.Text = "Appointment";
            // 
            // txtEndTime
            // 
            this.txtEndTime.CustomFormat = "HH:mm";
            this.txtEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtEndTime.Location = new System.Drawing.Point(8, 204);
            this.txtEndTime.Name = "txtEndTime";
            this.txtEndTime.ShowUpDown = true;
            this.txtEndTime.Size = new System.Drawing.Size(134, 27);
            this.txtEndTime.TabIndex = 6;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(8, 177);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(72, 20);
            this.label19.TabIndex = 1;
            this.label19.Text = "End Time";
            // 
            // txtAppointmentReason
            // 
            this.txtAppointmentReason.Location = new System.Drawing.Point(6, 261);
            this.txtAppointmentReason.Multiline = true;
            this.txtAppointmentReason.Name = "txtAppointmentReason";
            this.txtAppointmentReason.Size = new System.Drawing.Size(139, 62);
            this.txtAppointmentReason.TabIndex = 2;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(7, 238);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(58, 20);
            this.label18.TabIndex = 1;
            this.label18.Text = "Reason";
            // 
            // BtnSaveAppointment
            // 
            this.BtnSaveAppointment.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BtnSaveAppointment.Location = new System.Drawing.Point(28, 349);
            this.BtnSaveAppointment.Name = "BtnSaveAppointment";
            this.BtnSaveAppointment.Size = new System.Drawing.Size(114, 37);
            this.BtnSaveAppointment.TabIndex = 6;
            this.BtnSaveAppointment.Text = "Save";
            this.BtnSaveAppointment.UseVisualStyleBackColor = false;
            this.BtnSaveAppointment.Click += new System.EventHandler(this.BtnSaveAppointment_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(8, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 20);
            this.label11.TabIndex = 1;
            this.label11.Text = "Start Time";
            // 
            // txtStartTime
            // 
            this.txtStartTime.CustomFormat = "HH:mm";
            this.txtStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtStartTime.Location = new System.Drawing.Point(10, 136);
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.ShowUpDown = true;
            this.txtStartTime.Size = new System.Drawing.Size(134, 27);
            this.txtStartTime.TabIndex = 6;
            // 
            // TxtAptDate
            // 
            this.TxtAptDate.CustomFormat = "dd/MM/yyyy";
            this.TxtAptDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TxtAptDate.Location = new System.Drawing.Point(10, 67);
            this.TxtAptDate.MinDate = new System.DateTime(2020, 11, 1, 14, 35, 12, 937);
            this.TxtAptDate.Name = "TxtAptDate";
            this.TxtAptDate.Size = new System.Drawing.Size(134, 27);
            this.TxtAptDate.TabIndex = 6;
            this.TxtAptDate.Value = new System.DateTime(2020, 11, 1, 14, 35, 12, 937);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(7, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Date";
            // 
            // firstNameErrorProvider
            // 
            this.firstNameErrorProvider.ContainerControl = this;
            // 
            // lastNameErrorProvider
            // 
            this.lastNameErrorProvider.ContainerControl = this;
            // 
            // phoneErrorProvider
            // 
            this.phoneErrorProvider.ContainerControl = this;
            // 
            // PatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 642);
            this.Controls.Add(this.AppointmentPanel);
            this.Controls.Add(this.BtnSavePatient);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BtnHealth);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "PatientForm";
            this.Text = "Patient Form";
            this.Load += new System.EventHandler(this.PatientForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.AppointmentPanel.ResumeLayout(false);
            this.AppointmentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.firstNameErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastNameErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.RadioButton radFemale;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Button BtnHome;
        private System.Windows.Forms.Button BtnHealth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtHealth;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTreatment;
        private System.Windows.Forms.TextBox txtDiagnosis;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnSavePatient;
        private System.Windows.Forms.GroupBox AppointmentPanel;
        private System.Windows.Forms.Button BtnSaveAppointment;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker TxtAptDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker TxtAptTime;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.TextBox txtAppointmentReason;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DateTimePicker txtDoB;
        private System.Windows.Forms.DateTimePicker txtEndTime;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DateTimePicker txtStartTime;
        private System.Windows.Forms.ErrorProvider firstNameErrorProvider;
        private System.Windows.Forms.ErrorProvider lastNameErrorProvider;
        private System.Windows.Forms.ErrorProvider phoneErrorProvider;
    }
}