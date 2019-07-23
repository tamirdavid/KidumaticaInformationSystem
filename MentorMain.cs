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
    public partial class MentorMain : Form
    {
        public MentorMain()
        {
            InitializeComponent();
            if (Program.empUser != null)
            {
                HelloMentor.Text = "Hello " + Program.empUser.getFullName();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EquipmentDemandForEmployee edffe = new EquipmentDemandForEmployee();
            edffe.Show();
            this.Hide();
        }

        private void NoteBoard_Click(object sender, EventArgs e)
        {
            AddNote n = new AddNote();
            n.Show();
            this.Hide();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage hp = new HomePage();
            hp.Show();
        }

        private void FillRatingReport_Click(object sender, EventArgs e)
        {
            this.Hide();
            RatingReportForm rrf = new RatingReportForm();
            rrf.Show();
        }

        private void fillActivityFeedback_Click(object sender, EventArgs e)
        {
            this.Hide();
            FillActivityFeedback faf = new FillActivityFeedback();
            faf.Show();

        }

        private void HelloMentor_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            OldFeedbacks hfe = new OldFeedbacks();
            hfe.Show();

        }
        }
    }
