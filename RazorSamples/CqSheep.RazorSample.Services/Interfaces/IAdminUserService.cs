using CqSheep.RazorSample.Contact.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CqSheep.RazorSample.Services.Interfaces
{
    public interface IAdminUserService
    {
        AdminUserVModel GetUser(string userName, string password);
        void AddAdminUser(AdminUserVModel vmodel, string password);
    }
}
