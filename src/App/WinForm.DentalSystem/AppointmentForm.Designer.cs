using System;
using System.Windows.Forms;

namespace WinForm.DentalSystem
{
    partial class AppointmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppointmentForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPatientName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AptDuration = new System.Windows.Forms.ComboBox();
            this.BtnAppointmentSave = new System.Windows.Forms.Button();
            this.AptReason = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AptDate = new System.Windows.Forms.DateTimePicker();
            this.AptTime = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.patientListToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(234, 562);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("dashboardToolStripMenuItem.Image")));
            this.dashboardToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(230, 32);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            // 
            // patientListToolStripMenuItem
            // 
            this.patientListToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("patientListToolStripMenuItem.Image")));
            this.patientListToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.patientListToolStripMenuItem.Name = "patientListToolStripMenuItem";
            this.patientListToolStripMenuItem.Size = new System.Drawing.Size(230, 36);
            this.patientListToolStripMenuItem.Text = "Patient List";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("settingsToolStripMenuItem.Image")));
            this.settingsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(230, 36);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name";
            // 
            // TxtPatientName
            // 
            this.TxtPatientName.FormattingEnabled = true;
            this.TxtPatientName.Location = new System.Drawing.Point(18, 96);
            this.TxtPatientName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtPatientName.Name = "TxtPatientName";
            this.TxtPatientName.Size = new System.Drawing.Size(205, 25);
            this.TxtPatientName.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(15, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(299, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Time";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AptDuration);
            this.groupBox1.Controls.Add(this.BtnAppointmentSave);
            this.groupBox1.Controls.Add(this.AptReason);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.AptDate);
            this.groupBox1.Controls.Add(this.AptTime);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtPatientName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft JhengHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(273, 59);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(553, 489);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Appointment";
            // 
            // AptDuration
            // 
            this.AptDuration.DisplayMember = "15";
            this.AptDuration.FormattingEnabled = true;
            this.AptDuration.Items.AddRange(new object[] {
            "15",
            "20",
            "30",
            "40",
            "45",
            "60",
            "75"});
            this.AptDuration.Location = new System.Drawing.Point(445, 204);
            this.AptDuration.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AptDuration.Name = "AptDuration";
            this.AptDuration.Size = new System.Drawing.Size(88, 25);
            this.AptDuration.TabIndex = 19;
            // 
            // BtnAppointmentSave
            // 
            this.BtnAppointmentSave.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAppointmentSave.Location = new System.Drawing.Point(210, 409);
            this.BtnAppointmentSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnAppointmentSave.Name = "BtnAppointmentSave";
            this.BtnAppointmentSave.Size = new System.Drawing.Size(132, 51);
            this.BtnAppointmentSave.TabIndex = 18;
            this.BtnAppointmentSave.Text = "Save";
            this.BtnAppointmentSave.UseVisualStyleBackColor = true;
            this.BtnAppointmentSave.Click += new System.EventHandler(this.BtnAppointment_Click);
            // 
            // AptReason
            // 
            this.AptReason.Location = new System.Drawing.Point(18, 305);
            this.AptReason.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AptReason.Multiline = true;
            this.AptReason.Name = "AptReason";
            this.AptReason.Size = new System.Drawing.Size(242, 65);
            this.AptReason.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(15, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Reason";
            // 
            // AptDate
            // 
            this.AptDate.Location = new System.Drawing.Point(18, 204);
            this.AptDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AptDate.Name = "AptDate";
            this.AptDate.Size = new System.Drawing.Size(242, 25);
            this.AptDate.TabIndex = 15;
            // 
            // AptTime
            // 
            this.AptTime.CustomFormat = "HH:mm";
            this.AptTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.AptTime.Location = new System.Drawing.Point(302, 204);
            this.AptTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AptTime.Name = "AptTime";
            this.AptTime.ShowUpDown = true;
            this.AptTime.Size = new System.Drawing.Size(110, 25);
            this.AptTime.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(442, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Duration";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(230, 24);
            this.toolStripMenuItem1.Text = "Appointments";
            // 
            // AppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(864, 562);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AppointmentForm";
            this.Text = "Appointment";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private DateTimePicker AptTime;
        private Label label4;
        private Button BtnAppointmentSave;
        private Label label5;
        private DateTimePicker AptDate;
        private ComboBox TxtPatientName;
        private ComboBox AptDuration;
        private TextBox AptReason;
        private ToolStripMenuItem toolStripMenuItem1;
    }
}