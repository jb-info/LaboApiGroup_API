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
    public class RoleOfUserRepo : BasicRepository.BasicRepo<int, RoleOfUser>
    {
        public RoleOfUserRepo() : base("RoleOfProject", "Id")
        {

        }
        public override bool Delete(RoleOfUser id)
        {
            Command cmd = new Command("P_RoleOfUser_DELETE", true);
            cmd.AddParameter("id", id.Id);
            return base.ConnectionString.ExecuteNonQuery(cmd) == 1;
        }

        public override int Insert(RoleOfUser entity)
        {
            Command cmd = new Command("P_RoleOfUser_INSERT", true);
            cmd.AddParameter("Id_User", entity.Id_User);
            cmd.AddParameter("Id_Role", entity.Id_Role);
            return base.ConnectionString.ExecuteNonQuery(cmd);
        }

        public override bool Update(RoleOfUser data)
        {
            Command cmd = new Command("P_RoleOfUser", true);
            cmd.AddParameter("id", data.Id);
            cmd.AddParameter("Id_User", data.Id_User);
            cmd.AddParameter("Id_Role", data.Id_Role);
            return base.ConnectionString.ExecuteNonQuery(cmd) == 1;
        }

        protected override RoleOfUser Convert(IDataRecord dtr)
        {
            return new RoleOfUser()
            {
                Id = (int)dtr["Id"],
                Id_User = (int)dtr["Id_User"],
                Id_Role = (int)dtr["Id_Role"]

            };
        }
    }
}
