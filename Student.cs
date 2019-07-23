using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kidumatica_Update
{
    class Student
    {
        private string id;
        private String firstName;
        private String lastName;
        private String gender;
        private DateTime dateOfBirth;
        private string parentName;
        private string emailAddress;
        private string privatePhone;
        private string parentPhone;
        private string city;
        private Classes classs;
        private int rating;
        private StudentGroup studentGroup;
        private System.Collections.Generic.List<Student> brothers;
        private System.Collections.Generic.List<ActivityFeedback> studentActivityFeedbacks;
        private System.Collections.Generic.List<ParentsFeedBack> parentFeedbacks;
        private string password;



        public Student(string id, String firstName, String lastName,
            String gender, DateTime dateOfBirth, string parentName,
            string emailAddress, string privatePhone, string parentPhone, string city,
            Classes classs, int rating, string password)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.gender = gender;
            this.dateOfBirth = dateOfBirth;
            this.parentName = parentName;
            this.emailAddress = emailAddress;
            this.privatePhone = privatePhone;
            this.parentPhone = parentPhone;
            this.city = city;
            this.classs = classs;
            this.rating = rating;
            this.studentActivityFeedbacks = new System.Collections.Generic.List<ActivityFeedback>();
            this.parentFeedbacks = new System.Collections.Generic.List<ParentsFeedBack>();
            this.brothers = new System.Collections.Generic.List<Student>();
            this.password = password;
        }

        public void addStudentActivityFeedbacks(ActivityFeedback c)
        {
            studentActivityFeedbacks.Add(c);
        }

        public int getRating()
        {
            return this.rating;
        }
        public String getId()
        {
            return this.id;
        }
        public void setRating(int Newrating)
        {
            this.rating = this.rating + Newrating;
        }

        public void setStudentGroup(StudentGroup s)
        {
            this.studentGroup = s;
        }
        public string getFirstName()
        {
            return this.firstName;
        }
        public string getLastName()
        {
            return this.lastName;
        }
        public void addStudentParentFeedback(ParentsFeedBack p)
        {
            parentFeedbacks.Add(p);
        }

        public String getFullName()
        {
            if (firstName != null && lastName != null)
                return firstName + " " + lastName;
            else
                return null;
        
        }
        public void setBrother(Student s) {
            brothers.Add(s);
        }
        public void setStudentActivityFeedbacks(ActivityFeedback ActivityFeedbacksOnStudent)
        {
            studentActivityFeedbacks.Add(ActivityFeedbacksOnStudent);
        }

        public string getPassword()
        {
            return this.password;
        }

        public StudentGroup getStudentGroup()
        {
            return studentGroup;
        }

        public static List<Student> sortByRating()
        {
            List<Student> sortRatingList = new List<Student>();
            foreach (Student stu in Program.students)
            {
                sortRatingList.Add(stu);
            }

            sortRatingList.Sort((a, b) => b.getRating().CompareTo(a.getRating()));
            return sortRatingList;
        }

        public List<ParentsFeedBack> getParentFeedback ()
        {
            return parentFeedbacks;
        }
        public List<ActivityFeedback> getActivityFeedback()
        {
            return studentActivityFeedbacks;
        }
    }
}
