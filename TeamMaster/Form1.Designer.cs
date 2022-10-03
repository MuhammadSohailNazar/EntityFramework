
namespace TeamMaster
{
    partial class TaskMaster
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DueDate = new System.Windows.Forms.Label();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.Label();
            this.Task = new System.Windows.Forms.Label();
            this.cmdDeleteTask = new System.Windows.Forms.Button();
            this.cmdUpdateTask = new System.Windows.Forms.Button();
            this.cmdCreateTask = new System.Windows.Forms.Button();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtTask = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.DueDate);
            this.groupBox1.Controls.Add(this.cmdCancel);
            this.groupBox1.Controls.Add(this.status);
            this.groupBox1.Controls.Add(this.Task);
            this.groupBox1.Controls.Add(this.cmdDeleteTask);
            this.groupBox1.Controls.Add(this.cmdUpdateTask);
            this.groupBox1.Controls.Add(this.cmdCreateTask);
            this.groupBox1.Controls.Add(this.cboStatus);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.txtTask);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(676, 130);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Task";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // DueDate
            // 
            this.DueDate.AutoSize = true;
            this.DueDate.Location = new System.Drawing.Point(419, 30);
            this.DueDate.Name = "DueDate";
            this.DueDate.Size = new System.Drawing.Size(55, 15);
            this.DueDate.TabIndex = 10;
            this.DueDate.Text = "Due Date";
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(335, 88);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 9;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click_1);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(6, 58);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(39, 15);
            this.status.TabIndex = 8;
            this.status.Text = "Status";
            this.status.Click += new System.EventHandler(this.label2_Click);
            // 
            // Task
            // 
            this.Task.AutoSize = true;
            this.Task.Location = new System.Drawing.Point(6, 30);
            this.Task.Name = "Task";
            this.Task.Size = new System.Drawing.Size(32, 15);
            this.Task.TabIndex = 7;
            this.Task.Text = "Task:";
            // 
            // cmdDeleteTask
            // 
            this.cmdDeleteTask.Location = new System.Drawing.Point(432, 59);
            this.cmdDeleteTask.Name = "cmdDeleteTask";
            this.cmdDeleteTask.Size = new System.Drawing.Size(75, 23);
            this.cmdDeleteTask.TabIndex = 5;
            this.cmdDeleteTask.Text = "Delete";
            this.cmdDeleteTask.UseVisualStyleBackColor = true;
            this.cmdDeleteTask.Click += new System.EventHandler(this.cmdDeleteTask_Click);
            // 
            // cmdUpdateTask
            // 
            this.cmdUpdateTask.Location = new System.Drawing.Point(335, 59);
            this.cmdUpdateTask.Name = "cmdUpdateTask";
            this.cmdUpdateTask.Size = new System.Drawing.Size(75, 23);
            this.cmdUpdateTask.TabIndex = 4;
            this.cmdUpdateTask.Text = "Update";
            this.cmdUpdateTask.UseVisualStyleBackColor = true;
            this.cmdUpdateTask.Click += new System.EventHandler(this.cmdUpdateTask_Click);
            // 
            // cmdCreateTask
            // 
            this.cmdCreateTask.Location = new System.Drawing.Point(242, 59);
            this.cmdCreateTask.Name = "cmdCreateTask";
            this.cmdCreateTask.Size = new System.Drawing.Size(75, 23);
            this.cmdCreateTask.TabIndex = 3;
            this.cmdCreateTask.Text = "Create";
            this.cmdCreateTask.UseVisualStyleBackColor = true;
            this.cmdCreateTask.Click += new System.EventHandler(this.cmdCreateTask_Click);
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(62, 59);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(131, 23);
            this.cboStatus.TabIndex = 2;
            this.cboStatus.Text = "Please Select...";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(507, 24);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(134, 23);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // txtTask
            // 
            this.txtTask.Location = new System.Drawing.Point(62, 22);
            this.txtTask.Name = "txtTask";
            this.txtTask.Size = new System.Drawing.Size(311, 23);
            this.txtTask.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(676, 252);
            this.dataGridView1.TabIndex = 10;
            // 
            // TaskMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 425);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(816, 464);
            this.Name = "TaskMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task Master";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label Task;
        private System.Windows.Forms.Button cmdDeleteTask;
        private System.Windows.Forms.Button cmdUpdateTask;
        private System.Windows.Forms.Button cmdCreateTask;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtTask;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Label DueDate;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

