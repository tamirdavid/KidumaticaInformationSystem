using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kidumatica_Update
{
    class ParentsFeedBack
    {
        private int id;
        private DateTime dateTime;
        private Student creator;
        private System.Collections.Generic.List<Grade> grades;
        private String description;
        


        public ParentsFeedBack(int id, Student creator, DateTime dateTime, String description)
        {
            this.id = id;
            this.creator = creator;
            this.dateTime = dateTime;            
            this.grades = new List<Grade>();
            this.description = description;
            creator.addStudentParentFeedback(this);
        }

        public  void addGrade(Grade grade) {
            this.grades.Add(grade);
        }
        public void addGrades(List<Grade> gradesCollection)
        {
            foreach (Grade g in gradesCollection)
                this.addGrade(g);
        }
        public List<Grade> getGrades()
        {
            return grades;
        }
        public int getId()
        {
            return id;
        }
        public Student getCreator()
        {
            return creator;
        }
        public String getDescription()
        {
            return description;
        }
        public DateTime getDateTime()
        {
            return dateTime;
        }
    }
}
