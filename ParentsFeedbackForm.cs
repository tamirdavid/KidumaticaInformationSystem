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
    public partial class ParentsFeedbackForm : Form
    {
        public ParentsFeedbackForm()
        {
            InitializeComponent();
            init();

        }
        public  void init()
        {
            questionnaire.Rows.Clear();

            foreach (Question q in Program.pfQuestions)
            {
                questionnaire.Rows.Add(q.getId(), q.getQuestion(), null, null, null, null, null);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentMain sm = new StudentMain();
            sm.Show();
        }


        private void pfdescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void Submit_parentFeedback_Click(object sender, EventArgs e)
        {
            questionnaire.Refresh();
            
            List<Grade> collectGrades = new List<Grade>();
            for (int rows = 0; rows < questionnaire.Rows.Count; rows++)
            {
                
                int questionId = int.Parse(questionnaire.Rows[rows].Cells[0].Value.ToString());
                int count = 0;
                int grade = 0;
                questionnaire.UpdateCellValue(rows, 2);
                if (questionnaire.Rows[rows].Cells[2].Value != null)
                {
                    count = count + 1;
                    grade = 1;
                }
                if (questionnaire.Rows[rows].Cells[3].Value != null)
                {
                    count = count + 1;
                    grade = 2;
                }
                if (questionnaire.Rows[rows].Cells[4].Value != null)
                {
                    count = count + 1;
                    grade = 3;
                }
                if (questionnaire.Rows[rows].Cells[5].Value != null)
                {
                    count = count + 1;
                    grade = 4;
                }
                if (questionnaire.Rows[rows].Cells[6].Value != null)
                {
                    count = count + 1;
                    grade = 5;
                }
                if (count > 1 || count < 1)
                {
                    MessageBox.Show("Please make sure you are answering all questions", "Message", MessageBoxButtons.OK);
                    init();
                    break;
                }
                else
                {                   
                    Grade g = new Grade( Program.getQuestionObject(questionId), grade);
                    collectGrades.Add(g);
                }
            }
            if (collectGrades.Count == questionnaire.Rows.Count)
            {
                ParentsFeedBack pf = new ParentsFeedBack(Program.parentsFeedback.Count + 1, Program.studUser, DateTime.Now, pfdescription.Text);

                Program.parentsFeedback.Add(pf);
                Program.create_ParentFeedbak_In_DB(pf);
                pf.addGrades(collectGrades);
                foreach (Grade gr in collectGrades)
                {
                    gr.setParentFeedback(pf);
                    Program.create_Grade_In_DB(gr);
                }
            }
            
        }
    }
}
