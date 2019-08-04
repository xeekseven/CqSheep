using CqSheep.Utils.Repository.ColumnMapperCommon;
using CqSheep.Utils.Repository.MySqlDatabase;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CqSheep.RazorSample.Repositories.Entity
{
    public class UserEntity : MysqlEntity<string>
    {
        [Column(Name = "user_id")]
        public string UserId { get; set; }
        [Column(Name = "user_name")]
        public string UserName { get; set; }
        [Column(Name = "password")]
        public string Password { get; set; }
        [Column(Name = "role")]
        public string Role { get; set; }
        [Column(Name = "create_time")]
        public DateTime CreateTime { get; set; }
        [Column(Name = "update_time")]
        public DateTime UpdateTime { get; set; }
    }
}
