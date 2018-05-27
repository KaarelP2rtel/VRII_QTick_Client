using QTickWPF.Models;
using QTickWPF.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTickWPF.Services
{
    public class RegisterService : BaseService
    {
        public async Task<ApplicationUser> RegisterAsync(RegisterDTO registerDTO)
        {
            
            return await PostAsync<RegisterDTO, ApplicationUser>("User/Register", registerDTO);
        }

    }
}
