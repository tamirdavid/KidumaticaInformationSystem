using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;//חשוב!
using System.Windows.Forms;//עבור ההודעות!
using System.Data;

namespace Kidumatica_Update
{
    class SQL_CON
    {
         SqlConnection conn;
         
        public SQL_CON(){
            //conn = new SqlConnection("Data Source=dbdesign.database.windows.net;Initial Catalog=SAD_N5;User ID=michalyo@bgufbm.onmicrosoft.com;Password=Michal26;Authentication='Active Directory Password'");
            conn = new SqlConnection("Data Source = dbdesign.database.windows.net; Initial Catalog = SAD_N5; Persist Security Info = True; User ID = noyamama@bgufbm.onmicrosoft.com; Password = nOYa2367; Authentication = 'Active Directory Password'");
        }

        public void execute_non_query(SqlCommand cmd){
           
            try
         {
             // open a connection object
             this.conn.Open();
             cmd.Connection = conn;
             cmd.ExecuteNonQuery();
             MessageBox.Show(" השאילתה בוצעה בהצלחה", "המשך", MessageBoxButtons.OK);
         }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "המשך", MessageBoxButtons.OK);
                MessageBox.Show("שגיאה בביצוע השאילתה", "המשך", MessageBoxButtons.OK);
            }
           finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        public SqlDataReader execute_query(SqlCommand cmd){
            try
               {
                   // open a connection object
                     conn.Open();
                     cmd.Connection = conn;
                     SqlDataReader READER =cmd.ExecuteReader(); 
                     return READER;
              }
            catch (Exception ex)
               {
                MessageBox.Show(ex.Message, "המשך", MessageBoxButtons.OK);
                return null;
              }


        }

    }

}