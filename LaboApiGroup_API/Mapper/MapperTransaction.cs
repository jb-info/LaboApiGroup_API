using LaboApiGroup_API.Models;
using LaboApiGroup_BL.Models;

namespace LaboApiGroup_API.Mapper
{
    public static class MapperTransaction
    {
        public static Transactions_C TransactionBLToClient(this Transactions_BLL transactions_BLL)
        {
            return new Transactions_C()
            {
                Id = transactions_BLL.Id,
                Id_User = transactions_BLL.Id_User,
                Id_Project = transactions_BLL.Id_Project,
                Amount = transactions_BLL.Amount,
                Date_Transaction = transactions_BLL.Date_Transaction
            };
        }

        public static Transactions_BLL transactions_BL(this Transactions_C transactions_C)
        {
            return new Transactions_BLL()
            {
                Id = transactions_C.Id,
                Id_Project = transactions_C.Id_Project,
                Id_User = transactions_C.Id_User,
                Amount = transactions_C.Amount,
                Date_Transaction = transactions_C.Date_Transaction
            };
        }
    }
}
