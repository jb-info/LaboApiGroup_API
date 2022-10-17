using LaboApiGroup_BL.Models;
using LaboApiGroup_Repo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboApiGroup_BL.Mapper
{
    public static class MapperUsersBLL
    {
        public static Users_BLL Us_BLLtoUs_REPO(this Users us_repo)
        {
            return new Users_BLL()
            {
                Id = us_repo.Id,
                BirthDate = us_repo.BirthDate,
                Email = us_repo.Email,
                NickName = us_repo.NickName,
            };
        }
        public static Users Us_REPOtoUs_BLL(this Users_BLL us )
        {
            return new Users()
            {
                Id = us.Id,
                NickName = us.NickName,
                BirthDate = us.BirthDate,
                Email = us.Email,

            };
        }
    }
}
