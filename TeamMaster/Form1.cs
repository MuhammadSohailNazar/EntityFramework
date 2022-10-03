using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeamMaster.Model;

namespace TeamMaster
{
    public partial class TaskMaster : Form
    {
        private tmDBContext tmContext;
        public TaskMaster()
        {
            InitializeComponent();
            tmContext = new tmDBContext();
            var statuses = tmContext.Statuses.ToList();

            foreach (Status status in statuses)
            {
                cboStatus.Items.Add(status);
            }
            refreshData();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {

        }
        private void refreshData()
        {
            BindingSource bi = new BindingSource();

            var query = from t in tmContext.Tasks
                        orderby t.DueDate
                        select new { t.Id, TaskName = t.Name, StatusName = t.Status.Name, t.DueDate };

            bi.DataSource = query.ToList();
            dataGridView1.DataSource = bi;
        }

        private void cmdCreateTask_Click(object sender, EventArgs e)
        {
            if (cboStatus.SelectedItem != null && txtTask.Text != String.Empty)
            {
                var newTask = new Model.Task
                {
                    Name = txtTask.Text,
                    StatusId = (cboStatus.SelectedItem as Model.Status).Id,
                    DueDate = dateTimePicker1.Value
                };
                tmContext.Tasks.Add(newTask);
                tmContext.SaveChanges();
                refreshData();
                //MessageBox.Show("New task successfully added.");
            }
            else
            {
                if (cboStatus.SelectedItem == null && txtTask.Text == String.Empty)
                    MessageBox.Show("Please Select task status and enter task detail.");
                else if (cboStatus.SelectedItem == null)
                    MessageBox.Show("Please select task status.");
                else if (txtTask.Text == String.Empty)
                    MessageBox.Show("Please enter task detail.");


            }
        }

        private void cmdDeleteTask_Click(object sender, EventArgs e)
        {
            var t = tmContext.Tasks.Find((int)dataGridView1.SelectedCells[0].Value);
            tmContext.Tasks.Remove(t);
            tmContext.SaveChanges();
            refreshData();
        }

        private void cmdUpdateTask_Click(object sender, EventArgs e)
        {
            if (cmdUpdateTask.Text == "Update")
            {
                txtTask.Text = dataGridView1.SelectedCells[1].Value.ToString();
                dateTimePicker1.Value = (DateTime)dataGridView1.SelectedCells[3].Value;
                foreach (Status item in cboStatus.Items)
                {
                    if (item.Name == dataGridView1.SelectedCells[2].Value.ToString())
                        cboStatus.SelectedItem = item;
                }
                cmdUpdateTask.Text = "Save";
            }else if(cmdUpdateTask.Text == "Save")
            {
                var t = tmContext.Tasks.Find(dataGridView1.SelectedCells[0].Value);

                t.Name = txtTask.Text;
                t.DueDate = dateTimePicker1.Value;
                t.StatusId = (cboStatus.SelectedItem as Status).Id;

                tmContext.SaveChanges();

                refreshData();

                cmdUpdateTask.Text = "Update";
                txtTask.Text = String.Empty;
                dateTimePicker1.Value = DateTime.Now;
                cboStatus.Text = "Please Select...";
            }
        }

        private void cmdCancel_Click_1(object sender, EventArgs e)
        {
            cmdUpdateTask.Text = "Update";
            txtTask.Text = String.Empty;
            dateTimePicker1.Value = DateTime.Now;
            cboStatus.Text = "Please Select...";
        }
    }
}
