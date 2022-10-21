﻿using LaboApiGroup_DAL;
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
            cmd.AddParameter("Id", id.Id);
            return base.ConnectionString.ExecuteNonQuery(cmd)==1;
        }

        public override Guid Insert(Users entity)
        {
            Command cmd = new("P_Users_Add", true);
            cmd.AddParameter("NickName", entity.NickName);
            cmd.AddParameter("BirthDate", entity.BirthDate);
            cmd.AddParameter("Email", entity.Email);
            cmd.AddParameter("Id",entity.Id);
            return (Guid)base.ConnectionString.ExecuteScalar(cmd);

        }

        public override bool Update(Users data)
        {
            Command cmd = new("P_Users_UPDATE", true);
            cmd.AddParameter("Id", data.Id);
            cmd.AddParameter("Email", data.Email);
            cmd.AddParameter("BirthDate", data.BirthDate);
            cmd.AddParameter("NickName", data.NickName);
            return base.ConnectionString.ExecuteNonQuery(cmd)==1;

        }

        protected override Users Convert(IDataRecord dtr)
        {
            return new Users()
            {
                Id = (Guid)dtr["Id"],
                Email = dtr["Email"].ToString(),
                NickName = dtr["Nickname"].ToString(),
                BirthDate = (DateTime)dtr["Birthdate"]
            };
        }
    }
}
