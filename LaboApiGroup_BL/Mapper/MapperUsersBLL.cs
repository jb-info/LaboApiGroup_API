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
        public static Users_BLL ToBLL(this Users us_repo)
        {
            return new Users_BLL()
            {
                Id = us_repo.Id,
                BirthDate = us_repo.BirthDate,
                Email = us_repo.Email,
                NickName = us_repo.NickName,
                IsAdmin = us_repo.IsAdmin,
                IsActive = us_repo.IsActive
            };
        }
        public static Users ToRepo(this Users_BLL us )
        {
            return new Users()
            {
                Id = us.Id,
                NickName = us.NickName,
                BirthDate = us.BirthDate,
                Email = us.Email,
                PassWord = us.PassWord,
                IsAdmin = us.IsAdmin,
                IsActive = us.IsActive
            };
        }
    }
}
