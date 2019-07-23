using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kidumatica_Update
{
    class Note
    {
        private int id;
        private DateTime dateTime;
        private DateTime lastShown;
        private String description;
        private String title;
        private Employee creator;
        private bool isActive;


        public Note(int id, DateTime datetime, DateTime lastShown, string description, string title, Employee creator)
        {
            this.id = id;
            this.dateTime = datetime;
            this.lastShown = lastShown;
            this.description = description;
            this.title = title;
            this.creator = creator;
            if (this.lastShown < DateTime.Now)
            {
                this.isActive = false;
            }
            else
            {
                this.isActive = true;
            }
        }
        public bool getActive()
        {
            return isActive;
        }

        public DateTime getNoteDT()
        {
            return this.dateTime;
        }
        public string getTitle()
        {
            return this.title;
        }

        public string getDescription()
        {
            return this.description;
        }
        public Employee getCreator()
        {
            return this.creator;
        }

        public int getId()
        {
            return this.id;
        }
        public DateTime getLastShown()
        {
            return this.lastShown;
        }
        
     }
}
