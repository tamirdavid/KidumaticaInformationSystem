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
    public partial class EquipmentDemandForEmployee : Form
    {
        public EquipmentDemandForEmployee()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EquipmentDemandForm edf = new EquipmentDemandForm();
            edf.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OldEquipmentDemandForEmployee oedfe = new OldEquipmentDemandForEmployee();
            oedfe.Show();
            this.Hide();
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
            if (Program.empUser.getType().ToString().Equals("LogisticCoordinator"))
            {
                LogisticCoordinatorMain r = new LogisticCoordinatorMain();
                r.Show();
            }  
        }
    }
}
