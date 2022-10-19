using LaboApiGroup_BL.Models;
using LaboApiGroup_Repo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboApiGroup_BL.Mapper
{
    public static class MapperProjectBLL
    {
        public static Project_BLL P_BLLtoP_REPO(this Project pr_repo)
        {
            return new Project_BLL
            {
                Id = pr_repo.Id,
                Start_Date = pr_repo.Start_Date,
                End_Date = pr_repo.End_Date,
                Description = pr_repo.Description,
                Title = pr_repo.Title,
                Financial_Targets = pr_repo.Financial_Targets,
                Earn_Money = pr_repo.Earn_Money,

            };
        }

        public static Project P_RepotoP_BLL(this Project_BLL pr)
        {
            return new Project
            {
                Id = pr.Id,
                Start_Date = pr.Start_Date,
                End_Date = pr.End_Date,
                Description = pr.Description,
                Title = pr.Title,
                Financial_Targets = pr.Financial_Targets,
                Earn_Money = pr.Earn_Money,
            };
        }
    }
}


