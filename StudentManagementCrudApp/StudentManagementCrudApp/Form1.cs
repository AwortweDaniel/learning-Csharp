using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace StudentManagementApp
{
    public partial class MainForm : Form
    {
        private List<Student> students;
        private BindingSource bindingSource;
        private int nextId = 1;

        // Form controls
        private DataGridView dataGridView1;
        private TextBox txtStudentId;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private DateTimePicker dateTimePicker1;
        private TextBox txtAddress;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private Button btnSearch;
        private TextBox txtSearch;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private GroupBox groupBox1;
        private GroupBox groupBox2;

        public MainForm()
        {
            InitializeControls();
            InitializeData();
        }

        private void InitializeControls()
        {
            // Initialize all controls
            this.dataGridView1 = new DataGridView();
            this.txtStudentId = new TextBox();
            this.txtFirstName = new TextBox();
            this.txtLastName = new TextBox();
            this.txtEmail = new TextBox();
            this.txtPhone = new TextBox();
            this.dateTimePicker1 = new DateTimePicker();
            this.txtAddress = new TextBox();
            this.btnAdd = new Button();
            this.btnUpdate = new Button();
            this.btnDelete = new Button();
            this.btnClear = new Button();
            this.btnSearch = new Button();
            this.txtSearch = new TextBox();
            this.label1 = new Label();
            this.label2 = new Label();
            this.label3 = new Label();
            this.label4 = new Label();
            this.label5 = new Label();
            this.label6 = new Label();
            this.label7 = new Label();
            this.label8 = new Label();
            this.groupBox1 = new GroupBox();
            this.groupBox2 = new GroupBox();

            ((ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();

            // MainForm
            this.AutoScaleDimensions = new SizeF(8F, 16F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(1200, 700);
            this.Text = "Student Management System";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(240, 248, 255);

            // DataGridView
            this.dataGridView1.Location = new Point(20, 300);
            this.dataGridView1.Size = new Size(1160, 380);
            this.dataGridView1.BackgroundColor = Color.White;
            this.dataGridView1.BorderStyle = BorderStyle.FixedSingle;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;

            // GroupBox1 - Student Details
            this.groupBox1.Location = new Point(20, 20);
            this.groupBox1.Size = new Size(750, 270);
            this.groupBox1.Text = "Student Details";
            this.groupBox1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            this.groupBox1.ForeColor = Color.DarkBlue;

            // Labels
            this.label1.Text = "Student ID:";
            this.label1.Location = new Point(20, 35);
            this.label1.Size = new Size(100, 23);
            this.label1.Font = new Font("Microsoft Sans Serif", 9F);

            this.label2.Text = "First Name:";
            this.label2.Location = new Point(20, 70);
            this.label2.Size = new Size(100, 23);
            this.label2.Font = new Font("Microsoft Sans Serif", 9F);

            this.label3.Text = "Last Name:";
            this.label3.Location = new Point(20, 105);
            this.label3.Size = new Size(100, 23);
            this.label3.Font = new Font("Microsoft Sans Serif", 9F);

            this.label4.Text = "Email:";
            this.label4.Location = new Point(20, 140);
            this.label4.Size = new Size(100, 23);
            this.label4.Font = new Font("Microsoft Sans Serif", 9F);

            this.label5.Text = "Phone:";
            this.label5.Location = new Point(380, 35);
            this.label5.Size = new Size(100, 23);
            this.label5.Font = new Font("Microsoft Sans Serif", 9F);

            this.label6.Text = "Date of Birth:";
            this.label6.Location = new Point(380, 70);
            this.label6.Size = new Size(100, 23);
            this.label6.Font = new Font("Microsoft Sans Serif", 9F);

            this.label7.Text = "Address:";
            this.label7.Location = new Point(20, 175);
            this.label7.Size = new Size(100, 23);
            this.label7.Font = new Font("Microsoft Sans Serif", 9F);

            // TextBoxes
            this.txtStudentId.Location = new Point(130, 35);
            this.txtStudentId.Size = new Size(200, 22);
            this.txtStudentId.ReadOnly = true;
            this.txtStudentId.BackColor = Color.LightGray;

            this.txtFirstName.Location = new Point(130, 70);
            this.txtFirstName.Size = new Size(200, 22);

            this.txtLastName.Location = new Point(130, 105);
            this.txtLastName.Size = new Size(200, 22);

            this.txtEmail.Location = new Point(130, 140);
            this.txtEmail.Size = new Size(200, 22);

            this.txtPhone.Location = new Point(490, 35);
            this.txtPhone.Size = new Size(200, 22);

            this.txtAddress.Location = new Point(130, 175);
            this.txtAddress.Size = new Size(560, 60);
            this.txtAddress.Multiline = true;
            this.txtAddress.ScrollBars = ScrollBars.Vertical;

            // DateTimePicker
            this.dateTimePicker1.Location = new Point(490, 70);
            this.dateTimePicker1.Size = new Size(200, 22);
            this.dateTimePicker1.Format = DateTimePickerFormat.Short;

            // Add controls to GroupBox1
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtStudentId);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.dateTimePicker1);

            // GroupBox2 - Actions
            this.groupBox2.Location = new Point(790, 20);
            this.groupBox2.Size = new Size(390, 270);
            this.groupBox2.Text = "Actions";
            this.groupBox2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            this.groupBox2.ForeColor = Color.DarkBlue;

            // Buttons
            this.btnAdd.Text = "Add Student";
            this.btnAdd.Location = new Point(20, 40);
            this.btnAdd.Size = new Size(120, 35);
            this.btnAdd.BackColor = Color.FromArgb(0, 122, 204);
            this.btnAdd.ForeColor = Color.White;
            this.btnAdd.FlatStyle = FlatStyle.Flat;
            this.btnAdd.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            this.btnAdd.Click += BtnAdd_Click;

            this.btnUpdate.Text = "Update Student";
            this.btnUpdate.Location = new Point(160, 40);
            this.btnUpdate.Size = new Size(120, 35);
            this.btnUpdate.BackColor = Color.FromArgb(255, 140, 0);
            this.btnUpdate.ForeColor = Color.White;
            this.btnUpdate.FlatStyle = FlatStyle.Flat;
            this.btnUpdate.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            this.btnUpdate.Click += BtnUpdate_Click;

            this.btnDelete.Text = "Delete Student";
            this.btnDelete.Location = new Point(300, 40);
            this.btnDelete.Size = new Size(120, 35);
            this.btnDelete.BackColor = Color.FromArgb(220, 53, 69);
            this.btnDelete.ForeColor = Color.White;
            this.btnDelete.FlatStyle = FlatStyle.Flat;
            this.btnDelete.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            this.btnDelete.Click += BtnDelete_Click;

            this.btnClear.Text = "Clear Fields";
            this.btnClear.Location = new Point(90, 90);
            this.btnClear.Size = new Size(120, 35);
            this.btnClear.BackColor = Color.FromArgb(108, 117, 125);
            this.btnClear.ForeColor = Color.White;
            this.btnClear.FlatStyle = FlatStyle.Flat;
            this.btnClear.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            this.btnClear.Click += BtnClear_Click;

            // Search controls
            this.label8.Text = "Search Student:";
            this.label8.Location = new Point(20, 150);
            this.label8.Size = new Size(120, 23);
            this.label8.Font = new Font("Microsoft Sans Serif", 9F);

            this.txtSearch.Location = new Point(20, 180);
            this.txtSearch.Size = new Size(200, 22);
            // Add placeholder text effect
            this.txtSearch.Text = "Enter name or email...";
            this.txtSearch.ForeColor = Color.Gray;
            this.txtSearch.Enter += TxtSearch_Enter;
            this.txtSearch.Leave += TxtSearch_Leave;

            this.btnSearch.Text = "Search";
            this.btnSearch.Location = new Point(240, 177);
            this.btnSearch.Size = new Size(80, 28);
            this.btnSearch.BackColor = Color.FromArgb(40, 167, 69);
            this.btnSearch.ForeColor = Color.White;
            this.btnSearch.FlatStyle = FlatStyle.Flat;
            this.btnSearch.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            this.btnSearch.Click += BtnSearch_Click;

            // Add controls to GroupBox2
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Controls.Add(this.btnSearch);

            // Add main controls to form
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);

            ((ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
        }

        private void InitializeData()
        {
            students = new List<Student>();
            bindingSource = new BindingSource();
            bindingSource.DataSource = students;
            dataGridView1.DataSource = bindingSource;

            // Add sample data
            AddSampleData();
            RefreshGrid();
        }

        private void AddSampleData()
        {
            students.Add(new Student
            {
                StudentId = nextId++,
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@email.com",
                Phone = "123-456-7890",
                DateOfBirth = new DateTime(2000, 5, 15),
                Address = "123 Main St, City, State"
            });

            students.Add(new Student
            {
                StudentId = nextId++,
                FirstName = "Jane",
                LastName = "Smith",
                Email = "jane.smith@email.com",
                Phone = "098-765-4321",
                DateOfBirth = new DateTime(1999, 8, 22),
                Address = "456 Oak Ave, City, State"
            });
        }

        // Placeholder text events for search box
        private void TxtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Enter name or email...")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void TxtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = "Enter name or email...";
                txtSearch.ForeColor = Color.Gray;
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                var student = new Student
                {
                    StudentId = nextId++,
                    FirstName = txtFirstName.Text.Trim(),
                    LastName = txtLastName.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Phone = txtPhone.Text.Trim(),
                    DateOfBirth = dateTimePicker1.Value,
                    Address = txtAddress.Text.Trim()
                };

                students.Add(student);
                RefreshGrid();
                ClearFields();
                MessageBox.Show("Student added successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtStudentId.Text))
            {
                MessageBox.Show("Please select a student to update.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ValidateInputs())
            {
                int studentId = int.Parse(txtStudentId.Text);
                var student = students.FirstOrDefault(s => s.StudentId == studentId);

                if (student != null)
                {
                    student.FirstName = txtFirstName.Text.Trim();
                    student.LastName = txtLastName.Text.Trim();
                    student.Email = txtEmail.Text.Trim();
                    student.Phone = txtPhone.Text.Trim();
                    student.DateOfBirth = dateTimePicker1.Value;
                    student.Address = txtAddress.Text.Trim();

                    RefreshGrid();
                    ClearFields();
                    MessageBox.Show("Student updated successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtStudentId.Text))
            {
                MessageBox.Show("Please select a student to delete.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Are you sure you want to delete this student?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int studentId = int.Parse(txtStudentId.Text);
                var student = students.FirstOrDefault(s => s.StudentId == studentId);

                if (student != null)
                {
                    students.Remove(student);
                    RefreshGrid();
                    ClearFields();
                    MessageBox.Show("Student deleted successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim().ToLower();

            // Don't search if it's the placeholder text or empty
            if (string.IsNullOrEmpty(searchTerm) || searchTerm == "enter name or email...")
            {
                bindingSource.DataSource = students;
                bindingSource.ResetBindings(false);
                return;
            }

            var filteredStudents = students.Where(s =>
                s.FirstName.ToLower().Contains(searchTerm) ||
                s.LastName.ToLower().Contains(searchTerm) ||
                s.Email.ToLower().Contains(searchTerm)).ToList();

            bindingSource.DataSource = filteredStudents;
            bindingSource.ResetBindings(false);
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedStudent = (Student)dataGridView1.SelectedRows[0].DataBoundItem;

                if (selectedStudent != null)
                {
                    txtStudentId.Text = selectedStudent.StudentId.ToString();
                    txtFirstName.Text = selectedStudent.FirstName;
                    txtLastName.Text = selectedStudent.LastName;
                    txtEmail.Text = selectedStudent.Email;
                    txtPhone.Text = selectedStudent.Phone;
                    dateTimePicker1.Value = selectedStudent.DateOfBirth;
                    txtAddress.Text = selectedStudent.Address;
                }
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("Please enter first name.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Please enter last name.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLastName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text) || !IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return false;
            }

            // Check for duplicate email (except when updating)
            string currentEmail = txtEmail.Text.Trim().ToLower();
            int currentId = string.IsNullOrEmpty(txtStudentId.Text) ? 0 : int.Parse(txtStudentId.Text);

            if (students.Any(s => s.Email.ToLower() == currentEmail && s.StudentId != currentId))
            {
                MessageBox.Show("Email address already exists.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return false;
            }

            return true;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void ClearFields()
        {
            txtStudentId.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
            dateTimePicker1.Value = DateTime.Now;
        }

        private void RefreshGrid()
        {
            bindingSource.DataSource = students;
            bindingSource.ResetBindings(false);
        }
    }

    // Student Model Class
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }

        public string FullName => $"{FirstName} {LastName}";
        public int Age => DateTime.Now.Year - DateOfBirth.Year -
                         (DateTime.Now.DayOfYear < DateOfBirth.DayOfYear ? 1 : 0);
    }
}