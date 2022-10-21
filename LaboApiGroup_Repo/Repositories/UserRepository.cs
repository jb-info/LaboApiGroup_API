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
        public UserRepository() : base("Users", "Id_Users")
        {           
        }

        public override bool Delete(Users id)
        {
            Command cmd = new("P_Users_Delete", true);
            cmd.AddParameter("Id_Users", id.Id);
            return base.ConnectionString.ExecuteNonQuery(cmd)==1;
        }

        public override Guid Insert(Users entity)
        {
            Command cmd = new("P_Users_Add", true);
            cmd.AddParameter("NickName", entity.NickName);
            cmd.AddParameter("BirthDate", entity.BirthDate);
            cmd.AddParameter("Email", entity.Email);
            cmd.AddParameter("PassWord",entity.PassWord);
            return (Guid)base.ConnectionString.ExecuteScalar(cmd);

        }

        public override bool Update(Users data)
        {
            Command cmd = new("P_Users_UPDATE", true);
            cmd.AddParameter("NickName", data.NickName);
            cmd.AddParameter("BirthDate", data.BirthDate);
            cmd.AddParameter("Email", data.Email);
            cmd.AddParameter("PassWord", data.PassWord);
            return base.ConnectionString.ExecuteNonQuery(cmd)==1;

        }

        public Users Login(Users u)
        {
            Command cmd = new("P_Users_Login", true);
            cmd.AddParameter("email", u.Email);
            cmd.AddParameter("Password", u.PassWord);
            return base.ConnectionString.ExecuteReader(cmd, Convert).SingleOrDefault();
        }

        protected override Users Convert(IDataRecord dtr)
        {
            return new Users()
            {
                Id = Guid.Parse(dtr["Id_User"].ToString()),
                Email = dtr["email"].ToString(),
                NickName = dtr["Nickname"].ToString(),
                BirthDate = (DateTime)dtr["Birthdate"]
            };
        }
    }
}
