using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kidumatica_Update
{
    class StudentGroup
    {
        private int groupID;
        private string level;
        private Classes studentClass;
        private int groupRoom;
        private Employee Mentor;
        private System.Collections.Generic.List<Student> students;

        public StudentGroup(int groupID, string level, Classes studentClass, int groupRoom, Employee Mentor)
        {
            this.groupID = groupID;
            this.level = level;
            this.studentClass = studentClass;
            this.groupRoom = groupRoom;
            this.Mentor = Mentor;
            this.students = new System.Collections.Generic.List<Student>();
        }

        public void addStudent(Student s)
        {
           students.Add(s);
        }

        public void updateMentorGroup()
        {
            this.Mentor.setStudentGroup(this);
        }

        public int getId()
        {
            return groupID;
        }
        public List<Student> getStudents()
        {
            return students;
        }
        public Employee getSMentor()
        {
            return Mentor;
        }

        public int getStudentGroupId()
        {
            return groupID;
        }
        public override string ToString()
        {
            return this.groupID.ToString();
        }
    }
}
