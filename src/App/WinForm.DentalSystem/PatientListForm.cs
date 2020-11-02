using Dental.Common.Interfaces;
using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Dental.Common.Dtos;
using Microsoft.Extensions.DependencyInjection;

namespace WinForm.DentalSystem
{
    public partial class PatientListForm : Form
    {
        private readonly IPatientService _patientService;
        DataTable dt;
        private List<PatientItemDto> list;
        private readonly IServiceProvider _serviceProvider;
        public static long _patientId = 0;

        public PatientListForm(
            IPatientService patientService,
            IServiceProvider serviceProvider
            )
        {
            InitializeComponent();
            _patientService = patientService;
            _serviceProvider = serviceProvider;
           
        }

        private async void PatientListForm_Load(object sender, EventArgs e)
        {
            dt = new DataTable();
            list = await _patientService.GetAllPatients();
            lblPatientCount.Text = list.Count.ToString();
            lblPatientCount.Visible = true;
            var datas = ConvertToDatatable(list);
            dataGridView1.DataSource = datas;
            dataGridView1.Columns[0].Visible = false;
        }

        private async void txtSearchPatient_TextChanged(object sender, EventArgs e)
        {
            dt = new DataTable();
            list = await _patientService.GetAllPatients();

            if (!string.IsNullOrEmpty(txtSearchPatient.Text))
            {
                var searchItems = list.Where(x => x.FirstName.ToUpper().Contains(txtSearchPatient.Text.ToUpper())).ToList();
                var results = ConvertToDatatable(searchItems);
                dataGridView1.DataSource = results;
                dataGridView1.Columns[0].Visible = false;
            }
            else
            {
                var results = ConvertToDatatable(list);
                dataGridView1.DataSource = results;
                dataGridView1.Columns[0].Visible = false;
            }
        }

        private static DataTable ConvertToDatatable<T>(List<T> data)
        {
            PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            for (int i = 0; i < props.Count; i++)
            {
                PropertyDescriptor prop = props[i];
                if (prop.PropertyType.IsGenericType && prop.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
                    table.Columns.Add(prop.Name, prop.PropertyType.GetGenericArguments()[0]);
                else
                    table.Columns.Add(prop.Name, prop.PropertyType);
            }

            object[] values = new object[props.Count];
            foreach (T item in data)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = props[i].GetValue(item);
                }
                table.Rows.Add(values);
            }
            return table;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var patientId = this.dataGridView1.CurrentRow.Cells[0].Value;
            var patientForm = _serviceProvider.GetRequiredService<PatientForm>();
            _patientId = (long)patientId;
            var currentForm = _serviceProvider.GetRequiredService<PatientListForm>();
            patientForm.ShowDialog();

            currentForm.Close();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Cursor = Cursors.Hand;

            foreach (DataGridViewBand band in dataGridView1.Columns)
            {
                band.ReadOnly = true;
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            var dashboardForm = _serviceProvider.GetRequiredService<Dashboard>();
            dashboardForm.ShowDialog();
        }
    }

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
