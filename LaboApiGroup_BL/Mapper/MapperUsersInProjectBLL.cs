using LaboApiGroup_BL.Models;
using LaboApiGroup_Repo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboApiGroup_BL.Mapper
{
    public static class MapperUsersInProjectBLL
    {
        public static UsersInProject_BLL ToBLL(this UserInProject uip_repo)
        {
            return new UsersInProject_BLL()
            {
                Id = uip_repo.Id,
                Id_Project = uip_repo.Id_Project,
                Id_User = uip_repo.Id_User,
            };
        }
        public static UserInProject ToREPO(this UsersInProject_BLL uip)
        {
            return new UserInProject()
            {
                Id = uip.Id,
                Id_User = uip.Id_User,
                Id_Project = uip.Id_Project,
            };
        }
     }
}
