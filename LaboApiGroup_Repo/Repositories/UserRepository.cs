using LaboApiGroup_DAL;
using LaboApiGroup_Repo.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboApiGroup_Repo.Repositories
{
    public class UserRepository : BasicRepository.BasicRepo<Guid, Users>
    {
        public UserRepository() : base("Users", "Id")
        {           
        }

        public override bool Delete(Users id)
        {
            throw new NotImplementedException();
        }

        public override Guid Insert(Users entity)
        {
            Command cmd = new("P_Users_Add", true);
            cmd.AddParameter("id", entity.Id);
            cmd.AddParameter("NickName", entity.NickName);
            cmd.AddParameter("BirthDate", entity.BirthDate);
            cmd.AddParameter("Email", entity.Email);
            cmd.AddParameter("PassWord",entity.PassWord);
            return (Guid)base.ConnectionString.ExecuteScalar(cmd);

        }

        public override bool Update(Users data)
        {
            throw new NotImplementedException();
        }

        protected override Users Convert(IDataRecord dtr)
        {
            return new Users()
            {
                Id = (Guid)dtr["id"],
                Email = dtr["email"].ToString(),
                NickName = dtr["NickName"].ToString(),
                BirthDate = (DateTime)dtr["BirthDate"]
            };
        }
    }
}
