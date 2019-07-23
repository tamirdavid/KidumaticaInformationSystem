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
    public partial class StudentMain : Form
    {
        public StudentMain()
        {
            InitializeComponent();
            if (Program.studUser != null)
            {
                StudentName.Text = "Hello " + Program.studUser.getFullName();
                int sRating = Program.studUser.getRating();
                StudentRatingVal.Text = sRating.ToString();
                int groupId = Program.studUser.getStudentGroup().getId();
                groupID.Text = groupId.ToString();

            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage hp = new HomePage();
            hp.Show();
        }

        private void StudentMain_Load(object sender, EventArgs e)
        {

        }

        private void ParentsFeedback_Click(object sender, EventArgs e)
        {
            this.Hide();
            ParentsFeedbackForm pff = new ParentsFeedbackForm();
            pff.Show();
        }

        private void HistoryFeedback_Click(object sender, EventArgs e)
        {

            this.Hide();
            OldFeedbacks hfs = new OldFeedbacks();
            hfs.Show();
        }

        private void StudentName_Click(object sender, EventArgs e)
        {

        }
    }
}
