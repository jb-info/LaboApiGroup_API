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
            };
        }
    }
}
