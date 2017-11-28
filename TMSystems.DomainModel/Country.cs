using System;
using System.Collections.Generic;
using System.Text;

namespace TMSystems.DomainModel
{
   public class Country
    {
        public string Name { get; set; }

        public string Code2 { get; set; }

        public string Code3 { get; set; }

        public bool IsBillingEnabled { get; set; }

        public bool IsShippingEnabled { get; set; }
    }
}
