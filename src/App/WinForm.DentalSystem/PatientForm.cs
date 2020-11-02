using Dental.Common.Dtos;
using Dental.Common.Entities;
using Dental.Common.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace WinForm.DentalSystem
{
    public partial class PatientForm : Form
    {
        private readonly IPatientService _patientService;
        private readonly IAppointmentService _appointmentService;
        private readonly IServiceProvider _serviceProvider;
        public static long _patientId = 0;

        public PatientForm(
            IPatientService patientService,
            IAppointmentService appointmentService,
            IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _patientService = patientService;
            _appointmentService = appointmentService;
            _serviceProvider = serviceProvider;
        }

        private async void PatientForm_Load(object sender, EventArgs e)
        {
            var existingPatientId = PatientListForm._patientId;
            
            if (existingPatientId > 0)
            {
                var patientInfo = await _patientService.GetPatientDetails(existingPatientId);

                if (patientInfo != null)
                {
                    AppointmentPanel.Visible = true;
                    txtFirstName.Text = patientInfo.Patients.FirstName;
                    txtLastName.Text = patientInfo.Patients.LastName;
                    txtHealth.Text = patientInfo.Patients.HealthNotes;
                    txtPhone.Text = patientInfo.Patients.Phone;
                    txtDoB.Text = patientInfo.Patients.DateBirth;
                    radFemale.Checked = patientInfo.Patients.Gender == "Female" ? true : false;
                    radMale.Checked = patientInfo.Patients.Gender == "Male" ? true : false;

                    txtTreatment.Text = patientInfo.Treatments.Description;
                    txtDiagnosis.Text = patientInfo.Treatments.Diagnosis;

                    AppointmentPanel.Visible = true;
                    lblPatientName.Text = $"{patientInfo.Patients.FirstName} {patientInfo.Patients.LastName}";
                }
            }
            else
            {
                AppointmentPanel.Visible = false;
            }        
        }

        private async void BtnSavePatient_Click(object sender, EventArgs e)
        {
            var firstName = txtFirstName.Text;
            var lastName = txtLastName.Text;
            var dob = txtDoB.Text;
            var gender = radMale.Checked ? "Male" : "Female";
            var phoneNumber = txtPhone.Text;
            var healthNotes = txtHealth.Text;
            var diagnosis = txtDiagnosis.Text;
            var treatment = txtTreatment.Text;

            if (!string.IsNullOrWhiteSpace(firstName) &&
                !string.IsNullOrWhiteSpace(lastName) &&
                !string.IsNullOrWhiteSpace(gender) &&
                !string.IsNullOrWhiteSpace(phoneNumber) &&
                !string.IsNullOrWhiteSpace(diagnosis))
            {
                var patientDto = new PatientDto
                {
                    Patients = new Patient
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        DateBirth = dob,
                        Gender = gender,
                        Phone = phoneNumber,
                        HealthNotes = healthNotes
                    },
                    Treatments = new Treatment
                    {
                        Description = treatment,
                        Diagnosis = diagnosis
                    }
                };

                _patientId = await _patientService.PersistPatientDetailsAsync(patientDto);

                if (_patientId > 0)
                {
                    MessageBox.Show("Patient registered successfully!", "Patient Registration",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AppointmentPanel.Visible = true;
                }
            }
        }

        private async void BtnSaveAppointment_Click(object sender, EventArgs e)
        {
            var appointmentDate = TxtAptDate.Text;
            var appointmentStartTime = txtStartTime.Text;
            var appointmentEndTime = txtEndTime.Text;
            var appointmentReason = txtAppointmentReason.Text;

            if (!string.IsNullOrWhiteSpace(appointmentDate) &&
                !string.IsNullOrWhiteSpace(appointmentStartTime) &&
                !string.IsNullOrWhiteSpace(appointmentReason) && 
                !string.IsNullOrWhiteSpace(appointmentEndTime))
            {
                var appointment = new Appointment
                {
                    AppointmentDate = appointmentDate,
                    AppointmentStartTime = appointmentStartTime,
                    AppointmentEndTime = appointmentEndTime,
                    Reason = appointmentReason,
                    PatientId = _patientId,
                    IsActive = true
                };

                var appointmentId = await _appointmentService.PersistAppointment(appointment);

                if (appointmentId > 0)
                {
                    MessageBox.Show("Appointment saved successfully!", "Appointment",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Appointment slot is not available!", "Appointment",
                                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtFirstName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                e.Cancel = true;
                txtFirstName.Focus();
                firstNameErrorProvider.SetError(txtFirstName, "First Name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                firstNameErrorProvider.SetError(txtFirstName, "");
            }
        }

        private void txtLastName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                e.Cancel = true;
                txtLastName.Focus();
                lastNameErrorProvider.SetError(txtLastName, "Last Name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                lastNameErrorProvider.SetError(txtLastName, "");
            }
        }

        private void txtPhone_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                e.Cancel = true;
                txtPhone.Focus();
                phoneErrorProvider.SetError(txtPhone, "Phone number should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                phoneErrorProvider.SetError(txtPhone, "");
            }
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            var dashboardForm = _serviceProvider.GetRequiredService<Dashboard>();
            dashboardForm.ShowDialog();
        }
    }
}
