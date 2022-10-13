using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboApiGroup_DAL
{
    public class Connection
    {
        private readonly string _connectionString;
        private readonly DbProviderFactory _factory;

        /// <summary>
        /// Create a new connection for your DataBase
        /// </summary>
        /// <param name="factory">Create a nec DbProviderFactory to get all methods</param>
        /// <param name="connectionString"></param>
        public Connection(DbProviderFactory factory, string connectionString)
        {
            _factory = factory;
            _connectionString = connectionString;
            using (DbConnection connection = GetConnection())
            {
                connection.Open();
            }
        }
        /// <summary>
        /// Return an int by an ExecuteNonQuery
        /// </summary>
        /// <param name="command">Pass your command created by CreateCommand</param>
        /// <returns></returns>
        public int ExecuteNonQuery(Command command)
        {
            using (DbConnection connection = GetConnection())
            {
                using (DbCommand SqlCommand = CreateCommand(connection, command))
                {
                    connection.Open();
                    return SqlCommand.ExecuteNonQuery();
                }
            }
        }
        /// <summary>
        /// Retrun an object by an ExecuteScarlar
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        public object ExecuteScalar(Command command)
        {
            using (DbConnection connection = GetConnection())
            {
                using (DbCommand SqlCommand = CreateCommand(connection, command))
                {
                    connection.Open();
                    return SqlCommand.ExecuteScalar();
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="command"></param>
        /// <param name="selector"></param>
        /// <returns>yield return a IEnumerable of TResult</returns>
        public IEnumerable<TResult> ExecuteReader<TResult>(Command command, Func<IDataRecord, TResult> selector)
        {
            using (DbConnection connection = GetConnection())
            {
                using (DbCommand sqlCommand = CreateCommand(connection, command))
                {
                    connection.Open();
                    using (IDataReader dataReader = sqlCommand.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            yield return selector(dataReader);
                        }
                    }
                }
            }
        }
        public DataTable GetDataTable(Command command)
        {
            using (DbConnection connection = GetConnection())
            {
                using (DbCommand SqlCommand = CreateCommand(connection, command))
                {
                    connection.Open();
                    using (DbDataAdapter dataAptater = _factory.CreateDataAdapter())
                    {
                        dataAptater.SelectCommand = SqlCommand;
                        DataTable dataTable = new DataTable();
                        dataAptater.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns>an instance of SqlConnection</returns>
        private DbConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = _connectionString;
            return connection;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="command"></param>
        /// <returns></returns>
        private DbCommand CreateCommand(DbConnection connection, Command command)
        {
            DbCommand sqlCommand = connection.CreateCommand();
            sqlCommand.CommandText = command.Query;

            if (command.IsStoredProcedure)
            {
                sqlCommand.CommandType = CommandType.StoredProcedure;
            }
            foreach (KeyValuePair<string, object> kvp in command.Parameters)
            {
                DbParameter sqlParameter = _factory.CreateParameter();
                sqlParameter.ParameterName = kvp.Key;
                sqlParameter.Value = kvp.Value;

                sqlCommand.Parameters.Add(sqlParameter);
            }
            return sqlCommand;
        }
    }
}
}
