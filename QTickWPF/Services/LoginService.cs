using QTickWPF.Models;
using QTickWPF.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTickWPF.Services
{
    public class LoginService : BaseService
    {
        public async Task<string> GetTokenAsync(string user, string pass)
        {
            var login = new LoginDTO { Email = user, Password = pass };
            return (await PostAsync<LoginDTO,TokenDTO>("Security/GetToken",login)).Token;
        }
        public async Task<ApplicationUser> RegisterAsync(RegisterDTO registerDTO)
        {

            return await PostAsync<RegisterDTO, ApplicationUser>("User/Register", registerDTO);
        }
    }
}