using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kidumatica_Update
{
    class ActivityFeedback
    {
        private int id;
        private DateTime dateTime;
        private string description;

        private Employee createEmployee;
        private Employee recieveEmployee;
        private Student recieveStudent;


        public ActivityFeedback(int id ,DateTime dateTime, string description, Employee createEmployee, Employee recieveEmployee, Student recieveStudent)
        {
            this.id = id;
            this.dateTime = dateTime;
            this.description = description;
            this.createEmployee = createEmployee;
            this.recieveEmployee = recieveEmployee;
            this.recieveStudent = recieveStudent;
            if(createEmployee != null)
                createEmployee.addCreatedActivityFeedback(this);
            if(recieveEmployee != null)
                recieveEmployee.addRecievedActivityFeedback(this);
            if (recieveStudent != null)
                recieveStudent.addStudentActivityFeedbacks(this);
        }
        public int getId()
        {
            return id;
        }
        public DateTime getDateTime()
        {
            return dateTime;
        }
        public String getDescription()
        {
            return description;
        }
        public Employee getCreator()
        {
            return createEmployee;
        }
        public Employee getRecieveEmployee()
        {
            return recieveEmployee;
        }
        public Student getRecieveStudent()
        {
            return recieveStudent;
        }
    }
}
