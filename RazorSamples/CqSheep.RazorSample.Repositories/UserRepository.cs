using CqSheep.RazorSample.Repositories.Entity;
using CqSheep.RazorSample.Repositories.Interfaces;
using CqSheep.Utils.Repository.MySqlDatabase;
using System;
using System.Collections.Generic;
using System.Text;

namespace CqSheep.RazorSample.Repositories
{
    public class UserRepository : MysqlRepository<UserEntity,string> , IUserRepository
    {
        public UserRepository(string databaseName, string baseConnectString) : base(databaseName, baseConnectString)
        {

        }

        public void InsertUser(UserEntity entity)
        {
            if(entity != null)
            {
                string sqlText = "INSERT INTO admin_user VALUES(uuid(),uuid(),@UserName,@Password,@Role,now(),now())";
                this.Insert(sqlText, new { UserName = entity.UserName, Password = entity.Password, Role = entity.Role });
            }
        }

        public UserEntity QueryUser(string userName,string passwordHash)
        {
            string sqlText = "SELECT * FROM admin_user WHERE user_name = @username AND password = @password";
            var entity = this.Query(sqlText, new { username = userName, password = passwordHash });
            return entity;
        }
    }
}
