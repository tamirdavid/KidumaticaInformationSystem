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
    public partial class RatingReportForm : Form
    {
        public RatingReportForm()
        {
            InitializeComponent();
            if (Program.empUser != null && Program.empUser.getType().ToString() == "Mentor")
                groupIdVal.Text = Program.empUser.getStudentGroup().getId().ToString();

            ratingReportTable.Rows.Clear();

            foreach (Student s in Program.students)
            {
                if (Program.empUser != null && Program.empUser.getType().ToString() == "Mentor")
                {
                    if (s.getStudentGroup() == Program.empUser.getStudentGroup())
                    {
                        ratingReportTable.Rows.Add(s.getId(), s.getFullName(), s.getRating(), null);
                    }
                }
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            MentorMain m = new MentorMain();
            m.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RatingReportForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int rows = 0; rows < ratingReportTable.Rows.Count; rows++)
            {

                if (ratingReportTable.Rows[rows].Cells[3].Value != null)
                {
                    try
                    {
                        int newRating = int.Parse(ratingReportTable.Rows[rows].Cells[3].Value.ToString());
                        Student s = Program.getStudentObject(ratingReportTable.Rows[rows].Cells[0].Value.ToString());
                        Console.WriteLine(s.getRating() + newRating);
                        s.setRating(newRating);
                        Program.Update_Student_Rating_In_DB(s);
                        this.Hide();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("The input must be a number", "Invalid Input", MessageBoxButtons.OK);
                    }
                }
            }
        }
    }
}
