using LaboApiGroup_BL.Models;
using LaboApiGroup_Repo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace LaboApiGroup_BL.Mapper
{
    public static class MapperTransactionsBLL
    {
        public static Transactions_BLL ToREPO(this Transactions tr_repo)
        {
            return new Transactions_BLL()
            {
                Id = tr_repo.Id,
                Id_Project = tr_repo.Id_Project,
                Id_User = tr_repo.Id_User,
                Amount = tr_repo.Amount,
                Date_Transaction = tr_repo.Date_Transaction,
            };
        }
        public static Transactions ToBLL(this Transactions_BLL tr)
        {
            return new Transactions()
            {
                Id = tr.Id,
                Id_Project = tr.Id_Project,
                Id_User = tr.Id_User,
                Amount = tr.Amount,
                Date_Transaction = tr.Date_Transaction,

            };
        }
    }
}
