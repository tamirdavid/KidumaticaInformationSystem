using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kidumatica_Update
{
    class EquipmentDemand
    {
        private int id;
        private Employee creator;
        private DateTime dateTime;
        private string reasonForDemand;
        private System.Collections.Generic.List<contain> ContainsProducts;
        private String status;
        private String approvalNote;

        public EquipmentDemand(int id, Employee creator, DateTime dateTime, string reasonForDemand)
        {
            this.id = id;
            this.creator = creator;
            this.dateTime = dateTime;
            this.reasonForDemand = reasonForDemand;
            this.ContainsProducts = new System.Collections.Generic.List<contain>();
            this.status = "Not Handeled";
            this.approvalNote = "null";
        }

        public int getId()
        {
            return this.id;
        }

        public void addContain(contain c)
        {
            ContainsProducts.Add(c);
        }
        public List<contain> getContain()
        {
            return ContainsProducts;
        }
        public Employee getCreator()
        {
            return creator;
        }
        public String getReason()
        {
            return reasonForDemand;
        }
        public DateTime getDateTime()
        {
            return dateTime;
        }
        public String getDetails()
        {
            String res = null;
            foreach(contain c in ContainsProducts)
            {
                res += "Product: " + c.getProduct().getName() + " Quantity " + c.getQuantity() + " Description: " + c.getDescription() + "\r\n";
            }
            return res;
        }
        public void approved()
        {
            status = "Approved";
        }
        public void notApproved()
        {
            status = "Not Approved";
        }
        public String getStatus()
        {
            return status;
        }
        public void setStatus(String status)
        {
            this.status = status;
        }
        public String getApprovalNote()
        {
            return approvalNote;
        }
        public void addApprovalNote(String an)
        {
            approvalNote = an;
        }
    }
}
