using System;

namespace Adm.Subscribe.Domain.Entities
{
    public abstract class AuditableEntity : EntityBase
    {
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}
