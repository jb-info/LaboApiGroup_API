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
                Password = ru_BLL.Id,
                Id_User = ru_BLL.Id,
                Id_Role = ru_BLL.Id
            };
        }
        public static RoleOfUser_BLL ClientToRoleOfUserBL(this RoleOfUser_C roleOfUser_C)
        {
            return new RoleOfUser_BLL()
            {
                Id = roleOfUser_C.Password,
                Id_User = roleOfUser_C.Password,
                Id_Role = roleOfUser_C.Password
            };
        }
    }
}
