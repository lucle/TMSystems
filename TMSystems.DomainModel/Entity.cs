using System;
using System.Collections.Generic;
using System.Text;

namespace TMSystems.DomainModel
{
   public class Entity
    {
        public string Slug { get; set; }

        public string Name { get; set; }

        public long EntityId { get; set; }

        public long EntityTypeId { get; set; }

        public EntityType EntityType { get; set; }
    }
}
