using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseJob
{
    public partial class Form1 : Form
    {
        private List<Student> students;

        public Form1()
        {
            InitializeComponent();
            students = new List<Student>();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string group = txtGroup.Text;

            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(group))
            {
                Student student = new Student(name, group);
                students.Add(student);

                // Очищення полів
                txtName.Clear();
                txtGroup.Clear();

                // Додавання студента до списку
                lbStudents.Items.Add(student);
            }
            else
            {
                MessageBox.Show("Будь ласка, введіть ПІБ та групу студента.");
            }
        }

        private void btnAddGrade_Click(object sender, EventArgs e)
        {
            if (lbStudents.SelectedItem != null)
            {
                Student student = (Student)lbStudents.SelectedItem;
                string subject = txtSubject.Text;
                int grade;

                if (int.TryParse(txtGrade.Text, out grade))
                {
                    student.AddGrade(subject, grade);

                    // Очищення полів
                    txtSubject.Clear();
                    txtGrade.Clear();

                    // Оновлення інформації про студента
                    lbStudents.Items[lbStudents.SelectedIndex] = student;
                }
                else
                {
                    MessageBox.Show("Будь ласка, введіть числову оцінку.");
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, оберіть студента зі списку.");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchName = txtSearch.Text;

            if (!string.IsNullOrEmpty(searchName))
            {
                Student student = students.FirstOrDefault(s => s.Name.ToLower() == searchName.ToLower());

                if (student != null)
                {
                    MessageBox.Show($"Студент: {student}\nГрупа: {student.Group}\nОцінки: {string.Join(", ", student.Grades)}");
                }
                else
                {
                    MessageBox.Show("Студента з таким прізвищем не знайдено.");
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, введіть прізвище для пошуку.");
            }
        }

        private void btnGroupRating_Click(object sender, EventArgs e)
        {
            string group = txtGroupRating.Text;

            if (!string.IsNullOrEmpty(group))
            {
                List<Student> groupStudents = students.Where(s => s.Group == group).ToList();

                if (groupStudents.Count > 0)
                {
                    double groupAverage = groupStudents.Average(s => s.GetAverageGrade());
                    MessageBox.Show($"Рейтинг групи {group}: {groupAverage:F2}");
                }
                else
                {
                    MessageBox.Show("Групи з такою назвою не знайдено.");
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, введіть назву групи для рейтингу.");
            }
        }

        private void btnFacultyRating_Click(object sender, EventArgs e)
        {
            if (students.Count > 0)
            {
                double facultyAverage = students.Average(s => s.GetAverageGrade());
                MessageBox.Show($"Загальний рейтинг факультету: {facultyAverage:F2}");
            }
            else
            {
                MessageBox.Show("Факультет порожній.");
            }
        }

    }
}
