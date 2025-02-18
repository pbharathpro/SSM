using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SSM.Repositories.Entity;

namespace SSM.Repositories.Interface
{
    public interface IUserRepository
    {
        Task<List<User>> GetAll();

        Task<User> GetById(Guid userId);
        Task<User> CreateUser(User user);
        Task<bool> DeleteUserById(Guid userId);


    }

}
