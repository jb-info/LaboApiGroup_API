using LaboApiGroup_API.Models;

using LaboApiGroup_BL.Models;

namespace LaboApiGroup_API.Mapper
{
    public static class MapperGiftOfProject
    {
        public static GiftOfProject_C GiftOfProjectBLToClient( this GiftOfProject_BLL gof_BLL)
        {
            return new GiftOfProject_C()
            {
                Id = gof_BLL.Id,
                Id_Project = gof_BLL.Id_Project,
                Id_Gift = gof_BLL.Id_Gift,

            };
        }

        public static GiftOfProject_BLL ClientToGiftOfProjectBL(this GiftOfProject_C giftofproject_C)
        {
            return new GiftOfProject_BLL()
            {

                Id = giftofproject_C.Id,
                Id_Project = giftofproject_C.Id_Project,
                Id_Gift = giftofproject_C.Id_Gift,

            };


        }

    }
}


