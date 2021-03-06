using BlazorServerDataAccessSample.Data;
using BlazorServerDataAccessSample.Data.Models;
using BlazorServerDataAccessSample.Repositories;
using System;
using System.Collections.Generic;

namespace BlazorServerDataAccessSample.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void Add(User entity)
        {
            throw new NotImplementedException();
        }

        public User Get(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// ユーザーデータを全件取得
        /// </summary>
        /// <returns></returns>
        public IEnumerable<User> GetAll()
        {
            return _userRepository.GetAll();
        }

        public void Remove(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
