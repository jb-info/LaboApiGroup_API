using LaboApiGroup_DAL;
using LaboApiGroup_Repo.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboApiGroup_Repo.Repositories.BasicRepository
{
    public abstract class BasicRepo<TKey, TEntity> : IRepository<TKey, TEntity>
        where TEntity : IEntity<TKey>
    {
        private string connexion = "Data Source = (localdb)\\MSSQLLocalDB;Initial Catalog = LaboApiGroup_DB; Integrated Security = True;";
        protected Connection ConnectionString { get; }
        protected string EntityName { get; }
        protected string IdName { get;}

        protected BasicRepo(string entityName, string idName)
        {
            ConnectionString = new Connection(SqlClientFactory.Instance, connexion);
            EntityName = entityName;
            IdName = idName;    
        }


        public TEntity Get(TKey id)
        {
            Command cmd = new Command("SELECT * FROM [" + EntityName + "] " +
                          "WHERE " + IdName + " = @Id");
            cmd.AddParameter("@Id", id);

            return ConnectionString.ExecuteReader(cmd, Convert).SingleOrDefault();
        }

        public IEnumerable<TEntity> GetAll()
        {
            Command cmd = new Command("SELECT * FROM [" + EntityName + "]");

            return ConnectionString.ExecuteReader(cmd, Convert);
        }

        protected abstract TEntity Convert(IDataRecord dtr);
        public abstract TKey Insert(TEntity entity);

        public abstract bool Update(TEntity data);
        public abstract bool Delete(TEntity id);
    }
}
