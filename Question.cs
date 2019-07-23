using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kidumatica_Update
{
    class Question
    {
        private int id;
        private String Quest;
        private Boolean isActive;

        public Question(int id, String Quest, Boolean isActive) {
            this.id = id;
            this.Quest = Quest;
            this.isActive = isActive;
        }
        public int getId()
        {
            return id;
        }
        public String getQuestion()
        {
            return Quest;
        }
        public void turnActive()
        {
            isActive = true;
        }
        public void turnInActive()
        {
            isActive = false;
        }

        public override string ToString()
        {
            return this.Quest;
        }
    }
}
