using AutoMapper;
using CqSheep.RazorSample.Contact.ViewModels;
using CqSheep.RazorSample.Repositories.Entity;
using CqSheep.RazorSample.Repositories.Interfaces;
using CqSheep.RazorSample.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace CqSheep.RazorSample.Services
{
    public class AdminUserService : IAdminUserService
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;
        public AdminUserService(IUserRepository userRepository)
        {
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<UserEntity, AdminUserVModel>();
            });
            _mapper = configuration.CreateMapper();
            _userRepository = userRepository;
        }
        public AdminUserVModel GetUser(string userName, string password)
        {
            byte[] SHA256Data = Encoding.UTF8.GetBytes(password);

            SHA256Managed Sha256 = new SHA256Managed();
            byte[] by = Sha256.ComputeHash(SHA256Data);

            string pwdHash = BitConverter.ToString(by).Replace("-", "").ToLower(); //64
            var adminEntity = _userRepository.QueryUser(userName, pwdHash);
            var adminVModel = _mapper.Map<AdminUserVModel>(adminEntity);
            return adminVModel;
        }
        public void AddAdminUser(AdminUserVModel vmodel,string password)
        {
            byte[] SHA256Data = Encoding.UTF8.GetBytes(password);

            SHA256Managed Sha256 = new SHA256Managed();
            byte[] by = Sha256.ComputeHash(SHA256Data);

            string pwdHash = BitConverter.ToString(by).Replace("-", "").ToLower(); //64
            UserEntity entity = new UserEntity
            {
                UserName = vmodel.UserName,
                Password = pwdHash,
                Role = vmodel.Role
            };
            _userRepository.InsertUser(entity);
        }
        public void SignAdminWebsite(string userName)
        {
            throw new NotImplementedException();
        }
    }
}
