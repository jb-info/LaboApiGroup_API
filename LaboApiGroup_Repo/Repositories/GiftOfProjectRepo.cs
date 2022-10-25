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
    public class GiftOfProjectRepo : BasicRepository.BasicRepo<int, GiftOfProject>
    {
        public GiftOfProjectRepo() : base("GiftOfProject", "Id")
        {
        }

        public override bool Delete(GiftOfProject id)
        {
            Command cmd = new Command("P_GiftOfProject_DELETE", true);
            cmd.AddParameter("Id", id.Id);
            return base.ConnectionString.ExecuteNonQuery(cmd) == 1;
        }

        public override int Insert(GiftOfProject entity)
        {
            Command cmd = new Command("P_GiftOfProject_INSERT", true);
            cmd.AddParameter("Id_Project", entity.Id_Project);
            cmd.AddParameter("Id_Gift", entity.Id_Gift);
            return base.ConnectionString.ExecuteNonQuery(cmd);
        }

        public override bool Update(GiftOfProject data)
        {
            Command cmd = new Command("P_GiftOfProject_UPDATE", true);
            cmd.AddParameter("Id", data.Id);
            cmd.AddParameter("Id_Project", data.Id_Project);
            cmd.AddParameter("Id_Gift", data.Id_Gift);
            return base.ConnectionString.ExecuteNonQuery(cmd) == 1;
        }

        protected override GiftOfProject Convert(IDataRecord dtr)
        {
            return new GiftOfProject()
            {
                Id = (int)dtr["Id"],
                Id_Gift = (int)dtr["Id_Gift"],
                Id_Project = (int)dtr["Id_Project"]
            };
        }
    }
}
