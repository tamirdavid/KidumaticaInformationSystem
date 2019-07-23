using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kidumatica_Update
{
        class contain
        {
            private EquipmentDemand equipmentDemand;
            private Product product;
            private int quantity;
            private string description;

        public contain (EquipmentDemand equipmentDemand, Product product, int quantity, string description)
        {
            this.equipmentDemand = equipmentDemand;
            this.product = product;
            this.quantity = quantity;
            this.description = description;
        }

        public Product getProduct()
        {
            return product;
        }

        public EquipmentDemand getEquipmentDemand()
        {
            return equipmentDemand;
        }
        public int getQuantity()
        {
            return quantity;
        }
        public String getDescription()
        {
            return description;
        }
    }
}
