using LaboApiGroup_API.Models;
using LaboApiGroup_BL.Models;
using LaboApiGroup_Repo.Entities;

namespace LaboApiGroup_API.Mapper
{
    public static class MapperUserInProject
    {
        public static UserInProject_C UserInProjectBLToClient(this UsersInProject_BLL up_BLL)
        {
            return new UserInProject_C()
            {
                Id = up_BLL.Id,
                Id_Project=up_BLL.Id,
                Id_User=up_BLL.Id,
            };
        }
        public static UsersInProject_BLL ToBLL(this UserInProject_C  userinproject_C )
        {
            return new UsersInProject_BLL()
            {
                Id = userinproject_C.Id,
                Id_Project = userinproject_C.Id,
                Id_User = userinproject_C.Id,

            };
        }

    }
}

