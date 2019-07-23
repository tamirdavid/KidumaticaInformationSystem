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
    public partial class OldEquipmentDemandForLC : Form
    {
        public OldEquipmentDemandForLC()
        {
            InitializeComponent();
            OldEquipmentDemand.Rows.Clear();

            foreach (EquipmentDemand ed in Program.equipmentDemands)
            {   
                if(ed.getStatus()!= "Not Handeled")
                    OldEquipmentDemand.Rows.Add(ed.getId(), ed.getCreator().getFullName(), ed.getDateTime(), ed.getDetails(), ed.getStatus(), ed.getApprovalNote());
            }
        }

        private void OldEquipmentDemandForLC_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogisticCoordinatorMain l = new LogisticCoordinatorMain();
            l.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
