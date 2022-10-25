using LaboApiGroup_BL.Models;
using LaboApiGroup_Repo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboApiGroup_BL.Interfaces
{
    public interface IUserService : IGlobalInterfaces<Guid, Users_BLL>
    {
        public Users_BLL Login(Users_BLL u);
        public bool SwitchStatus(Users_BLL u);
    }
}
