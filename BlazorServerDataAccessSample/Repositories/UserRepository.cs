using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorServerDataAccessSample.Data;
using BlazorServerDataAccessSample.Data.Models;

namespace BlazorServerDataAccessSample.Repositories
{

    public class UserRepository : MasterRepository<User>, IUserRepository
    {
        public UserRepository(SampleDbContext context)
            : base(context)
        {

        }

        public SampleDbContext SampleDbContext
        {
            get { return _context as SampleDbContext; }
        }
    }
}
