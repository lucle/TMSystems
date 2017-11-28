using System;
using System.Collections.Generic;
using System.Text;

namespace TMSystems.DomainModel
{
   public class Media
    {
        public string Caption { get; set; }

        public int FileSize { get; set; }

        public string FileName { get; set; }

        public MediaType MediaType { get; set; }
    }
}
