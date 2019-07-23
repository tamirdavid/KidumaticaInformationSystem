using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Kidumatica_Update
{
    static class Program
    {
        public static System.Collections.Generic.List<Employee> employees;
        public static System.Collections.Generic.List<Student> students;
        public static System.Collections.Generic.List<Product> products;
        public static System.Collections.Generic.List<StudentGroup> studentGroups;
        public static System.Collections.Generic.List<EquipmentDemand> equipmentDemands;
        public static System.Collections.Generic.List<ActivityFeedback> activityFeedback;
        public static System.Collections.Generic.List<Question> pfQuestions;
        public static System.Collections.Generic.List<ParentsFeedBack> parentsFeedback;
        public static System.Collections.Generic.List<Note> notes;
        public static Employee empUser;
        public static Student studUser;
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            init_Lists();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HomePage());
        }

        public static void init_Lists() {
            init_Employees();
            init_StudentGroups();
            init_Students();
            init_Brother();
            init_Products();
            init_EquipmentDemands();
            init_ActivityFeedback();
            init_Questions();
            init_ParentFeedback();
            init_Note();
        }  
        public static void init_Employees()
        { //מילוי המערך מתוך בסיס הנתונים
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_All_Employees";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            employees = new List<Employee>();

            while (rdr.Read())
            {
                EmployeeTypes T = (EmployeeTypes)Enum.Parse(typeof(EmployeeTypes), rdr.GetValue(10).ToString());
                Employee e = new Employee(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(), rdr.GetValue(2).ToString(), rdr.GetValue(3).ToString(), DateTime.Parse((rdr.GetValue(4).ToString())),
                    rdr.GetValue(5).ToString(), rdr.GetValue(6).ToString(), DateTime.Parse((rdr.GetValue(7).ToString())), rdr.GetValue(8).ToString(), Boolean.Parse((rdr.GetValue(12).ToString())), T, rdr.GetValue(13).ToString());
                employees.Add(e);
                Console.WriteLine(e.getId());
                
            }
        }

        public static void init_Products()
        { //מילוי המערך מתוך בסיס הנתונים
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_All_Products";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            products = new List<Product>();

            while (rdr.Read())
            {
                Product p = new Product(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString());
                products.Add(p);
            }
        }
        public static void init_StudentGroups()
        { //מילוי המערך מתוך בסיס הנתונים
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_All_StudentGroups";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            studentGroups = new List<StudentGroup>();

            while (rdr.Read())
            {
                Classes cl = (Classes)Enum.Parse(typeof(Classes), rdr.GetValue(2).ToString());
                StudentGroup sg = new StudentGroup(int.Parse(rdr.GetValue(0).ToString()), rdr.GetValue(1).ToString(), cl, int.Parse(rdr.GetValue(3).ToString()),
                    getEmployeeObject(rdr.GetValue(4).ToString()));
                sg.updateMentorGroup();
                studentGroups.Add(sg);
                getEmployeeObject(rdr.GetValue(4).ToString()).setStudentGroup(sg);
            }
        }
        public static void init_Students()
        { //מילוי המערך מתוך בסיס הנתונים
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_All_Students";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            students = new List<Student>();

            while (rdr.Read())
            {
                Classes cl = (Classes)Enum.Parse(typeof(Classes), rdr.GetValue(10).ToString());
                Student s = new Student(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(), rdr.GetValue(2).ToString(), rdr.GetValue(3).ToString(), DateTime.Parse((rdr.GetValue(4).ToString())),
                    rdr.GetValue(5).ToString(), rdr.GetValue(6).ToString(), rdr.GetValue(7).ToString(), rdr.GetValue(8).ToString(), rdr.GetValue(9).ToString(), cl, int.Parse(rdr.GetValue(11).ToString()), rdr.GetValue(13).ToString());
                students.Add(s);
                foreach (StudentGroup sg in studentGroups)
                    if (sg.getId().ToString() == rdr.GetValue(12).ToString())
                    {
                        s.setStudentGroup(sg);
                        sg.addStudent(s);
                    }
            }
        }
        public static Employee getEmployeeObject(String id)
        {
            Employee empRes = null;
            foreach(Employee emp in employees)
            {
                if (emp.getId() == id)
                    empRes = emp;
            }

            return empRes;
        }
        public static Employee getEmployeeObjectByName(String fullName)
        {
            Employee empRes = null;
            if (fullName != "")
            {
                String first = fullName.Split(' ')[0];
                String last = fullName.Split(' ')[1];
                foreach (Employee emp in employees)
                {
                    if (emp.getFirstName() == first && emp.getLastName() == last)
                        empRes = emp;
                }
                return empRes;
            }
            else
                return null;
        }
        public static StudentGroup getStudentGroupObject(int id)
        {
            StudentGroup studentRes = null;
            foreach (StudentGroup studentGroup in studentGroups)
            {
                if (studentGroup.getId() == id)
                    studentRes = studentGroup;
            }

            return studentRes;
        }
        public static ParentsFeedBack getParentsFeedbackObject(int id)
        {
            ParentsFeedBack pfRes = null;
            foreach (ParentsFeedBack pf in parentsFeedback)
            {
                if (pf.getId() == id)
                    pfRes = pf;
            }

            return pfRes;
        }
        public static Question getQuestionObject(int id)
        {
            Question questRes = null;
            foreach (Question quest in pfQuestions)
            {
                if (quest.getId() == id)
                    questRes = quest;
            }

            return questRes;
        }
        public static Student getStudentObject(String id)
        {
            Student studentRes = null;
            foreach (Student student in students)
            {
                if (student.getId() == id)
                    studentRes = student;
            }

            return studentRes;
        }
        public static Student getStudentObjectByName(String fullName)
        {
            Student studentRes = null;
            String first = fullName.Split(' ')[0];
            String last = fullName.Split(' ')[1];
            foreach (Student student in students)
            {
                if (student.getFirstName() == first && student.getLastName() == last)
                    studentRes = student;
            }

            return studentRes;
        }
        public static void init_EquipmentDemands()
        { //מילוי המערך מתוך בסיס הנתונים
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_All_EquipmentDemands";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            equipmentDemands = new List<EquipmentDemand>();

            while (rdr.Read())
            {
                EquipmentDemand ed = new EquipmentDemand(int.Parse(rdr.GetValue(0).ToString()), getEmployeeObject(rdr.GetValue(1).ToString()), DateTime.Parse((rdr.GetValue(5).ToString())), rdr.GetValue(2).ToString());
                equipmentDemands.Add(ed);
                init_contain(ed.getId());
                ed.setStatus(rdr.GetValue(3).ToString());
                ed.addApprovalNote(rdr.GetValue(4).ToString());
                ed.getCreator().addEquipmentDemand(ed);

            }
        }
        public static void init_ActivityFeedback()
        { //מילוי המערך מתוך בסיס הנתונים
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_All_ActivityFeedbacks";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            activityFeedback = new List<ActivityFeedback>();

            while (rdr.Read())
            {
                ActivityFeedback af = new ActivityFeedback(int.Parse(rdr.GetValue(0).ToString()), DateTime.Parse((rdr.GetValue(1).ToString())),
                rdr.GetValue(2).ToString(), getEmployeeObject(rdr.GetValue(3).ToString()), getEmployeeObject(rdr.GetValue(4).ToString()), getStudentObject(rdr.GetValue(5).ToString()));
                activityFeedback.Add(af);
                getEmployeeObject(rdr.GetValue(3).ToString()).addCreatedActivityFeedback(af);

            }
        }
        public static void init_Questions()
        { //מילוי המערך מתוך בסיס הנתונים
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_All_Questions";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            pfQuestions = new List<Question>();

            while (rdr.Read())
            {
                Question quest = new Question(int.Parse(rdr.GetValue(0).ToString()), rdr.GetValue(1).ToString(), Boolean.Parse((rdr.GetValue(2).ToString())));
                pfQuestions.Add(quest);
            }
        }
        public static void init_ParentFeedback()
        { //מילוי המערך מתוך בסיס הנתונים
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_All_ParentFeedback";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            parentsFeedback = new List<ParentsFeedBack>();

            while (rdr.Read())
            {
                ParentsFeedBack pf = new ParentsFeedBack(int.Parse(rdr.GetValue(0).ToString()), getStudentObject(rdr.GetValue(1).ToString()), DateTime.Parse((rdr.GetValue(2).ToString())), 
                   rdr.GetValue(3).ToString());
                parentsFeedback.Add(pf);
                init_Grades(pf.getId());

            }
        }
        public static void init_Grades(int pfId)
        { //מילוי המערך מתוך בסיס הנתונים
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_All_Grades "+pfId;
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            while (rdr.Read())
            {
                Grade g = new Grade(getQuestionObject(int.Parse(rdr.GetValue(1).ToString())), int.Parse(rdr.GetValue(2).ToString()));
                getParentsFeedbackObject(pfId).addGrade(g);
                g.setParentFeedback(getParentsFeedbackObject(pfId));
            }
        }
        public static void init_contain(int edId)
        { //מילוי המערך מתוך בסיס הנתונים
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_All_Contain " + edId;
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            while (rdr.Read())
            {
                contain con = new contain(getEquipmentDemandObject(edId), getProductObject(rdr.GetValue(0).ToString()),
                   int.Parse(rdr.GetValue(2).ToString()), rdr.GetValue(3).ToString());
                getEquipmentDemandObject(edId).addContain(con);
            }
        }
        public static EquipmentDemand getEquipmentDemandObject(int id)
        {
            EquipmentDemand edRes = null;
            foreach (EquipmentDemand ed in equipmentDemands)
            {
                if (ed.getId() == id)
                    edRes = ed;
            }

            return edRes;
        }
        public static Product getProductObject(String name)
        {
            Product productRes = null;
            foreach (Product product in products)
            {
                if (product.getName() == name)
                    productRes = product;
            }

            return productRes;
        }
        public static void init_Note()
        { //מילוי המערך מתוך בסיס הנתונים
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_All_Note";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            notes = new List<Note>();

            while (rdr.Read())
            {
                Note note = new Note(int.Parse(rdr.GetValue(0).ToString()), DateTime.Parse((rdr.GetValue(1).ToString())),
                   DateTime.Parse((rdr.GetValue(2).ToString())), rdr.GetValue(3).ToString(), rdr.GetValue(4).ToString(), getEmployeeObject(rdr.GetValue(5).ToString()));
                notes.Add(note);
            }
        }

        public static void init_Brother()
        {
            foreach (Student s in students)
            {
                SqlCommand c = new SqlCommand();
                c.CommandText = "EXECUTE dbo.Get_All_Brothers " + s.getId().ToString();
                SQL_CON SC = new SQL_CON();
                SqlDataReader rdr = SC.execute_query(c);

                while (rdr.Read())
                {
                    s.setBrother(getStudentObject(rdr.GetValue(0).ToString()));
                }
            }
        }
      
        public static void create_EquipmentDemand_In_DB(EquipmentDemand ed)
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_add_EquipmentDemand @id, @Emp, @reason";
            c.Parameters.AddWithValue("@id", ed.getId());
            if (ed.getCreator() != null)
            {
                c.Parameters.AddWithValue("@Emp", ed.getCreator().getId());
            }
            c.Parameters.AddWithValue("@reason", ed.getReason());
            Console.WriteLine(c.ToString());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public static void create_Contain_In_DB(contain con)
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_add_Contain @ProductName, @EdId, @Quantity,  @Description ";
            c.Parameters.AddWithValue("@ProductName", con.getProduct().getName());
            c.Parameters.AddWithValue("@EdId", con.getEquipmentDemand().getId());
            c.Parameters.AddWithValue("@Quantity", con.getQuantity());
            c.Parameters.AddWithValue("@Description", con.getDescription());
            Console.WriteLine(c.ToString());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public static List<Note> sortByDateAndActive()
        {
            List<Note> templist = new List<Note>();
            foreach (Note aa in Program.notes)
            {
                if (aa.getActive() == true)
                    templist.Add(aa);
            }
            templist.Sort((b, a) => a.getNoteDT().CompareTo(b.getNoteDT()));
            return templist;
        }

        public static void update_ed_status_in_DB(EquipmentDemand ed, String status)
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_update_EquipmentDemand_status @EquipmentDemand, @status";
            c.Parameters.AddWithValue("@EquipmentDemand", ed.getId());
            c.Parameters.AddWithValue("@status", ed.getStatus());
            Console.WriteLine(c.ToString());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
        public static void update_ed_approvalNote_in_DB(EquipmentDemand ed, String status)
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_update_EquipmentDemand_ApprovalNote @EquipmentDemand, @ApprovalNote";
            c.Parameters.AddWithValue("@EquipmentDemand", ed.getId());
            c.Parameters.AddWithValue("@ApprovalNote", ed.getApprovalNote());
            Console.WriteLine(c.ToString());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
        public static void create_note_In_DB(Note note)
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_add_Note @NoteID, @NoteDT, @LastShow, @Description, @Title, @NoteCreator ";
            c.Parameters.AddWithValue("@NoteID", note.getId());
            c.Parameters.AddWithValue("@NoteDT", note.getNoteDT());
            c.Parameters.AddWithValue("@LastShow", note.getLastShown());
            c.Parameters.AddWithValue("@Description", note.getDescription());
            c.Parameters.AddWithValue("@Title", note.getTitle());
            c.Parameters.AddWithValue("@NoteCreator", note.getCreator().getId());
            Console.WriteLine(c.ToString());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public static void Update_Student_Rating_In_DB(Student s)
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Update_Student_Rating @ID, @Rating ";
            c.Parameters.AddWithValue("@ID", s.getId());
            c.Parameters.AddWithValue("@Rating", s.getRating());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
        public static void create_ParentFeedbak_In_DB(ParentsFeedBack pf)
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_create_ParentFeedbak @ID, @StudentId, @DT, @Description ";
            c.Parameters.AddWithValue("@ID", pf.getId());
            c.Parameters.AddWithValue("@StudentId", pf.getCreator().getId());
            c.Parameters.AddWithValue("@DT", pf.getDateTime());
            c.Parameters.AddWithValue("@Description", pf.getDescription());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public static void create_Grade_In_DB(Grade g)
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_create_Grade @pfID, @qId, @value ";
            c.Parameters.AddWithValue("@pfID", g.getParentFeedback().getId());
            c.Parameters.AddWithValue("@qId", g.getQuestion().getId());
            c.Parameters.AddWithValue("@value", g.getValue());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public static void create_ActivityFeedback_In_DB(ActivityFeedback af)
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_add_ActivityFeedback1 @Id, @Dt, @Description, @Creator";
            c.Parameters.AddWithValue("@id", af.getId());
            c.Parameters.AddWithValue("@Dt", af.getDateTime());
            c.Parameters.AddWithValue("@Description", af.getDescription());
            if (af.getCreator() != null)
                c.Parameters.AddWithValue("@Creator", af.getCreator().getId());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
        public static void update_ActivityFeedback_Recieve_Employee_In_DB(ActivityFeedback af)
        {
            if (af.getRecieveEmployee() != null)
            {
                SqlCommand c = new SqlCommand();
                c.CommandText = "EXECUTE dbo.SP_add_ActivityFeedback_Recieve_Employee @RecieveEmployee, @Id";
                c.Parameters.AddWithValue("@RecieveEmployee", af.getRecieveEmployee().getId());
                c.Parameters.AddWithValue("@Id", af.getId());
                SQL_CON SC = new SQL_CON();
                SC.execute_non_query(c);
            }
        }
        public static void update_ActivityFeedback_Recieve_Student_In_DB(ActivityFeedback af)
        {
            if (af.getRecieveStudent() != null)
            {
                SqlCommand c = new SqlCommand();
                c.CommandText = "EXECUTE dbo.SP_add_ActivityFeedback_Recieve_Student @RecieveStudent, @Id";
                c.Parameters.AddWithValue("@RecieveStudent", af.getRecieveStudent().getId());
                c.Parameters.AddWithValue("@Id", af.getId());
                SQL_CON SC = new SQL_CON();
                SC.execute_non_query(c);
            }
        }

    }


}//close Space
