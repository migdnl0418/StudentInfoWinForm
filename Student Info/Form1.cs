using Student_Info.Model;
using Student_Info.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Info
{
    public enum State
    {
        View,
        Add,
        Update
    }


    public partial class Form1 : Form
    {
        private State _currentState = State.View;
        private readonly IStudentDataServices _studentDataServices;
        private List<StudentModel> _students = new List<StudentModel>();
        private StudentModel _selectedStudent;

        public Form1(IStudentDataServices studentDataServices)
        {
            _studentDataServices = studentDataServices;
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            var acadLevels = await _studentDataServices.GetAcadLevelsAsync();
            var sections = await _studentDataServices.GetSectionsAsync();
            var students = await _studentDataServices.GetAllStudentsAsync();

            PopulateAcadLevelDropdown(acadLevels);
            PopulateSectionDropdown(sections);
            DisplayStudents(students);

            ResetButtons();
            EnableFields(false);
        }

        private async void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var search = txtSearch.Text.Trim();
            var results = await SearchStudentsAsync(search);
            DisplayStudents(results);
        }


        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < _students.Count)
            {
                _selectedStudent = _students[e.RowIndex];
                DisplayStudent(_selectedStudent);

                ResetButtons();
                btnEdit.Visible = true;
                btnDelete.Visible = true;
                EnableFields(false);
                _currentState = State.View;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearFields();
            ResetButtons();
            btnSave.Visible = true;
            btnCancel.Visible = true;
            EnableFields(true);
            _currentState = State.Add;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ResetButtons();
            btnSave.Visible = true;
            btnCancel.Visible = true;
            EnableFields(true);
            _currentState = State.Update;
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            ResetButtons();
            _currentState = State.View;

            var confirmResult
                = MessageBox.Show("Are you sure to delete this student?",
                "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.No)
            {
                ResetButtons();
                ClearFields();
                return;
            }

            await DeleteStudent();

        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateFields()) return;

            if (_currentState == State.Add) await AddNewStudent();
            else if (_currentState == State.Update) await EditStudent();

            ResetButtons();
            _currentState = State.View;
            EnableFields(false);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetButtons();
            ClearFields();
        }


        private void PopulateAcadLevelDropdown(List<AcadLevelModel> acadLevels)
        {
            cmbAcadLevel.DataSource = acadLevels;
            cmbAcadLevel.DisplayMember = "Name";
            cmbAcadLevel.ValueMember = "Id";
        }

        private void PopulateSectionDropdown(List<SectionModel> sections)
        {
            cmbSection.DataSource = sections;
            cmbSection.DisplayMember = "Name";
            cmbSection.ValueMember = "Id";
        }

        private void DisplayStudents(List<StudentModel> students)
        {
            _students = students;
            dataGridView2.Rows.Clear();

            foreach (var student in _students)
            {
                dataGridView2.Rows.Add(
                    student.Id,
                    student.Lastname,
                    student.Firstname,
                    student.Middlename,
                    NormalizeGender(student.Gender),
                    student.AcadLevelName,
                    student.SectionName,
                    student.Email
                    );
            }
        }

        private async Task<List<StudentModel>> SearchStudentsAsync(string search)
        {
            return await _studentDataServices.SearchStudentsAsync(search);
        }

        private async Task AddNewStudent()
        {
            try
            {
                var student = new StudentModel
                {
                    Lastname = txtLastname.Text,
                    Firstname = txtFirstname.Text,
                    Middlename = txtMiddlename.Text,
                    Gender = cmbGender.SelectedItem.ToString(),
                    AcadLevelId = (int)cmbAcadLevel.SelectedValue,
                    SectionId = (int)cmbSection.SelectedValue,
                    Email = txtEmail.Text
                };
                NormalizeStudentModel(student);
                await _studentDataServices.AddStudentAsync(student);
                MessageBox.Show($"{student.Firstname} {student.Lastname} added successfully.");
                var students = await _studentDataServices.GetAllStudentsAsync();
                DisplayStudents(students);
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred while adding the student.");
            }
        }

        private async Task EditStudent()
        {
            try
            {
                if (_selectedStudent == null)
                {
                    MessageBox.Show("No student selected for update.");
                    return;
                }

                var genderCode = !string.IsNullOrEmpty(cmbGender.Text)
                        ? cmbGender.Text.Substring(0, 1).ToUpper()
                        : "";

                _selectedStudent.Lastname = txtLastname.Text;
                _selectedStudent.Firstname = txtFirstname.Text;
                _selectedStudent.Middlename = txtMiddlename.Text;
                _selectedStudent.Gender = genderCode;
                _selectedStudent.AcadLevelId = (int)cmbAcadLevel.SelectedValue;
                _selectedStudent.SectionId = (int)cmbSection.SelectedValue;
                _selectedStudent.Email = txtEmail.Text;
                NormalizeStudentModel(_selectedStudent);
                await _studentDataServices.UpdateStudentAsync(_selectedStudent);
                MessageBox.Show($"{_selectedStudent.Firstname} {_selectedStudent.Lastname} updated successfully.");
                var students = await _studentDataServices.GetAllStudentsAsync();
                DisplayStudents(students);
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred while updating the student.");
            }
        }

        private async Task DeleteStudent()
        {
            try
            {
                var id = _selectedStudent.Id;
                await _studentDataServices.DeleteStudentAsync(id);
                MessageBox.Show("Successfully remove student");
                var students = await _studentDataServices.GetAllStudentsAsync();
                DisplayStudents(students);
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred while removing the student.");
            }
        }

        private void DisplayStudent(StudentModel student)
        {
            txtLastname.Text = student.Lastname;
            txtFirstname.Text = student.Firstname;
            txtMiddlename.Text = student.Middlename;
            cmbGender.Text = NormalizeGender(student.Gender);
            cmbAcadLevel.SelectedValue = student.AcadLevelId;
            cmbSection.SelectedValue = student.SectionId;
            txtEmail.Text = student.Email;
        }

        private void ResetButtons()
        {
            btnAdd.Visible = true;
            btnEdit.Visible = false;
            btnDelete.Visible = false;
            btnSave.Visible = false;
            btnCancel.Visible = false;
        }

        private void EnableFields(bool enable)
        {
            txtLastname.Enabled = enable;
            txtFirstname.Enabled = enable;
            txtMiddlename.Enabled = enable;
            cmbGender.Enabled = enable;
            cmbAcadLevel.Enabled = enable;
            cmbSection.Enabled = enable;
            txtEmail.Enabled = enable;
        }
        private void ClearFields()
        {
            txtLastname.Text = string.Empty;
            txtFirstname.Text = string.Empty;
            txtMiddlename.Text = string.Empty;
            cmbGender.SelectedIndex = -1;
            cmbAcadLevel.SelectedIndex = -1;
            cmbSection.SelectedIndex = -1;
            txtEmail.Text = string.Empty;
        }

        private void NormalizeStudentModel(StudentModel student)
        {
            student.Lastname = student.Lastname?.Trim();
            student.Firstname = student.Firstname?.Trim();
            student.Middlename = student.Middlename?.Trim();
            student.Gender = student.Gender?.Trim()[0].ToString();
            student.Email = student.Email?.Trim();
        }

        private string NormalizeGender(string gender)
        {
            return gender == "M" ? "Male" :
              gender == "F" ? "Female" : gender == "T" ? "Transformer" : null;
        }

        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(txtLastname.Text) ||
                string.IsNullOrWhiteSpace(txtFirstname.Text) ||
                string.IsNullOrWhiteSpace(txtMiddlename.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                cmbGender.SelectedIndex < 0 ||
                cmbAcadLevel.SelectedIndex < 0 ||
                cmbSection.SelectedIndex < 0)
            {
                MessageBox.Show("Please fill in all required fields.",
                                "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

    }
}