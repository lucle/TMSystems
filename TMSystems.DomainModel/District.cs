using System;
using System.Collections.Generic;
using System.Text;

namespace TMSystems.DomainModel
{
    public class District
    {
        public long StateOrProvinceId { get; set; }

        public virtual StateOrProvince StateOrProvince { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public string Location { get; set; }
    }
}
