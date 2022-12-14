using LaboApiGroup_API.Models;
using LaboApiGroup_BL.Models;

namespace LaboApiGroup_API.Mapper
{
    public static class MapperRole
    {
        public static Role_C RoleBLToClient(this Role_BLL role_BLL)
        {
            return new Role_C()
            {
                Id = role_BLL.Id,
                Name = role_BLL.Name
            };
        }
        public static Role_BLL ClientToRoleBL(this Role_C role_C)
        {
            return new Role_BLL()
            {
                Id = role_C.Id,
                Name = role_C.Name
            };
        }
    }
}
