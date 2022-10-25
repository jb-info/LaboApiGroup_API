using LaboApiGroup_API.Models;
using LaboApiGroup_BL.Models;

namespace LaboApiGroup_API.Mapper
{
    public static class MapperRoleOfUser
    {
        public static RoleOfUser_C RoleOfUserBLToClient(this RoleOfUser_BLL ru_BLL)
        {
            return new RoleOfUser_C()
            {
                Id = ru_BLL.Id,
                Id_User = ru_BLL.Id_User,
                Id_Role = ru_BLL.Id_Role
            };
        }
        public static RoleOfUser_BLL ToBLL(this RoleOfUser_C roleOfUser_C)
        {
            return new RoleOfUser_BLL()
            {
                Id = roleOfUser_C.Id,
                Id_User = roleOfUser_C.Id,
                Id_Role = roleOfUser_C.Id
                
            };
        }
    }
}
