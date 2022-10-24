using LaboApiGroup_API.Models;
using LaboApiGroup_BL.Models;

namespace LaboApiGroup_API.Mapper
{
    public static class MapperGift
    {
        public static Gift_C GiftBLToClient(this Gift_BLL gift_BLL)
        {
            return new Gift_C()
            {
                Id = gift_BLL.Id,
                Gift_Type = gift_BLL.Gift_Type,
                Landing = gift_BLL.Landing
            };
        }

        public static Gift_BLL ClientToGiftBl(this Gift_C gift_C)
        {
            return new Gift_BLL()
            {
                Id = gift_C.Id,
                Gift_Type = gift_C.Gift_Type,
                Landing = gift_C.Landing
            };
        }
    }
}
