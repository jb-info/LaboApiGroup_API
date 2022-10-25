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
    public class UserInProjectRepo : BasicRepository.BasicRepo<int, UserInProject>
    {
        public UserInProjectRepo() : base("UserInProject", "Id")
        {
        }

        public override bool Delete(UserInProject id)
        {
            Command cmd = new Command("DELETE FROM UserInProject WHERE Id = @Id");
            cmd.AddParameter("id", id.Id);
            return base.ConnectionString.ExecuteNonQuery(cmd) == 1;
        }

        public override int Insert(UserInProject entity)
        {
            Command cmd = new Command("INSERT INTO UserInProject (Id, Id_Project, Id_User) OUTPUT INSERTED.Id VALUES(@p1, @p2, @p3)");
            cmd.AddParameter("p1", entity.Id);
            cmd.AddParameter("p2", entity.Id_Project);
            cmd.AddParameter("p3", entity.Id_User);

            return base.ConnectionString.ExecuteNonQuery(cmd);
        }

        public override bool Update(UserInProject data)
        {
            Command cmd = new Command("UPDATE UserInProject SET @Id = Id, @Id_Project = Id_Project, @Id_User = Id_User");
            cmd.AddParameter("Id", data.Id);
            cmd.AddParameter("Id_Project", data.Id_Project);
            cmd.AddParameter("Id_User", data.Id_User);

            return base.ConnectionString.ExecuteNonQuery(cmd) == 1;
        }

        protected override UserInProject Convert(IDataRecord dtr)
        {
            return new UserInProject
            {
                Id = (int)dtr["Id"],
                Id_Project = (int)dtr["Id_Project"],
                Id_User = (int)dtr["Id_User"]
            };
        }
    }
}
