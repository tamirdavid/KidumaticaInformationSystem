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
    public partial class EquipmentDemandForm : Form
    {
        public EquipmentDemandForm()
        {
            InitializeComponent();
            productList.Rows.Clear();

            foreach (Product p in Program.products)
            {
                productList.Rows.Add(p.getName(), null, null);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)

        {
            try
            {
                string reasonForDemand = ReasonForDemand.Text;
                if (string.IsNullOrWhiteSpace(reasonForDemand))
                    {
                    throw new Exception("Reason for Demand is nesessary");
                    }
                EquipmentDemand ed = new EquipmentDemand(Program.equipmentDemands.Count + 1, Program.empUser, DateTime.Now, reasonForDemand);
                Program.equipmentDemands.Add(ed);

                Program.create_EquipmentDemand_In_DB(ed);
                Program.empUser.addEquipmentDemand(ed);

                for (int rows = 0; rows < productList.Rows.Count; rows++)
                {
                    int quantity = 0;
                    string description = null;

                    if (productList.Rows[rows].Cells[1].Value != null)
                    {

                        int valueQuantity = int.Parse(productList.Rows[rows].Cells[1].Value.ToString());
                        if (valueQuantity != 0)
                        {
                           quantity = valueQuantity;
                        }
                        if (!string.IsNullOrWhiteSpace(productList.Rows[rows].Cells[2].Value.ToString()))
                        {
                            description = productList.Rows[rows].Cells[2].Value.ToString();
                        }
                        else
                        {
                            description = "N/A";
                        }
                        contain c = new contain(ed, Program.getProductObject(productList.Rows[rows].Cells[0].Value.ToString()), quantity, description);
                        ed.addContain(c);
                        Program.create_Contain_In_DB(c);
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Invalid Input", MessageBoxButtons.OK);
            }
            
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            EquipmentDemandForEmployee edfe = new EquipmentDemandForEmployee();
            edfe.Show();
        }
    }
}
