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
    public partial class LogisticCoordinatorMain : Form
    {
        public LogisticCoordinatorMain()
        {
            InitializeComponent();
            if (Program.empUser != null)
            {
                HelloLC.Text = "Hello " + Program.empUser.getFullName();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenEquipmentDemandForLC oedflc = new OpenEquipmentDemandForLC();
            oedflc.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OldEquipmentDemandForLC oedflc = new OldEquipmentDemandForLC();
            oedflc.Show();
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

        private void HelloLC_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
         
     
            OldFeedbacks hfe = new OldFeedbacks();
            hfe.Show();
            this.Hide();
        }

        private void RatingReportByGroup_Click(object sender, EventArgs e)
        {
            ParentsFeedbackByGroup afbg = new ParentsFeedbackByGroup();
            afbg.Show();
            this.Hide();
        }
    }
}
