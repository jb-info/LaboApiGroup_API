using LaboApiGroup_BL.Models;
using LaboApiGroup_Repo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboApiGroup_BL.Mapper
{
    public static class MapperRoleOfUserBLL
    {
        public static RoleOfUser_BLL ToREPO(this RoleOfUser rou_repo )
        {
            return new RoleOfUser_BLL()
            {
                Id=rou_repo.Id,
                Id_Role=rou_repo.Id_Role,
                Id_User=rou_repo.Id_User,
            };


        }
        public static RoleOfUser ToBLL(this RoleOfUser_BLL rou)
        {
            return new RoleOfUser()
            {
                Id = rou.Id,
                Id_Role = rou.Id_Role,
                Id_User = rou.Id_User,

            };
        }
    }
}
