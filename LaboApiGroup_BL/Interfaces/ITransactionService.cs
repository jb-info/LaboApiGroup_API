using LaboApiGroup_BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboApiGroup_BL.Interfaces
{
    public interface ITransactionService : IGlobalInterfaces<int, Transactions_BLL>
    {
        int GetFullTransacOfUser(Guid id, int idProject);
        IEnumerable<Gift_BLL> GetGifts(Guid id, int IdProject);
    }
}
