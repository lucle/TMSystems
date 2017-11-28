using System;
using System.Collections.Generic;
using System.Text;

namespace TMSystems.DomainModel
{
   public class EntityType
    {
        public string Name { get; set; }

        public bool IsMenuable { get; set; }

        public string RoutingController { get; set; }

        public string RoutingAction { get; set; }
    }
}
