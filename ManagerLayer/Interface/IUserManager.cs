using ModelLayer;
using ModelLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerLayer.Interface
{
   public interface IUserManager
    {
        Task<RegisterModel> Register(RegisterModel register);

        Task<RegisterModel> Login(LoginModel login);
        Task<bool> Forget(string email);
        Task<RegisterModel> Reset(ResetModel reset);
        public string GenerateToken(string email);
    }
}
