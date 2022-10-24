using LaboApiGroup_DAL;
using LaboApiGroup_Repo.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboApiGroup_Repo.Repositories
{
    public class GiftRepo : BasicRepository.BasicRepo<int, Gift>
    {
        
        public GiftRepo() : base("Gift", "id_Gift")
        {
        }
        

        public override bool Delete(Gift id)
        {
            Command cmd = new Command("P_Gift_Delete", true);
            cmd.AddParameter("@Id_Gift", id.Id);
            return base.ConnectionString.ExecuteNonQuery(cmd) == 1;
            
            
        }

        public override int Insert(Gift entity)
        {
            Command cmd = new Command("P_Gift_Add",true);
            cmd.AddParameter("@Gift_Type", entity.Gift_Type);
            cmd.AddParameter("@landing", entity.Landing);
            return base.ConnectionString.ExecuteNonQuery(cmd);
        }

        public override bool Update(Gift data)
        {
            Command cmd = new Command("P_Gift_UPDATE",true);
            cmd.AddParameter("Id_Gift", data.Id);
            cmd.AddParameter("Gift_Type", data.Gift_Type);
            cmd.AddParameter("landing", data.Landing);
            return base.ConnectionString.ExecuteNonQuery(cmd)==1;

        }

        protected override Gift Convert(IDataRecord dtr)
        {
            return new Gift()
            {
                Id= (int)dtr["Id_Gift"],
                Gift_Type=dtr["Gift_Type"].ToString(),
                Landing=(int)dtr["landing"]


            };
            
        }
    }

}
