using Dental.Common.Entities;
using Dental.Common.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm.DentalSystem
{
    public partial class AppointmentForm : Form
    {
        private IServiceProvider _serviceProvider;
        private readonly IAppointmentService _appointmentService;

        public AppointmentForm(
            IAppointmentService appointmentService,
            IServiceProvider serviceProvider)
        {
            _appointmentService = appointmentService;
            _serviceProvider = serviceProvider;
            InitializeComponent();
        }

        private void BtnAppointment_Click(object sender, EventArgs e)
        {
            var patientId = TxtPatientName.SelectedIndex == -1 ? 0 : TxtPatientName.SelectedIndex;
            var appointmentDate = AptDate.Value;
            var appointmentTime = AptTime.Value;
            var appointmentDuration = Convert.ToInt32(AptDuration.Text);
            var appointmentReason = AptReason.Text;



            //var success = _appointmentService.PersistAppointment(appointmentObj);

            string message = "Appointment Saved";
            string title = "New Appointment";
            MessageBox.Show(message, title);

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            var form = _serviceProvider.GetRequiredService<Dashboard>();
            var currentForm = _serviceProvider.GetRequiredService<AppointmentForm>();
            form.ShowDialog(this);
            currentForm.Close();
        }

    }
}
