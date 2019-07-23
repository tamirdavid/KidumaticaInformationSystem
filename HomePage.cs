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
    public partial class HomePage : Form
    {

        public HomePage()
        {
            InitializeComponent();
            ViewFirstPlaceTextBox();
            ViewSecondPlaceTextBox();
            ViewThirdPlaceTextBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.empUser = null;
            Program.studUser = null;
            string userId;
            userId = UserNameTextBox.Text.ToString();
            string password;
            password = PasswordTextBox.Text.ToString();
            int checkFlag = 0;

            
            if (userId == "" || password == "")
            {
                string err = "Please Enter User ID or Password";
                string err2 = "Error";
                MessageBox.Show(err, err2);
                return;
            }
           if(userId != "")
            {
                try
                {
                    int checkUserID = int.Parse(UserNameTextBox.Text);
                }
                catch (Exception ex)
                {
                    checkFlag = 1;
                    MessageBox.Show("User ID in incorrect format", "Error", MessageBoxButtons.OK);
                }
            }

            foreach (Employee elem in Program.employees)
            {
                if (elem.getId() == userId && elem.getPassword() == password.Trim())
                {

                    if (elem.getType().ToString().Equals("Mentor"))
                    {
                        Program.empUser = elem;
                        MentorMain m = new MentorMain();
                        m.Show();
                    }
                    if (elem.getType().ToString().Equals("Lecturer"))
                    {
                        Program.empUser = elem;
                        LecturerMain l = new LecturerMain();
                        l.Show();
                    }
                    if (elem.getType().ToString().Equals("LogisticCoordinator"))
                    {
                        Program.empUser = elem;
                        LogisticCoordinatorMain r = new LogisticCoordinatorMain();
                        r.Show();
                    }
                }
            }
            foreach (Student studi in Program.students)
            {
                if (studi.getId() == userId && studi.getPassword() == password.Trim())
                {
                    Program.studUser = studi;
                    StudentMain sm = new StudentMain();
                    sm.Show();
                }
            }

            if (Program.studUser == null && Program.empUser == null && checkFlag != 1 )
                MessageBox.Show("User does not Exist", "Error", MessageBoxButtons.OK);

            if(Program.studUser != null || Program.empUser != null)
            {
                this.Hide();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Note> temp1 = Program.sortByDateAndActive();
            Console.WriteLine(temp1.Count);
            string NoteboardString = "";
            foreach (Note element in temp1)
            {
                NoteboardString += element.getNoteDT().ToString("MM/dd/yyyy") + "     " + element.getTitle() + "        " + Program.getEmployeeObject(element.getCreator().getId()).getFullName() + " \r\n" + element.getDescription() + "\r\n\r\n"+ "----------------------------------------------------------------------------" + "\r\n\r\n";

            }
            richTextBox1.Text = NoteboardString;

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordLabel_Click(object sender, EventArgs e)
        {

        }

        private void ThirdPlaceTextBox_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SecondPlaceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FirstPlaceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        public void ViewFirstPlaceTextBox()
        {
            string firstPlace = "";
            Student firstPlacestu = Student.sortByRating()[0];
            FirstPlace.Text = "First Place:" + "    " + firstPlacestu.getRating().ToString();
            firstPlace = firstPlacestu.getFullName() + "    Group Number: " + firstPlacestu.getStudentGroup().getId().ToString() ;
            FirstPlaceTextBox.Text = firstPlace;

        }

        public void ViewSecondPlaceTextBox()
        {

            string secondPlace = "";
            Student secondPlacestu = Student.sortByRating()[1];
            SecondPlace.Text = "Second Place:" + "    " + secondPlacestu.getRating().ToString();
            secondPlace = secondPlacestu.getFullName() + "    Group Number: " + secondPlacestu.getStudentGroup().getId().ToString() ;

            SecondPlaceTextBox.Text = secondPlace;

        }


        public void ViewThirdPlaceTextBox()

        {

            string thirdPlace = "";
            Student thirdPlaceStu = Student.sortByRating()[2];
            ThirdPlace.Text = "Third Place:" + "    " + thirdPlaceStu.getRating().ToString();
            thirdPlace = thirdPlaceStu.getFullName() + "    Group Number: " + thirdPlaceStu.getStudentGroup().getId().ToString() ;

            ThirdPlaceTextBox.Text = thirdPlace;

             }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void UserNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void UserNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
   }