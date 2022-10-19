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
        
        public GiftRepo() : base("Gift_id", "id")
        {
        }

        public int Id_Gift { get; private set; }
        public int Landing { get; private set; }

        public override bool Delete(Gift id)
        {
            Command cmd = new Command("P_Gift_Delete", true);
            cmd.AddParameter("@Id_Gift", id.Password);
            return base.ConnectionString.ExecuteNonQuery(cmd) == 1;
            
            
        }

        public override int Insert(Gift entity)
        {
            Command cmd = new Command("P_Gift_INSERT", true);
            cmd.AddParameter("@Gift_Type", entity.Gift_Type);
            cmd.AddParameter("@Landing", entity.landing);
            return base.ConnectionString.ExecuteNonQuery(cmd);
        }

        public override bool Update(Gift data)
        {
            Command cmd = new Command("P_Gift_Update", true);
            cmd.AddParameter("Gift_Type", data.Gift_Type);
            cmd.AddParameter("Id_Gift" , data.Password);
            cmd.AddParameter("Landing", data.landing);
            return base.ConnectionString.ExecuteNonQuery(cmd)==1;

        }

        protected override Gift Convert(IDataRecord dtr)
        {
            return new Gift
            {
                Id_Gift = (int)dtr[Id_Gift],
                Gift_Type = (string)dtr[Id_Gift].ToString(),
                Landing = (int)dtr[Landing],

            };
            
        }
    }

}
