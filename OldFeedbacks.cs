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
    public partial class OldFeedbacks : Form
    {
        public OldFeedbacks()
        {
            InitializeComponent();
            FillAllActivityFeedback();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void FillAllActivityFeedback()
        {
            string activityFeedbackString = "";
            if (Program.empUser != null)
            {
                List<ActivityFeedback> oldFeedbacks = Program.empUser.getActivityFeedbacks();
                foreach (ActivityFeedback feedback in oldFeedbacks)
                {
                    activityFeedbackString += feedback.getDateTime().ToString("MM/dd/yyyy") + "     " + feedback.getCreator().getFullName() + " " + '(' + feedback.getCreator().getType() + ')' + "        " +
                    " \r\n" + feedback.getDescription() + "\r\n\r\n";

                }
                activityFeedbackOld.Text = activityFeedbackString;
            }

            else
            {
                List<ActivityFeedback> oldFeedbacks = Program.studUser.getActivityFeedback();
                foreach (ActivityFeedback feedback in oldFeedbacks)
                {
                    activityFeedbackString += feedback.getDateTime().ToString("MM/dd/yyyy") + "     " + feedback.getCreator().getFullName() + " " + '(' + feedback.getCreator().getType() + ')' + "        " + " \r\n" + feedback.getDescription() + "\r\n\r\n";

                }
                activityFeedbackOld.Text = activityFeedbackString;
            }

        }

        private void back_Click(object sender, EventArgs e)
        {
             this.Hide();
            if (Program.empUser == null)
            {
                StudentMain s = new StudentMain();
                s.Show();
            }
            else if (Program.empUser.getType().ToString().Equals("Mentor"))
            {
                MentorMain m = new MentorMain();
                m.Show();
            }
            else 
             {
             LecturerMain l = new LecturerMain();
             l.Show();
             }
        }
    }
}
