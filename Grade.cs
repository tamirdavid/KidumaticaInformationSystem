using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kidumatica_Update
{
    class Grade
    {

        private ParentsFeedBack parentFeedback;
        private Question question;
        private int value;

        public Grade( Question quest, int value)
        {
            //this.parentFeedback = pf;
            this.question = quest;
            this.value = value;
        }
        public void setParentFeedback(ParentsFeedBack pf)
        {
            this.parentFeedback = pf;
        }
        public int getValue()
        {
            return value;
        }
        public Question getQuestion()
        {
            return question;
        }
        public ParentsFeedBack getParentFeedback()
        {
            return parentFeedback;
        }
    }
}
