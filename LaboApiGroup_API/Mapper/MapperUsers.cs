using LaboApiGroup_API.Models;
using LaboApiGroup_BL.Models;

namespace LaboApiGroup_API.Mapper
{
    public static class MapperUsers
    {
        public static Users_C ToClient(this Users_BLL u_BLL)
        {
            return new Users_C()
            {
                Id = u_BLL.Id,
                NickName = u_BLL.NickName,
                Email = u_BLL.Email,
                BirthDate = u_BLL.BirthDate,
                IsAdmin = u_BLL.IsAdmin,
                IsActive = u_BLL.IsActive,
            };
        }

        public static Users_BLL ToBll(this Users_C users_C)
        {
            return new Users_BLL()
            {
                Id = users_C.Id,
                NickName = users_C.NickName,
                Email = users_C.Email,
                BirthDate = users_C.BirthDate,
                PassWord = users_C.PassWord,
                IsAdmin = users_C.IsAdmin,
                IsActive = users_C.IsActive,  
            };
        }

        public static Users_BLL LoginToBll(this Login_User users_C)
        {
            return new Users_BLL()
            {
                Email = users_C.Email,
                PassWord = users_C.Password,

            };
        }  
        public static UserWithToken ToUserWithToken(this Users_BLL users_C)
        {
            return new UserWithToken()
            {
                Guid = users_C.Id,
                NickName = users_C.NickName,
                IsAdmin = users_C.IsAdmin
            };
        }

        public static Users_BLL SwtichUserToBll(this SwitchUser su)
        {
            return new Users_BLL()
            {
                IsActive = su.Status,
                Id = su.Id_User
            };
        }

    }
}
