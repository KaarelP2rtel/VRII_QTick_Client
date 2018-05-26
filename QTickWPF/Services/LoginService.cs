using QTickWPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTickWPF.Services
{
    public class LoginService : BaseService<LoginDTO,TokenDTO>
    {
        public async Task<string> GetToken(string user, string pass)
        {
            var login = new LoginDTO { Email = user, Password = pass };
            return (await PostAsync("Security/GetToken",login)).Token;
        }
    }
}