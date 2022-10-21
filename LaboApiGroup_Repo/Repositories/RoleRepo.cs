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
        public RoleRepo() : base("Role", "Id_Role")
        {
        }

        public override bool Delete(Role id)
        {
            Command cmd = new Command("P_Role_DELETE", true);
            cmd.AddParameter("Id_Role", id.Id);
            return ConnectionString.ExecuteNonQuery(cmd) == 1;
        }

        public override int Insert(Role entity)
        {
            // Vérifier l'id
            Command cmd = new Command("INSERT INTO Role(Name)OUTPUT INSERTED.Id_Role VALUES(@p1)");
            cmd.AddParameter("p1", entity.Name);
            return ConnectionString.ExecuteNonQuery(cmd);
        }

        public override bool Update(Role data)
        {
            Command cmd = new Command("UPDATE Role SET Name = @Name WHERE Id_Role = @Id");
            cmd.AddParameter("Name", data.Name);
            cmd.AddParameter("Id", data.Id);

            return base.ConnectionString.ExecuteNonQuery(cmd) == 1;
        }

        protected override Role Convert(IDataRecord dtr)
        {
            return new Role()
            {
                Id = (int)dtr["Id_Role"],
                Name = dtr["Name"].ToString()
            };           
        }
    }
}
