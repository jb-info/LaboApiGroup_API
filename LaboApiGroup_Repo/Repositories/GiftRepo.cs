using LaboApiGroup_DAL;
using LaboApiGroup_Repo.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboApiGroup_Repo.Repositories
{
    public class GiftRepo : BasicRepository.BasicRepo<int, Gift>
    {
        public GiftRepo(string entityName, string idName) : base(entityName, idName)
        {
        }

        public override bool Delete(Gift id)
        {
            throw new NotImplementedException();
        }

        public override int Insert(Gift entity)
        {
            throw new NotImplementedException();
        }

        public override bool Update(Gift data)
        {
            throw new NotImplementedException();
        }

        protected override Gift Convert(IDataRecord dtr)
        {
            throw new NotImplementedException();
        }
    }

}
