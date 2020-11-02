using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dental.Common.Interfaces;
using Dental.Common.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace WinForm.DentalSystem
{
    public partial class Dashboard : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IAppointmentService _appointmentService;
        private readonly IAppointmentRepository _appointmentRepository;

        public Dashboard(
            IServiceProvider serviceProvider,
            IAppointmentService appointmentService,
            IAppointmentRepository appointmentRepository)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _appointmentService = appointmentService;
            _appointmentRepository = appointmentRepository;
        }

        private void BtnAppointment_Click(object sender, EventArgs e)
        {
            var form = _serviceProvider.GetRequiredService<AppointmentForm>();
            form.ShowDialog(this);
        }

        private void BtnAddPatient_Click(object sender, EventArgs e)
        {
            var form = _serviceProvider.GetRequiredService<PatientForm>();
            form.ShowDialog(this);
        }

        private async void Dashboard_Load(object sender, EventArgs e)
        {
            var appointmentSlots = await _appointmentService.GetAppointmentSlots();
            lblTodayAppointmentCount.Text = appointmentSlots.UsedSlots.Count.ToString();
            listBoxConsultation.DataSource = appointmentSlots.UsedSlots;
            listBoxOpenSlots.DataSource = appointmentSlots.AvailableSlots;
            listBoxConsultation.ClearSelected();
            listBoxOpenSlots.ClearSelected();
        }

        private void BtnPatientList_Click(object sender, EventArgs e)
        {
            var patientListForm = _serviceProvider.GetRequiredService<PatientListForm>();
            patientListForm.ShowDialog();

            var dashboardForm = _serviceProvider.GetRequiredService<Dashboard>();
            dashboardForm.Close();
        }
    }
}
