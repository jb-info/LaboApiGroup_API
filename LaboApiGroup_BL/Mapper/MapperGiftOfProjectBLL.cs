using LaboApiGroup_BL.Models;
using LaboApiGroup_Repo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboApiGroup_BL.Mapper
{
    public static class MapperGiftOfProjectBLL
    {
        public static GiftOfProject_BLL GOP_BLLtoGOP_REPO(this GiftOfProject gop_repo )
        {
            return new GiftOfProject_BLL()
            {
                Password = gop_repo.Password,
                Id_Gift=gop_repo.Id_Gift,
                Id_Project=gop_repo.Id_Project,
            };
        }
        public static GiftOfProject GOP_REPOtoGOP_BLL(this GiftOfProject_BLL gop)
        {
            return new GiftOfProject()
            {
                Password=gop.Password,
                Id_Gift= gop.Id_Gift,
                Id_Project= gop.Id_Project,

            };

        }
    }
}
