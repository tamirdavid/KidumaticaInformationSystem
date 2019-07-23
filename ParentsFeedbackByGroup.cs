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
    public partial class ParentsFeedbackByGroup : Form
    {

        private static StudentGroup temp;
        private static List<String> NoteboardStringList;
        public ParentsFeedbackByGroup()
        {
            InitializeComponent();
            init();
        }

        public void init()
        {
            Question1.Rows.Clear();

            foreach (Question q in Program.pfQuestions)
            {
                Question1.Rows.Add(q.getQuestion(), null);
            }
        }

        private void ActivityFeedbackByGroup_Load(object sender, EventArgs e)
        {
            foreach (StudentGroup sg in Program.studentGroups)
            {
                ChooseGroup.Items.Add(sg);
            }

        }



        private void ChooseGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            string NoteboardString = "";
            NoteboardStringList = new List<string>();
            String currentNote = "";
            temp = (StudentGroup)ChooseGroup.SelectedItem;
            for (int i = 0; i < Program.parentsFeedback.Count; i++) 
            {
                currentNote = "";
                if (Program.parentsFeedback[i].getCreator().getStudentGroup().getStudentGroupId()
                == temp.getStudentGroupId() && Program.parentsFeedback[i].getDescription()!= null)
                {
                    currentNote = Program.parentsFeedback[i].getCreator().getFullName() + "     " +
                        Program.parentsFeedback[i].getDateTime().ToString("MM/dd/yyyy") + "\r\n" +
                        Program.parentsFeedback[i].getDescription() + "\r\n\r\n";
                    NoteboardString += currentNote;
                    ParentsFreeTextByGroup.Text = NoteboardString;
                    if(currentNote != "")
                        NoteboardStringList.Add(currentNote);
                }
            }
            for (int rows = 0; rows < Question1.Rows.Count-1; rows++)
            {
                Question1.Rows[rows].Cells[1].Value = avgQuestionbyGroup(temp, rows+1);
            }
        }

        private double avgQuestionbyGroup(StudentGroup sg, int questionid)
        {
            double avgquestionByGroup = 0;
            double numOfParentsFeedback = 0;

            foreach (Student s in sg.getStudents())
            {
                foreach (ParentsFeedBack pf in s.getParentFeedback())
                {
                    foreach (Grade g in pf.getGrades())
                    {
                        if (g.getQuestion().getId() == questionid)
                        {
                            avgquestionByGroup += g.getValue();
                            numOfParentsFeedback++;
                        }
                    }
                }
            }
            if (numOfParentsFeedback != 0)
            {
                double res = (avgquestionByGroup / numOfParentsFeedback);
                return Math.Round(res,2);
            }
            else
                return 0;
        }

        private void Question1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ParentsFreeTextByGroup_TextChanged(object sender, EventArgs e)
        {

        }

        private void xl_Click(object sender, EventArgs e)
        {
            copyAlltoClipboard();
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Microsoft.Office.Interop.Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            //worksheet name
            xlWorkSheet.Name = "ParentsFeedbackReport" ;
            //clipboard
            Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[2, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
            //header
            string[] header = new string[2];
            header[0] = "Question";
            header[1] = "Average Grade";
            xlWorkSheet.get_Range("B1", "C1").Value = header;
            //additionalComments
            xlWorkSheet.Cells[10, 2] = "Additional Comments";
            xlWorkSheet.Cells[11,2].Value = ParentsFreeTextByGroup.Text.Trim();
            //GroupId
            xlWorkSheet.Cells[2, 7] = "GroupID: " + temp.getId().ToString();

            //SetStyle
            xlWorkSheet.Columns[2].ColumnWidth = 50;
            xlWorkSheet.Columns[3].ColumnWidth = 50;
            xlWorkSheet.Columns[7].ColumnWidth = 30;
            xlWorkSheet.get_Range("B1", "C7").Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            xlWorkSheet.get_Range("B1", "C7").Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;
            Microsoft.Office.Interop.Excel.Style style = xlWorkBook.Styles.Add("NewStyle");

            style.Font.Name = "Verdana";
            style.Font.Size = 10;
            style.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.GreenYellow);
            style.Interior.Pattern = Microsoft.Office.Interop.Excel.XlPattern.xlPatternSolid;
            xlWorkSheet.get_Range("B1", "C1").Style = style;
            xlWorkSheet.Cells[10, 2].Style = style;
            xlWorkSheet.Cells[2, 7].Style = style;
        }

        private void copyAlltoClipboard()

        {
            Question1.SelectAll();
            DataObject dataObj = Question1.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogisticCoordinatorMain lcm = new LogisticCoordinatorMain();
            lcm.Show();

        }
    }
    
}

