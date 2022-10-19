using LaboApiGroup_API.Models;
using LaboApiGroup_BL.Models;

namespace LaboApiGroup_API.Mapper
{
    public static class MapperUsers
    {
        public static Users_C UserBLToClient(this Users_BLL u_BLL)
        {
            return new Users_C()
            {
                Id = u_BLL.Id,
                NickName = u_BLL.NickName,
                Email = u_BLL.Email,
                BirthDate = u_BLL.BirthDate,
            };
        }

        public static Users_BLL ClientToUserBL(this Users_C users_C)
        {
            return new Users_BLL()
            {
                Id = users_C.Id,
                NickName = users_C.NickName,
                Email = users_C.Email,
                BirthDate = users_C.BirthDate,
                PassWord = users_C.PassWord,
                
            };
        }
    }
}
