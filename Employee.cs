using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kidumatica_Update
{
    class Employee
    {
        private string id;
        private string firstName;
        private string lastName;
        private string gender;
        private DateTime dateOfBirth;
        private string emailAddress;
        private string phone;
        private DateTime workStartDate;
        private string speciality;
        private Boolean watchedEcp;
        private System.Collections.Generic.List<ActivityFeedback> createdActivityFeedback;
        private System.Collections.Generic.List<ActivityFeedback> recievedActivityFeedback;
        private StudentGroup studentGroup;
        private System.Collections.Generic.List<EquipmentDemand> createdEquipmentDemands;
        private System.Collections.Generic.List<Note> createdNotes;
        private EmployeeTypes type;
        private string password;

        public Employee(string id, string firstName, string lastName, string gender, DateTime dateOfBirth, string emailAddress,
            string phone, DateTime workStartDate, string speciality, Boolean watchedEcp, EmployeeTypes type, string password)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.gender = gender;
            this.dateOfBirth = dateOfBirth;
            this.emailAddress = emailAddress;
            this.phone = phone;
            this.workStartDate = workStartDate;
            this.speciality = speciality;
            this.watchedEcp = watchedEcp;
            this.createdNotes = new System.Collections.Generic.List<Note>();
            this.createdEquipmentDemands = new System.Collections.Generic.List<EquipmentDemand>();
            this.recievedActivityFeedback = new System.Collections.Generic.List<ActivityFeedback>();
            this.createdActivityFeedback = new System.Collections.Generic.List<ActivityFeedback>();
            this.type = type;
            this.password = password;
            this.studentGroup = null;
        }


        public void setStudentGroup(StudentGroup s)
        {
            this.studentGroup = s;
        }
        public StudentGroup getStudentGroup()
        {
            return studentGroup;
        }
        public string getPassword()
        {
            return this.password;
        }
        public string getFirstName()
        {
            return this.firstName;
        }
        public string getLastName()
        {
            return this.lastName;
        }
        public String getFullName()
        {
            return firstName + " " + lastName;
        }
        public void addCreatedActivityFeedback(ActivityFeedback a)
        {
            this.createdActivityFeedback.Add(a);
        }
        public void addRecievedActivityFeedback(ActivityFeedback b)
        {
            this.recievedActivityFeedback.Add(b);
        }

        public String getId()
        {
            return this.id; 
        }

        public EmployeeTypes getType()
        {
            return this.type;
        }
        public List<EquipmentDemand> getEquipmentDemands()
        {
            return createdEquipmentDemands;
        }

        public void addEquipmentDemand(EquipmentDemand ed)
        {
            createdEquipmentDemands.Add(ed);
        }
        public void addNote(Note n)
        {
            createdNotes.Add(n);
        }
        public List<ActivityFeedback> getActivityFeedbacks()
        {
            return recievedActivityFeedback;
        }
    }
}
