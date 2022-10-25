using LaboApiGroup_BL.Models;
using LaboApiGroup_Repo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboApiGroup_BL.Mapper
{
    public static class MapperRoleBLL
    {
        public static Role_BLL ToREPO(this Role r_repo )
        {
            return new Role_BLL
            {
                Id = r_repo.Id,
                Name = r_repo.Name,
            };

        }

        public static Role ToBLL(this Role_BLL r)
        {
            return new Role
            {
                Id = r.Id,
                Name = r.Name,
            };


        }
    }


    
}
