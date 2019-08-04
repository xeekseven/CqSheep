using CqSheep.RazorSample.Repositories.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CqSheep.RazorSample.Repositories.Interfaces
{
    public interface IUserRepository
    {
        UserEntity QueryUser(string userName, string passwordHash);
        void InsertUser(UserEntity entity);

    }
}
