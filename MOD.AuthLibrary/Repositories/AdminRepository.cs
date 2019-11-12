using System;
using System.Collections.Generic;
using System.Text;
using MOD.AuthLibrary.Models;

namespace MOD.AuthLibrary.Repositories
{
    public class AdminRepository : IAdminRepository
    {
        public AdminRepository()
        {

        }

        bool IAdminRepository.AddSkill(Skill model)
        {
            throw new NotImplementedException();
        }
    }
}
