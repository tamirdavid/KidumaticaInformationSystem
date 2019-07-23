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
    public partial class LecturerMain : Form
    {
        public LecturerMain()
        {
            InitializeComponent();
            if (Program.empUser != null)
            {
                HelloLecturer.Text = "Hello " + Program.empUser.getFullName();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            EquipmentDemandForm edf = new EquipmentDemandForm();
            edf.Show();
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

        private void LecturerMain_Load(object sender, EventArgs e)
        {

        }

        private void fillActivityFeedback_Click(object sender, EventArgs e)
        {
            this.Hide();
            FillActivityFeedback faf = new FillActivityFeedback();
            faf.Show();
        }

        private void HelloLecturer_TextChanged(object sender, EventArgs e)
        {

        }

        private void HistoryFeedback_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            OldFeedbacks hfe = new OldFeedbacks();
            hfe.Show();


        }
    }
}
