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
    public partial class OpenEquipmentDemandForLC : Form
    {
        public OpenEquipmentDemandForLC()
        {
            InitializeComponent();
            OpenEDforLC.Rows.Clear();

            foreach (EquipmentDemand ed in Program.equipmentDemands)
            {
                if (ed.getStatus() == "Not Handeled")
                    OpenEDforLC.Rows.Add(ed.getId(), ed.getCreator().getFullName(), ed.getDateTime(), ed.getDetails(), ed.getReason());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Submit_ED_Approval_Click(object sender, EventArgs e)
        {
            for (int rows = 0; rows < OpenEDforLC.Rows.Count; rows++)
            {

                if (OpenEDforLC.Rows[rows].Cells[5].Value != null && OpenEDforLC.Rows[rows].Cells[6].Value != null)
                {
                    MessageBox.Show("Please make sure you are marking only one option", "Message", MessageBoxButtons.OK);
                }
                else if (OpenEDforLC.Rows[rows].Cells[5].Value == null && OpenEDforLC.Rows[rows].Cells[6].Value == null)
                {
                    continue;
                }
                else
                {
                    String newStatus = "Not Handeled";
                    String approvalNote = null;
                    if (OpenEDforLC.Rows[rows].Cells[7].Value != null)
                        approvalNote = OpenEDforLC.Rows[rows].Cells[7].Value.ToString();

                    EquipmentDemand ed = Program.getEquipmentDemandObject(int.Parse(OpenEDforLC.Rows[rows].Cells[0].Value.ToString()));
                    if (OpenEDforLC.Rows[rows].Cells[5].Value != null)
                    {
                        ed.approved();
                        newStatus = "Approved";
                    }
                    if (OpenEDforLC.Rows[rows].Cells[6].Value != null)
                    {
                        ed.notApproved();
                        newStatus = "Not Approved";
                    }
                    if (approvalNote != null)
                    {
                        ed.addApprovalNote(approvalNote);
                        Program.update_ed_approvalNote_in_DB(ed, approvalNote);
                    }
                    Program.update_ed_status_in_DB(ed, newStatus);
                }
            }
            
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
