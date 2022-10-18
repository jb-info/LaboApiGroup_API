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
        public TransactionRepo() : base("Transactions", "Id")
        {
        }

        public override bool Delete(Transactions id)
        {
            Command cmd = new Command("DELETE FROM Transactions WHERE Id = @id");
            cmd.AddParameter("id", id);
            return ConnectionString.ExecuteNonQuery(cmd) == 1;
        }

        public override int Insert(Transactions entity)
        {
            Command cmd = new Command("INSERT INTO Transactions(Amount," +
                "                                     Date_Transaction)" +
                "                            OUTPUT INSERTED.Id VALUES(" +
                "                                            @p1, @p2)");
            cmd.AddParameter("p1", entity.Amount);
            cmd.AddParameter("p2", entity.Date_Transaction);

            return base.ConnectionString.ExecuteNonQuery(cmd);
        }

        public override bool Update(Transactions data)
        {
            Command cmd = new Command("UPDATE Transactions SET Amount = @Amount," +
                "                                               Date_Transaction = @Date_Transaction" +
                "                                      WHERE Id = @id");

            cmd.AddParameter("Amount", data.Amount);
            cmd.AddParameter("date", data.Date_Transaction);
            cmd.AddParameter("id", data.Id);

            return base.ConnectionString.ExecuteNonQuery(cmd) == 1;
        }

        protected override Transactions Convert(IDataRecord dtr)
        {
            return new Transactions
            {
                Id = (int)dtr["Id"],
                Id_Project = (int)dtr["Id_Project"],
                Id_User = (int)dtr["Id_User"],
                Amount = (int)dtr["Amount"],
                Date_Transaction = (DateTime)dtr["Date_Transaction"]
            };
        }
    }
}
