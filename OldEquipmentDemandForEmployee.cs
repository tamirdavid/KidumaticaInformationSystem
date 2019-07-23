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
    public partial class OldEquipmentDemandForEmployee : Form
    {
        public OldEquipmentDemandForEmployee()
        {
            InitializeComponent();
            OldEquipmentDemandForEmp.Rows.Clear();

            foreach (EquipmentDemand ed in Program.empUser.getEquipmentDemands())
            {
                OldEquipmentDemandForEmp.Rows.Add(ed.getId(), ed.getDateTime(), ed.getDetails(), ed.getStatus(), ed.getApprovalNote(), ed.getReason());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            EquipmentDemandForEmployee edfe = new EquipmentDemandForEmployee();
            edfe.Show();
        }

        private void OldEquipmentDemandForEmployee_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
