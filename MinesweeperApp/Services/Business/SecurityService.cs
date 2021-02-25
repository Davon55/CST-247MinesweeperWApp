using MinesweeperApp.Models;
using MinesweeperApp.Services.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinesweeperApp.Services.Business
{
    public class SecurityService
    {
        
        
            SecurityDAO daoService = new SecurityDAO();

        public bool Authenticate(UserModel user)
        {
            return daoService.FindByUser(user);
        }

        public List<RegisterModel> findAll()
        {
            return daoService.FindAll();
        }
        public RegisterModel getById(int id)
        {
            return daoService.getById(id);
        }
        
    }
}
