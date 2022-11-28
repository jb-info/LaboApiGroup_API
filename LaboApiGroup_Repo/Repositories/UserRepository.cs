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
        public UserRepository() : base("Users", "Id_User")
        {           
        }

        public override bool Delete(Users id)
        {
            Command cmd = new("P_Users_Delete", true);
            cmd.AddParameter("Id", id.Id);
            return base.ConnectionString.ExecuteNonQuery(cmd)==1;
        }

        public override Guid Insert(Users entity)
        {
            Command cmd = new("P_Admin_UserAdd", true);
            cmd.AddParameter("Email", entity.Email);
            cmd.AddParameter("NickName", entity.NickName);
            cmd.AddParameter("BirthDate", entity.BirthDate);
            cmd.AddParameter("Password", entity.PassWord);
            cmd.AddParameter("IsAdmin",entity.IsAdmin);
            cmd.AddParameter("IsActive", entity.IsActive);
            return (Guid)base.ConnectionString.ExecuteScalar(cmd);

        }

        public Guid Register(Users u)
        {
            Command cmd = new("P_Users_Add", true);
            cmd.AddParameter("Email", u.Email);
            cmd.AddParameter("NickName", u.NickName);
            cmd.AddParameter("BirthDate", u.BirthDate);
            cmd.AddParameter("Password", u.PassWord);
            return (Guid)base.ConnectionString.ExecuteScalar(cmd);
        }

        public override bool Update(Users data)
        {
            Command cmd = new("P_Users_UPDATE", true);
            cmd.AddParameter("NickName", data.NickName);
            cmd.AddParameter("BirthDate", data.BirthDate);
            cmd.AddParameter("Email", data.Email);
            cmd.AddParameter("Password", data.PassWord);
            return base.ConnectionString.ExecuteNonQuery(cmd) == 1;

        }
        public bool SwitchStatus(Users data)
        {
            Command cmd = new("P_User_SwitchStatus", true);
            cmd.AddParameter("Id",data.Id);
            cmd.AddParameter("Status",data.IsActive);
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
                BirthDate = (DateTime)dtr["Birthdate"],
                IsAdmin = (bool)dtr["IsAdmin"],
                IsActive = (bool)dtr["IsActive"]
            };
        }
    }
}
