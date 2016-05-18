using System;

namespace Adm.Subscribe.Domain.Services
{
    public static class UserService
    {
        public static bool IsNew(DateTime createDate) 
            => createDate.AddDays(30).Date >= DateTime.Today.Date;
    }
}
