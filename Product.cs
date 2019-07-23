using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kidumatica_Update
{
    class Product
    {
        private String name;
        private String additionalInformation;

        public Product (String name, String additionalInformation)
        {
            this.name = name;
            this.additionalInformation = additionalInformation;
        }

        public String getName()
        {
            return this.name;
        }
    }
}
