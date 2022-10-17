using LaboApiGroup_API.Models;
using LaboApiGroup_BL.Models;

namespace LaboApiGroup_API.Mapper
{
    public static class MapperProject
    {
        public static Project_C ProjectBLToClient(this Project_BLL p_BLL)
        {
            return new Project_C()
            {
                Id = p_BLL.Id,
                Start_Date = p_BLL.Start_Date,
                End_Date = p_BLL.End_Date,
                Description = p_BLL.Description,
                Title = p_BLL.Title,
                Financial_Targets = p_BLL.Financial_Targets,
                Earn_Money = p_BLL.Earn_Money

            };
        }

        public static Project_BLL ClientToProjectBL(this Project_C project_C)
        {
            return new Project_BLL()
            {
                Id = project_C.Id,
                Start_Date = project_C.Start_Date,
                End_Date = project_C.End_Date,
                Description = project_C.Description,
                Title = project_C.Title,
                Financial_Targets = project_C.Financial_Targets,
                Earn_Money = project_C.Earn_Money
            };
        }
    }
}
