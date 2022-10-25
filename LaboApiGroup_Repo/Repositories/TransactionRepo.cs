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
    public class TransactionRepo : BasicRepository.BasicRepo<int, Transactions>
    {
        public TransactionRepo() : base("Transaction", "Id")
        {
        }

        public override bool Delete(Transactions id)
        {
            Command cmd = new Command("DELETE FROM [Transaction] WHERE Id = @id");
            cmd.AddParameter("id", id.Id);
            return ConnectionString.ExecuteNonQuery(cmd) == 1;
        }

        public override int Insert(Transactions entity)
        {
            Command cmd = new Command("INSERT INTO [Transaction](Amount,Date_Transaction,Id_User, Id_Project)OUTPUT INSERTED.Id VALUES(@p1, @p2, @p3, @p4)");
            cmd.AddParameter("p1", entity.Amount);
            cmd.AddParameter("p2", entity.Date_Transaction);
            cmd.AddParameter("p3", entity.Id_User);
            cmd.AddParameter("p4", entity.Id_Project);

            return base.ConnectionString.ExecuteNonQuery(cmd);
        }

        public override bool Update(Transactions data)
        {
            Command cmd = new Command("UPDATE [Transaction] SET Amount = @Amount, Date_Transaction = @Date_Transaction WHERE Id = @id");
            

            cmd.AddParameter("Amount", data.Amount);
            cmd.AddParameter("Date_Transaction", data.Date_Transaction);
            cmd.AddParameter("id", data.Id);

            return base.ConnectionString.ExecuteNonQuery(cmd) == 1;
        }

        protected override Transactions Convert(IDataRecord dtr)
        {            
            return new Transactions()
            {
                Id = (int)dtr["Id"],
                Id_Project = dtr["Id_Project"]== DBNull.Value? 0 : (int)dtr["Id_Project"],
                Id_User = Guid.Parse(dtr["Id_User"].ToString()),
                Amount = (int)dtr["Amount"],
                Date_Transaction = (DateTime)dtr["Date_Transaction"]
            };
        }
    }
}
