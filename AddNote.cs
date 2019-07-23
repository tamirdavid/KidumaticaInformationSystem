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
    public partial class AddNote : Form
    {
        public AddNote()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            try
            {
                string noteTitle;
                noteTitle = NoteTitleTextBox.Text.ToString();
                string noteDescription;
                noteDescription = NoteDescription.Text.ToString();

                if (string.IsNullOrWhiteSpace(noteTitle) || string.IsNullOrWhiteSpace(noteDescription))
                {
                    throw new Exception();
                }


                DateTime noteLastShown;
                noteLastShown = LastShownDT.Value;

                Note n = new Note(Program.notes.Count + 1, DateTime.Now, noteLastShown, noteDescription, noteTitle, Program.empUser);
                Program.notes.Add(n);
                Program.empUser.addNote(n);
                Program.create_note_In_DB(n);
                back_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("All Fields are Required", "Note", MessageBoxButtons.OK);
            }
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ExpiryDate_Click(object sender, EventArgs e)
        {

        }

        private void NoteDescription_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
