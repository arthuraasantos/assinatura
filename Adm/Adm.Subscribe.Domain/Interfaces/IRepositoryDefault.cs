using System;
using System.Collections.Generic;
using Adm.Subscribe.Domain.Entities;

namespace Adm.Subscribe.Domain.Interfaces
{
    public interface IRepositoryDefault<T>
        where T: AuditableEntity
    {
        void Save(T entity);
        T Get(Guid id);
        IEnumerable<T> Get(int quantityRecords);
        void Delete(Guid id);
    }
}
