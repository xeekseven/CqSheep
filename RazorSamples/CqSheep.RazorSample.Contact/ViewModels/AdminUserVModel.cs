using System;
using System.Collections.Generic;
using System.Text;

namespace CqSheep.RazorSample.Contact.ViewModels
{
    public class AdminUserVModel
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string Role { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
