using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository
{
    public abstract class EntityBase : IObjectState
    {
        public EntityBase()
        {
            this.id = Guid.NewGuid();
        }
        public Guid id { get; set; }

        public bool deleted { get; set; }

        [NotMapped]
        public ObjectState ObjectState { get; set; } //TODO: Renamed since a possible coflict with State entity column
    }
}