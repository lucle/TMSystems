using System;
using System.Collections.Generic;
using System.Text;

namespace TMSystems.DomainModel
{
    public class StateOrProvince
    {
        public long CountryId { get; set; }

        public Country Country { get; set; }

        public string CountryCode { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }
    }
}
