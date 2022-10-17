using LaboApiGroup_Repo.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboApiGroup_Repo.Repositories
{
    public class UserRepository : BasicRepository.BasicRepo<int, Users>
    {
        public UserRepository(string entityName, string idName) : base(entityName, idName)
        {
        }

        public override bool Delete(Users id)
        {
            throw new NotImplementedException();
        }

        public override int Insert(Users entity)
        {
            throw new NotImplementedException();
        }

        public override bool Update(Users data)
        {
            throw new NotImplementedException();
        }

        protected override Users Convert(IDataRecord dtr)
        {
            return new Users()
            {
                Id = (int)dtr["id"],
                Email = dtr["email"].ToString(),
                NickName = dtr["NickName"].ToString(),
                BirthDate = (DateTime)dtr["BirthDate"]
            };
        }
    }
}
