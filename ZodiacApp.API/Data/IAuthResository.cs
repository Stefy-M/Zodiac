using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ZodiacApp.API.Models;

namespace ZodiacApp.API.Data
{
    public interface IAuthRepository
    {
         Task<User> Register(User user, string password);

         Task<User> Login(string username, string password);

         Task<bool> UserExists(string username);
    }
}