using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kidumatica_Update
{
    public partial class FillActivityFeedback : Form
    {
        StudentGroup s = null;
        Employee resEmp = null;
        Student resStud = null;
        public FillActivityFeedback()
        {
            InitializeComponent();
            Fill_combo_box_Groups();
            HideUser();
        }
        public void HideUser()
        {
            if (Program.empUser.getType().ToString() == "Mentor")
            {
                checkBoxMentor.Hide();
                MentorBox.Hide();
            }
            if (Program.empUser.getType().ToString() == "Lecturer")
            {
                checkBoxLecturer.Hide();
                comboBoxLecturers.Hide();
            }
        }
public void Fill_combo_box_Groups()
        {
            List<int> names = new List<int>();

            foreach (StudentGroup sp in Program.studentGroups)
            {
                names.Add(sp.getId());
            }
            ChooseGroupComb.DataSource = names;
        }
        public void Fill_combo_box_Students()
        {
            List<String> namesStudents = new List<String>();

            foreach (Student stud in s.getStudents())
            {
                namesStudents.Add(stud.getFullName());
            }
            comboBoxStudents.DataSource = namesStudents;
        }
        public void Fill_combo_box_Lecturers()
        {
            List<String> namesLecturers = new List<String>();

            foreach (Employee lec in Program.employees)
            {
                if (lec.getType().ToString().Equals("Lecturer"))
                    namesLecturers.Add(lec.getFullName());
            }
            comboBoxLecturers.DataSource = namesLecturers;
        }
        private void FillActivityFeedback_Load(object sender, EventArgs e)
        {
            if (Program.empUser.getType().ToString() == "Mentor")
            {
                checkBoxMentor.Hide();
                MentorBox.Hide();
            }
            if (Program.empUser.getType().ToString() == "Lecturer")
            {
                checkBoxLecturer.Hide();
                comboBoxLecturers.Hide();
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void ChooseGroup_Click(object sender, EventArgs e)
        {
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
         {

         }
        private void ChooseGroupComb_SelectedIndexChanged(object sender, EventArgs e)
         {
             s = Program.getStudentGroupObject(int.Parse(ChooseGroupComb.SelectedItem.ToString()));
         }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (Program.empUser.getType().ToString().Equals("Mentor"))
            {
                MentorMain m = new MentorMain();
                m.Show();
            }
            if (Program.empUser.getType().ToString().Equals("Lecturer"))
            {
                LecturerMain l = new LecturerMain();
                l.Show();
            }
        }
        private void checkBoxStudent_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxStudent.Checked)
            {
                checkBoxMentor.Hide();
                checkBoxLecturer.Hide();
                MentorBox.Hide();
                comboBoxLecturers.Hide();
                ChooseGroup.Hide();
                ChooseGroupComb.Hide();
                HideUser();

                if (s != null)
                {
                    Fill_combo_box_Students();
                }
            }
            else
            {
                resStud = null;
                comboBoxStudents.ResetText();
                checkBoxMentor.Show();
                checkBoxLecturer.Show();
                MentorBox.Show();
                comboBoxLecturers.Show();
                ChooseGroup.Show();
                ChooseGroupComb.Show();
                HideUser();
            }
        }
        private void checkBoxMentor_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMentor.Checked)
            {
                checkBoxStudent.Hide();
                checkBoxLecturer.Hide();
                comboBoxStudents.Hide();
                comboBoxLecturers.Hide();
                ChooseGroup.Hide();
                ChooseGroupComb.Hide();
                HideUser();

                if (s != null)
                {
                    MentorBox.Text = s.getSMentor().getFullName();
                }
            }

            else
            {
                resEmp = null;
                MentorBox.ResetText();
                checkBoxStudent.Show();
                checkBoxLecturer.Show();
                comboBoxStudents.Show();
                comboBoxLecturers.Show();
                ChooseGroup.Show();
                ChooseGroupComb.Show();
                HideUser();
            }  
        }
        private void comboBoxStudents_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           resStud = Program.getStudentObjectByName(comboBoxStudents.Text);
        }
        private void MentorBox_TextChanged(object sender, EventArgs e)
        {
          resEmp = Program.getEmployeeObjectByName(MentorBox.Text);
        }
        private void checkBoxLecturer_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBoxLecturer.Checked)
            {
                checkBoxStudent.Hide();
                checkBoxMentor.Hide();
                comboBoxStudents.Hide();
                MentorBox.Hide();
                ChooseGroup.Hide();
                ChooseGroupComb.Hide();
                HideUser();

                if (s != null)
                {
                    Fill_combo_box_Lecturers();
                }
            }
            else
            {
                resEmp = null;
                comboBoxLecturers.ResetText();
                checkBoxMentor.Show();
                checkBoxStudent.Show();
                comboBoxStudents.Show();
                MentorBox.Show();
                ChooseGroup.Show();
                ChooseGroupComb.Show();
                HideUser();
            }
        }
        private void comboBoxLecturers_SelectedIndexChanged(object sender, EventArgs e)
        {
            resEmp = Program.getEmployeeObjectByName(comboBoxLecturers.Text);
        }
        private void Submit_Click(object sender, EventArgs e)
        {
            try
            {
                String desctiption = FeedbackDetails.Text;
                if (comboBoxLecturers.Text == "" && comboBoxStudents.Text == "" && MentorBox.Text == "")
                {
                    throw new Exception("Feedback person is required");
                }
                if (string.IsNullOrWhiteSpace(desctiption))
                {
                    throw new Exception("Activity feedback is required");
                }
                    ActivityFeedback af = new ActivityFeedback(Program.activityFeedback.Count + 1, DateTime.Now, desctiption, Program.empUser, resEmp, resStud);
                Program.activityFeedback.Add(af);
                Program.create_ActivityFeedback_In_DB(af);
                Program.empUser.addCreatedActivityFeedback(af);
                if (resEmp != null)
                {
                    resEmp.addRecievedActivityFeedback(af);
                    Program.update_ActivityFeedback_Recieve_Employee_In_DB(af);
                }
                if (resStud != null)
                {
                    resStud.addStudentActivityFeedbacks(af);
                    Program.update_ActivityFeedback_Recieve_Student_In_DB(af);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Activity feedback is required", MessageBoxButtons.OK);
            }

        }
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
