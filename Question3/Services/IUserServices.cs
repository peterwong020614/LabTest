using Question3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3.Services
{
    public interface IUserServices
    {
        Task<User> GetUserAsync(int? id);

        Task<User> AddUserAsync(PostRecord postRecord);
        Task<User> UpdateUserAsync(PostRecord postRecord);
        Task<User>DeleteUserAsync(PostRecord postRecord);

    }
}
