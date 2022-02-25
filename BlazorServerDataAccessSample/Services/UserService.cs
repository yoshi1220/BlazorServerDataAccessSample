using BlazorServerDataAccessSample.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using BlazorServerDataAccessSample.Data;
using BlazorServerDataAccessSample.Repositories;

namespace BlazorServerDataAccessSample.Services
{
    public class UserService : IUserService
    {
        private readonly SampleDbContext _context;

        public UserService(SampleDbContext context)
        {
            _context = context;
        }

        public void Add(User entity)
        {
            throw new NotImplementedException();
        }

        public User Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAll()
        {
            UserRepository userRepository = new UserRepository(_context);
            return userRepository.GetAll();
        }

        public void Remove(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
