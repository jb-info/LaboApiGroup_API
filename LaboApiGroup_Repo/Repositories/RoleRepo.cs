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
    public class RoleRepo : BasicRepository.BasicRepo<int, Role>
    {
        public RoleRepo() : base("Role", "Id")
        {
        }
        

       

        public override bool Delete(Role id)
        {
            Command cmd = new Command("P_Role_Delete", true);
            cmd.AddParameter("@id", id.Id);
            return ConnectionString.ExecuteNonQuery(cmd)==1;

        }

        public override int Insert(Role entity)
        {
            Command cmd = new Command("P_Role_Insert", true);
            cmd.AddParameter("@Name",entity.Name);
            return ConnectionString.ExecuteNonQuery(cmd);
        }

        public override bool Update(Role data)
        {
            Command cmd = new Command("P_Role_Update", true);
            cmd.AddParameter("@Name", data.Name);
            return ConnectionString.ExecuteNonQuery(cmd)==1;
        }

        protected override Role Convert(IDataRecord dtr)
        {
            return new Role
            {
                Id = (int)dtr["Id"],
                Name = dtr["Name"].ToString(),
            };
        }
    }
}
