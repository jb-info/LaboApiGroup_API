using LaboApiGroup_BL.Models;
using LaboApiGroup_Repo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboApiGroup_BL.Mapper
{
    public static class MapperGiftBLL
    {
        public static Gift_BLL GiftBLLToGiftRepo(this Gift gf_Repo)
        {
            return new Gift_BLL()
            {
                Id = gf_Repo.Id,
                Gift_Type = gf_Repo.Gift_Type,
                landing = gf_Repo.landing,

            };




        }
        public static Gift GiftRepoToGiftBLL(this Gift_BLL gift_bll)
        {
            return new Gift()
            {
                Id = gift_bll.Id,
                Gift_Type = gift_bll.Gift_Type,
                landing = gift_bll.landing,
            }; 

        }


    }    
}
