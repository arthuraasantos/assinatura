using System;
using Adm.Subscribe.Domain.Services;

namespace Adm.Subscribe.Domain.Entities
{
    public class User : AuditableEntity
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public User()
        {
            Id = Guid.NewGuid();
        }

        public User(string email, string password)
        {
            Id = Guid.NewGuid();
            Email = email;
            Password = password;
        }

        public bool IsNew() => UserService.IsNew(CreateDate);
    }
}
